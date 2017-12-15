using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Data.OleDb;


namespace TestoPesto.classes
{
    class RunTest
    {
        private FormControlsData controlData = new FormControlsData();
        public string Url = "https://games.coffeebeansgames.com/goldentreecbgen/default.aspx?gameid=3CardPoker&sEXT1=OCP001243444&sEXT2=634929&ul=en";
        private string langPath;
        private string language;
        private string timestamp;
        private string server;
        public int timeToLoad, rowsSum;
        public string opath;
        int cnt = 0;
        private int cntNotLoaded = 0;

        IWebDriver _driver;
        ScreenShot pic = new ScreenShot();
        DataTable gamesDataTable = new DataTable();
        DataTable configDataTable = new DataTable();
        Bitmap img;

        public void runTest(FormControlsData controlData)
        {
            getchrome();
            string status = "";
            
            _driver.Navigate().GoToUrl("google.com");
            this.controlData = controlData;

            string urlP1 = "", urlP2 = "", account = "", pass = "", game = "";

            timeToLoad = int.Parse(controlData.secondsPerPage);
            language = controlData.language;
            server = controlData.server;
            account = controlData.accountNo;
            pass = controlData.pinCode;
            CurrentDirectoryPath = Directory.GetCurrentDirectory() + @"\\printScreen\\";
            DirectoryInfo odi = Directory.CreateDirectory(CurrentDirectoryPath);


            timestamp = DateTime.Now.ToString("yyyy-MM-dd--hhmm");
            string directoryPath = CurrentDirectoryPath + server + "_" + language + "_" + timestamp + "_" + controlData.folderLabel + "\\";
            DirectoryInfo di = Directory.CreateDirectory(directoryPath);


            langPath = directoryPath;
            openExcelToConfigDT();

            
            if (openExcelToGamesDT() == 1)
            {

                foreach (DataRow row in configDataTable.Rows)
                {
                    if (row[0].ToString() == controlData.server.ToString())
                    {
                       if (account=="")  account = row[1].ToString();
                       if (pass == "") pass = row[2].ToString();
                       if (urlP1 == "") urlP1 = row[3].ToString();

                       urlP2 = "&sEXT1=" + account + "&sEXT2=" + pass + "&ul=";

                    }
                }



                rowsSum = gamesDataTable.Rows.Count;
                controlData.rowCount.Invoke((Action)(() => controlData.rowCount.Text = gamesDataTable.Rows.Count.ToString()));
                controlData.lbl_countGames.Invoke((Action)(() => controlData.lbl_countGames.Text = gamesDataTable.Rows.Count.ToString()));
                foreach (DataRow row in gamesDataTable.Rows)
                {
                    try
                    {
                        int time=0;
                        long length =0;

                        Url = urlP1 + row[0].ToString() + urlP2 + language;
                        _driver.Navigate().GoToUrl(Url);
                        
                   
                        game = row[0].ToString();


                        do
                        {

                            pic.TakeScreenshot(_driver, langPath, game);
                            img = new Bitmap(langPath + "\\" + game + ".Png");
                            length = new System.IO.FileInfo(langPath + "\\" + game + ".Png").Length;


                            if (length <= 100000 && time < timeToLoad)
                            {
                                img.Dispose();
                                System.IO.File.Delete(langPath + "\\" + game + ".Png");
                              
                            }
                            else if (length >= 100000)
                            {
                                img.Dispose();
                                System.IO.File.Delete(langPath + "\\" + game + ".Png");
                                break;
                            }


                         
                            System.Threading.Thread.Sleep(2000);

                            time++;
                        } while (time != timeToLoad);



                        
                        pic.TakeScreenshot(_driver, langPath, game);
                        img = new Bitmap(langPath + "\\" + game + ".Png");
                        var newImage = new Bitmap(160, 150);
                        Graphics.FromImage(newImage).DrawImage(img, 0, 0, 160, 150);
                        Bitmap bmp = new Bitmap(newImage);


                        if (length <= 100000)
                        {

                            status = "err";
                            cntNotLoaded++;
                        }

                        controlData.dg_games.Invoke((Action)(() => controlData.dg_games.Rows.Add(status, row[0].ToString(), length, Url, bmp,time)));

                        if (length <= 100000)
                        {
                            controlData.dg_games.Invoke((Action)(() => controlData.dg_games.Rows[cnt].Cells[0].Style.ForeColor = Color.Red));
                            controlData.dg_games.Invoke((Action)(() => controlData.dg_games.Rows[cnt].Cells[1].Style.ForeColor = Color.Red));
                            controlData.dg_games.Invoke((Action)(() => controlData.dg_games.Rows[cnt].Cells[2].Style.ForeColor = Color.Red));
                            controlData.lbl_notLoaded.Invoke((Action)((() => controlData.lbl_notLoaded.Text = cntNotLoaded.ToString())));
                        }


                        _driver.Navigate().GoToUrl("");

                        rowsSum--;
                        cnt++;
                        status = "";
                        controlData.rowCount.Invoke((Action)(() => controlData.rowCount.Text = rowsSum.ToString()));

                    }

                    catch
                    {
                        //controlData.dg_games.Invoke((Action)(() => controlData.dg_games.Rows.Add(row[0].ToString(), "")));
                        _driver.Navigate().GoToUrl("");
                    }
                }


                stop();
            }
        }




        public void exportToExcel()
        {
            ExportToExcel exportToExcel = new ExportToExcel();
            exportToExcel.exportToExcel(langPath,server,language,timestamp,controlData);

        }



        private int openExcelToGamesDT()
        {
       
                string appPath;

                appPath = Directory.GetCurrentDirectory();
                OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "\\games.xlsx;Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
            OleDbCommand gamesConn;


            if (controlData.txt_gameSheet.Text == "")
            {
                 gamesConn = new OleDbCommand("select * from [games$]", cnn);
                
            }
            else
            {

                 gamesConn = new OleDbCommand("select * from ["+ controlData.txt_gameSheet.Text +"$]", cnn);
            }
            
            
            
            
            cnn.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(gamesConn);

                adp.Fill(gamesDataTable);
                controlData.GamesDataTable = gamesDataTable;

                return 1;               

                cnn.Close();
        }




        private int openExcelToConfigDT()
        {

            string appPath;

            appPath = Directory.GetCurrentDirectory();
            OleDbConnection configonConnectionn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "\\games.xlsx;Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");

            OleDbCommand configConn = new OleDbCommand("select * from [TestConfig$]", configonConnectionn);
            configonConnectionn.Open();
            OleDbDataAdapter adp = new OleDbDataAdapter(configConn);

            adp.Fill(configDataTable);
            controlData.ConfigDataTable = configDataTable;

            return 1;

            configonConnectionn.Close();
        }



        public void getchrome()
        {
            try
            {
                utilis uutil = new utilis();
                string path = uutil.getApplicationPathName();
                _driver = new ChromeDriver(path);

            }
            catch
            {
                MessageBox.Show("Browser driver cant load");
            }
        }



        public void stop()
        {
            try
            {
                exportToExcel();

                rowsSum = 0;
                _driver.Close();
                _driver.Quit();
                gamesDataTable.Clear();
                cnt = 0;

                controlData.lbl_countGames.Invoke((Action)(() => controlData.lbl_countGames.Text = "0"));
            }
            catch
            {

            }
                
        }


        public string CurrentDirectoryPath { get; set; }
    }
}

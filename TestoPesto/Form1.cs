using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using TestoPesto.classes;
using System.Runtime.InteropServices;
using System.Text;
using OpenQA.Selenium;
//using FlashSelenium;
//using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;


namespace TestoPesto
{
    public partial class Form1 : Form
    {
        //private IWebDriver _driver = null;

        public string Url = "https://games.coffeebeansgames.com/goldentreecbgen/default.aspx?gameid=3CardPoker&sEXT1=OCP001243444&sEXT2=634929&ul=en";

        private int pause = 0;
        private DataTable dt = new DataTable();
        private DataTable dtLang = new DataTable();
        private Thread thr;
        private FormControlsData controlData = new FormControlsData();
        RunTest run = new RunTest();
        int cnt;
        int sec;

        public Form1()
        {
            InitializeComponent();
            txt_folderLabel.Text = Environment.MachineName;
        }


        private void btn_go_Click(object sender, EventArgs e)
        {

            controlData.accountNo = txt_accountNo.Text;
            controlData.language = cmb_language.Text;
            controlData.pinCode = txt_pass.Text;
            controlData.secondsPerPage = txt_timeToLoadPage.Text;
            controlData.server = cmb_server.Text;
            controlData.folderLabel = txt_folderLabel.Text;
            controlData.dg_games = dg_gameList;
            controlData.rowCount = lbl_rowCount;
            controlData.lbl_countGames = lbl_countGames;
            controlData.lbl_notLoaded = lbl_notLoaded;
            controlData.txt_url = txt_url;
            controlData.txt_gameSheet = txt_gameSheet;
            
            txt_accountNo.Enabled = false;
            txt_pass.Enabled = false;
            txt_timeToLoadPage.Enabled = false;
            txt_folderLabel.Enabled = false;
            txt_url.Enabled = false;
            txt_gameSheet.Enabled = false;
            cmb_language.Enabled = false;
            cmb_server.Enabled = false;
            btn_clearGrid.Enabled = false;
            btn_pause.Enabled = true;
            thr = new Thread(this.runTest);
            thr.Start();
            //   this.runTest();
            btn_stop.Enabled = true;
            btn_go.Enabled = false;

            tmr_timeLeft.Enabled = true;


        }


        private void runTest()
        {
            run.runTest(controlData);
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                run.stop();
                thr.Abort();
                Application.Exit();
            }
            catch (Exception)
            {
                Application.Exit();
            }

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                run.stop();
                btn_stop.Enabled = false;
                thr.Abort();
                btn_go.Enabled = true;
                txt_accountNo.Enabled = true;
                txt_pass.Enabled = true;
                txt_timeToLoadPage.Enabled = true;
                txt_folderLabel.Enabled = true;
                txt_gameSheet.Enabled = true;
                cmb_language.Enabled = true;
                cmb_server.Enabled = true;
                lbl_rowCount.Text = "0";
                btn_clearGrid.Enabled = true;
                btn_pause.Enabled = false;
                txt_url.Enabled = true;
                sec = 0;

            }
            catch
            {
                MessageBox.Show("Chrome driver is not running");
            }
        }

        private void btn_clearGrid_Click(object sender, EventArgs e)
        {
            dg_gameList.Rows.Clear();
        }

        private void dg_gameList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    // Open the link in the default browser
                    System.Diagnostics.Process.Start(dg_gameList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                catch
                {

                }

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_rowCount.Text = "0";
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;

            dg_gameList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            foreach (DataGridViewRow row in dg_gameList.Rows)
                row.Visible = true;

            //  row.Cells[1].Value.ToString().Contains(searchValue) 
            try
            {
                foreach (DataGridViewRow row in dg_gameList.Rows)
                {
                    if (Regex.IsMatch(row.Cells[1].Value.ToString(), searchValue, RegexOptions.IgnoreCase))
                    {

                        //row.Selected = true;
                        row.Visible = true;

                    }
                    else
                    {
                        row.Visible = false;
                    }

                }




            }
            catch (Exception exc)
            {
                //MessageBox.Show(exc.Message);
            }

        }




        private void btn_ExportToExcel_Click_1(object sender, EventArgs e)
        {
            run.exportToExcel();
        }

        private void btn_openFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Directory.GetCurrentDirectory() + @"\printScreen");
        }





        private void tmr_timeLeft_Tick(object sender, EventArgs e)
        {

            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();


            if (sec >= 1)
            {
                cnt = Int32.Parse(lbl_rowCount.Text);
                sec = Int32.Parse(txt_timeToLoadPage.Text) * cnt;
                sec--;
            }
            else
            {
                cnt = Int32.Parse(lbl_rowCount.Text);
                sec = Int32.Parse(txt_timeToLoadPage.Text) * cnt;
            }

            TimeSpan elapsedTime = new TimeSpan();

            startTime = DateTime.Now;

            elapsedTime = DateTime.Now - startTime.AddSeconds(sec);


            lbl_timeLeft.Text = elapsedTime.ToString();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (pause == 1)
            {
                btn_pause.Text = "Pause";
                pause = 0;
                thr.Resume();
            }
            else
            {
                btn_pause.Text = "Resum";
                pause = 1;
                thr.Suspend();

            }
        }
    }
}

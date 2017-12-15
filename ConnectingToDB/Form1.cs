using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConnectingToDB
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ChromeDriver dr = new ChromeDriver();
            //dr.Navigate().GoToUrl("http://cps-qa.london.autodata.net/autodata-cvu");

            SqlConnection myConnection = new SqlConnection("user id=cada_qa;" +
                                       "password=qa_cada;" +
                                       "server=LN-QA-SQL1;" +
                                       "Trusted_Connection=yes;" +
                                       "database=CVU; " +
                                       "connection timeout=30");



           
                //myConnection.Open();

            //SqlDataReader myReader = null;
            SqlCommand myCommand;// = new SqlCommand("select * from [CVU].[dbo].[Country]", myConnection);




            string sql = null;
            SqlDataReader dataReader;
            sql = "select * from [CVU].[dbo].[Country]";
           
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand(sql, myConnection);
                dataReader = myCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    MessageBox.Show(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2));
                }
                dataReader.Close();
                myCommand.Dispose();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


        }



        [TestMethod]
        public void TestDragDrop()
        {
            IWebDriver driver = new ChromeDriver(@"C:\ChromeDriver\");
            driver.Navigate().GoToUrl("http://dl.dropbox.com/u/55228056/DragDropDemo.html");

            IWebElement source = driver.FindElement(By.Id("draggable"));
            IWebElement target = driver.FindElement(By.Id("droppable"));

            Actions builder = new Actions(driver);
            builder.DragAndDrop(source, target).Perform();
            Assert.AreEqual("Dropped!", target.Text);

            driver.Close();
        }





    }
}

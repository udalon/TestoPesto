using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Safari;

namespace TestoPesto.classes
{
   public class FormControlsData
    {
       public string language;
       public string secondsPerPage;
       public string server;
       public string accountNo;
       public string pinCode;
       public string folderLabel;
       public Label rowCount;
       public Label lbl_countGames;
       public Label lbl_notLoaded;
       public TextBox txt_url;
       public TextBox txt_gameSheet;
       public DataTable GamesDataTable;
       public DataTable ConfigDataTable;
       public DataGridView dg_games;


       public FormControlsData()
       {
       }

       public FormControlsData(string language, string secondsPerPage, string server, string accountNo, string pinCode, TextBox txt_url ,TextBox txt_gameSheet, DataGridView dg_games, Label rowCount, Label lbl_notLoaded, Label lbl_countGames, string folderLabel)
       {
           this.language = language;
           this.secondsPerPage = secondsPerPage;
           this.server = server;
           this.accountNo = accountNo;
           this.pinCode = pinCode;
           this.txt_gameSheet = txt_gameSheet;
           this.dg_games = dg_games;
           this.rowCount = rowCount;
           this.folderLabel = folderLabel;
           this.lbl_countGames = lbl_countGames;
           this.lbl_notLoaded = lbl_notLoaded;
           this.txt_url = txt_url;
       }



    }
}

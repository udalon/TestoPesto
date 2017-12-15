
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Globalization;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace TestoPesto
{
  public  class utilis
    {
        public string Name { get; private set; }

        public string EnviromentCountry { set; get; }

        public string EnviromentLanguage { set; get; }
        public string EnviromentLanguageIsoName { set; get; }

        public string EnviromentCurrency { set; get; }
        public string EnviromentCurrencySymbol { set; get; }

        //=============================================================================================================
        public void getEnviromentCultureInfo()
        {
            // Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\International", reg.entry, reg.value)

            var dtf = CultureInfo.CurrentCulture;
            EnviromentLanguage = dtf.EnglishName;
            EnviromentLanguageIsoName = dtf.TwoLetterISOLanguageName;

            EnviromentCountry = RegionInfo.CurrentRegion.EnglishName;

            var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentUICulture.LCID);
            EnviromentCurrency = ri.CurrencyNativeName;
            EnviromentCurrencySymbol = ri.CurrencySymbol;
        }

        //================================================================================================
        //get application name .. .. 
        public static string ApplicationName
        {
            get { return System.Reflection.Assembly.GetEntryAssembly().GetName().Name; }
        }

        //================================================================================================
        //get application full path name . ... 
        public string getApplicationPathName()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var folder = System.IO.Path.GetDirectoryName(path);
            return folder;
        }

        //=============================================================================================================

    }
}



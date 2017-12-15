using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Imaging;
using OpenQA.Selenium;

namespace TestoPesto.classes
{
    public class ScreenShot
    {

        public void TakeScreenshot(IWebDriver driver, string saveLocation, string gameName)
        {
            try
            {
                int langt;
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();

                screenshot.SaveAsFile(saveLocation + "\\" + gameName + ".Png", ImageFormat.Png);
            }
            catch
            {
                //MessageBox.Show("Can't Take picture");
            }

        }
    }
}

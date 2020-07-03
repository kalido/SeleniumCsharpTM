using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver init(IWebDriver okami) 
        {
            okami = new ChromeDriver();
            okami.Manage().Window.Maximize();
            okami.Url = "https://www.facebook.com/";
            return okami;
        }
    }
}

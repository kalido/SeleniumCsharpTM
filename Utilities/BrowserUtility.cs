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
        public IWebDriver init(IWebDriver Driver) 
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            return Driver;
        }
    }
}

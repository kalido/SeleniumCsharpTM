using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumProject.BaseClass;
using SeleniumProject.Utilities;
using SeleniumProject.WebElements;

namespace SeleniumProject
{
    [TestFixture]
    public class HomeYoutube
    {
        IWebDriver driver;
        
        [Test]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().init(driver);
            Driver.Url = "https://www.digitalife.com.mx/";
            HomePage home = new HomePage(Driver);
            home.SearchBox.SendKeys("RX 5700");
            Thread.Sleep(5000);
            Driver.Close();
        }

        [Test]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().init(driver);
            Driver.Url = "https://www.digitalife.com.mx/";
            HomePage home = new HomePage(Driver);
            home.SearchBox.SendKeys("RTX 2060");
            Thread.Sleep(5000);
            Driver.Close();
        }

        [Test]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().init(driver);
            Driver.Url = "https://www.digitalife.com.mx/";
            HomePage home = new HomePage(Driver);
            home.SearchBox.SendKeys("Ryzen 5");
            Thread.Sleep(5000);
            Driver.Close();
        }


    }
}
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumProject.BaseClass
{
    
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void NavigateTo(string url)
        {
            driver.Url = url;
        }

        [TearDown]
        public void Close()
        {
            driver.Dispose();
            driver = null;
        }
    }
}

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
using SeleniumProject.WebElements;

namespace SeleniumProject
{
    [TestFixture]
    public class TestClass : BaseTest
    {


        [Test]
        [Category("Regression Testing")]
        public void TestMethod2()
        {
            NavigateTo("https://www.digitalife.com.mx/");
            HomePage homepage = new HomePage(driver);
            homepage.SearchBox.SendKeys("Rx 5700");
            Thread.Sleep(3000);
        }



    }
}
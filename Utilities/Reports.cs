using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace SeleniumProject
{

    [TestFixture]
    class Reports
    {
        ExtentReports extent = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\WarZone\source\repos\SeleniumProject\Reports\Reports.html");
            extent.AttachReporter(htmlReporter);

        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        [Test]
        public void Testnumber1()
        {
            IWebDriver okami = null;
            ExtentTest test = null;

            try
            {
                test = extent.CreateTest("Test1").Info("Test started");
                okami = new ChromeDriver();
                okami.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser lauched");
                okami.Url = "https://wwww.facebook.com/";
                IWebElement EmailTextinput = okami.FindElement(By.XPath(".//*[@id='email']"));
                EmailTextinput.SendKeys("Selenium C#");
                test.Log(Status.Info, "Email id Entered");
                okami.Quit();
                test.Log(Status.Pass, "Test1 Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
            finally
            {
                if (okami != null)
                {
                    okami.Quit();
                }
            }
        }

        [Test]
        public void Testnumber2()
        {
            IWebDriver okami = null;
            ExtentTest test = null;

            try
            {
                test = extent.CreateTest("Test1").Info("Test started");
                okami = new ChromeDriver();
                okami.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser lauched");
                okami.Url = "https://wwww.facebook.com/";
                IWebElement EmailTextinput = okami.FindElement(By.XPath(".//*[@id='emailx']"));
                EmailTextinput.SendKeys("Selenium C#");
                test.Log(Status.Info, "Email id Entered");
                okami.Quit();
                test.Log(Status.Pass, "Test1 Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());                   
                throw;
            }
            finally
            {
                if (okami != null)
                {
                    okami.Quit();
                }
            }
        }




    }
}

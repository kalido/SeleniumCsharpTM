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
    public class TestHomePage : BaseTest
    {

        [Test]
        public void Check_Correct_URL()
        {
            driver.Url = "https://www.digitalife.com.mx";
            HomePage homepage = new HomePage(driver);
            homepage.SearchBox.SendKeys("5700");
            homepage.Buscar.Click();
            Thread.Sleep(3000);
        }

        [Test]
        public void SimpleSearchBox()
        {
            driver.Url = "https://www.digitalife.com.mx";
            HomePage homepage2 = new HomePage(driver);
            homepage2.SearchBox.SendKeys("RTX 2060");
            homepage2.Buscar.Click();
            Thread.Sleep(3000);
        }

        [Test]
        public void SimpleSearchBoxListComplete()
        {
            driver.Url = "https://www.digitalife.com.mx";
            HomePage homepage3 = new HomePage(driver);
            homepage3.SearchBox.SendKeys("Ryzen 5");
            homepage3.Buscar.Click();
            Thread.Sleep(3000);
        }


    }
}
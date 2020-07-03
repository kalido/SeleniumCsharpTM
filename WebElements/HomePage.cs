using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.WebElements
{
    class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage (IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchBox { get { return this.driver.FindElement(By.XPath("//input[@id='query']")); } }



    }
}

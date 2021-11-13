using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAtool
{
    class Search
    {

        IWebDriver driver = new ChromeDriver();


        [Test]
        public void testSearch()
        {
            driver.Url = "http://automationpractice.com/index.php";

            driver.FindElement(By.Id("search_query_top")).SendKeys("dress");
            driver.FindElement(By.Name("submit_search")).Click();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAtool
{
    class TestNunitClass
    {
        
        
            IWebDriver driver;

            [SetUp]
            public void startBrowser()
            {
                driver = new ChromeDriver();

            }

            [Test]
            public void test()
            {
                driver.Url = "http://automationpractice.com/index.php";
            }


            [TearDown]
            public void closeBrowser()
            {
            

            driver.Close();
            }
        
    }
}

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
    class ContactUs
    {
        IWebDriver driver = new ChromeDriver();


        [Test]
        public void testContactUs()
        {
            driver.Url = "http://automationpractice.com/index.php";
            // IWebDriver driver = new ChromeDriver();
            driver.FindElement(By.Id("contact-link")).Click();
        }
            
    }

    
}

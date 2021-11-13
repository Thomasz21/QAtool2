using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace QAtool
{
    public class Register
        
    {
        IWebDriver driver = new ChromeDriver();



        [Test]
        public void TestRegister()
        {

            driver.Url = "http://automationpractice.com/index.php";
            driver.Manage().Window.Maximize();
            // IWebDriver driver = new ChromeDriver();
            driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a")).Click(); //singin button
            driver.FindElement(By.Id("email_create")).SendKeys("testfactory1211@gmail.com");
            driver.FindElement(By.Id("SubmitCreate")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("id_gender2")).Click();
            driver.FindElement(By.Id("customer_firstname")).SendKeys("tom");
            driver.FindElement(By.Id("customer_lastname")).SendKeys("qa");
            driver.FindElement(By.Id("passwd")).SendKeys("12345");
            SelectElement select = new SelectElement(driver.FindElement(By.Id("days")));
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("months")));
            SelectElement select2 = new SelectElement(driver.FindElement(By.Id("years")));


            select.SelectByValue("1");
            select1.SelectByValue("2");
            select2.SelectByValue("1990");

            driver.FindElement(By.Id("firstname")).SendKeys("john");
            driver.FindElement(By.Id("lastname")).SendKeys("dow");
            driver.FindElement(By.Id("address1")).SendKeys("steet");
            driver.FindElement(By.Id("city")).SendKeys("fantasy");
            driver.FindElement(By.Id("postcode")).SendKeys("12345");
            driver.FindElement(By.Id("phone_mobile")).SendKeys("12345");

            SelectElement state = new SelectElement(driver.FindElement(By.Id("id_state")));

            state.SelectByText("Arizona");
            driver.FindElement(By.Id("submitAccount")).Click(); //click register

            string actualURL= driver.Url;

            Assert.AreEqual("http://automationpractice.com/index.php?controller=my-account", actualURL);





        }

    }
}

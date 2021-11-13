using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAtool
{
    class FirstTestCase
    {
        static void NoMain(string[] args)
        {
            //this is main class


            /* IWebDriver driver = new ChromeDriver();
             driver.Url = "https://www.demoqa.com";*/

            //BrowserOpen browserOpen = new();
            // browserOpen.startBrowser();
            //TestNunitClass testNunitClass = new();
            //ContactUs contactUs = new();
            // contactUs.testContactUs();

            //Search search = new();
            //search.testSearch();

            Register register = new();
            register.TestRegister();
           

            


       
        }
    }
}

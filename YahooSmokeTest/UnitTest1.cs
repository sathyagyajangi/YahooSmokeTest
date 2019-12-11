using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YahooSmokeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://beta-cricket-yahoo.sportz.io/";

            driver.Manage().Window.Maximize();

            string handle = driver.CurrentWindowHandle;

            for (int i = 6; i <= 11; i++)
            {

                string title = driver.FindElement(By.XPath("/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a")).GetAttribute("title");

                FunctionLibrary.clickAction(driver, "/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a", "xpath");



                Console.WriteLine(title);





                if (title.Contains("Series"))
                {




                    driver.FindElement(By.XPath("//*[@id='ff810ec5-1cca-4f8d-8d74-f5676bf6f436']/div/div[2]/div[2]/a[2]")).Click();

                    for (int j = 2; j <= 10; j++)
                    {


                        FunctionLibrary.clickAction(driver, "/html/body/div[1]/div/myapp/section[1]/div/div/div/div/section/div/div/div[2]/div/a[" + j + "]", "xpath");

                       
                        Console.WriteLine(driver.Title);

                    }


                }

                if (title.Contains("Rankings"))
                {

                    driver.Navigate().Back();
                }

                driver.Close();

            }








        }

    }
    
}

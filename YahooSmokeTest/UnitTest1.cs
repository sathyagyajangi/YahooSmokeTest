using System;
using System.Threading;
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

           

            for (int i = 2; i <= 11; i++)
            {

                string title = driver.FindElement(By.XPath("/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a")).GetAttribute("title");

                FunctionLibrary.waitForElement(driver, "/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a");


                FunctionLibrary.clickAction(driver, "/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a", "xpath");



                Console.WriteLine(title);





                if (title.Contains("Series"))
                {


                    driver.Navigate().GoToUrl("https://beta-cricket-yahoo.sportz.io/series/sri-lanka-tour-of-australia-2019-1111");

                    Thread.Sleep(2000);

                    for (int j = 2; j <= 8; j++)
                    {

                        FunctionLibrary.waitForElement(driver, "/html/body/div[1]/div/myapp/section[1]/div/div/div/div/section/div/div/div[2]/div/a[" + j + "]");

                        FunctionLibrary.clickAction(driver, "/html/body/div[1]/div/myapp/section[1]/div/div/div/div/section/div/div/div[2]/div/a[" + j + "]", "xpath");

                        Thread.Sleep(1000);
                        Console.WriteLine(driver.Title);

                    }


                }

                

               

            }





            driver.Close();


        }

    }
    
}

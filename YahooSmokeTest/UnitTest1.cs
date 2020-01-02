﻿using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace YahooSmokeTest
{
    [TestClass]
    public class UnitTest1
    {

        IWebDriver driver;


        [TestMethod]
      
        public void Local() 
        {

            IWebDriver driver = new ChromeDriver();
            string imgName = DateTime.Now.ToString("dd/MM/yyyy-HH-mm-ss");

            ExtentHtmlReporter reporter = new ExtentHtmlReporter("C:\\Users\\Satyanarayan\\source\\git\\YahooSmokeTest\\YahooSmokeTest\\Reports\\Local\\"  + imgName + "\\yahoo.html");
            ExtentReports extent = new ExtentReports();
            extent.AttachReporter(reporter);

            var test = extent.CreateTest("yahoolocal");

            try
            {
              

                driver.Url = "http://192.168.100.119:9097/";

                driver.Manage().Window.Maximize();



                for (int i = 2; i <= 11; i++)
                {

                    string title = driver.FindElement(By.XPath("/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a")).GetAttribute("title");

                    FunctionLibrary.waitForElement(driver, "/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a");


                    FunctionLibrary.clickAction(driver, "/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a", "xpath");



                    Console.WriteLine(title);

                    test.Log(Status.Pass, title  +  "Test case Passsed");



                    if (title.Contains("Series"))
                    {


                        driver.Navigate().GoToUrl("http://192.168.100.119:9097//series/sri-lanka-tour-of-australia-2019-1111");

                        Thread.Sleep(2000);

                        for (int j = 2; j <= 10; j++)
                        {
                            FunctionLibrary.waitForElement(driver, "/html/body/div[1]/div/myapp/section[1]/div/div/div/div/section/div/div/div[2]/div/a[" + j + "]");

                            FunctionLibrary.clickAction(driver, "/html/body/div[1]/div/myapp/section[1]/div/div/div/div/section/div/div/div[2]/div/a[" + j + "]", "xpath");

                            test.Log(Status.Pass, driver.Title +  "Test case Passsed");
                            Console.WriteLine(driver.Title);

                        }


                    }




                }
                driver.Close();
            }



            catch(Exception)
            {

                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                ss.SaveAsFile(@"C:\Users\Satyanarayan\source\git\YahooSmokeTest\YahooSmokeTest\Screenshot\\Local\\" + imgName + ".png");

                test.Log(Status.Fail,driver.Title + "Test case failed");
            }

           

            extent.Flush();

        }

        [TestMethod]
        public void beta()
        {

            IWebDriver driver = new ChromeDriver();


            string imgName = DateTime.Now.ToString("dd/MM/yyyy-HH-mm-ss");

            ExtentHtmlReporter reporter = new ExtentHtmlReporter("C:\\Users\\Satyanarayan\\source\\git\\YahooSmokeTest\\YahooSmokeTest\\Reports\\Beta\\" + imgName + "\\yahoo.html");
            ExtentReports extent = new ExtentReports();
            extent.AttachReporter(reporter);

            var test = extent.CreateTest("yahoobeta");

            try
            {
       

                driver.Url = "http://beta.cricket.yahoo.sportz.io/";

                driver.Manage().Window.Maximize();



                for (int i = 2; i <= 11; i++)
                {

                    string title = driver.FindElement(By.XPath("/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a")).GetAttribute("title");

                    FunctionLibrary.waitForElement(driver, "/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a");


                    FunctionLibrary.clickAction(driver, "/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a", "xpath");



                    Console.WriteLine(title);

                    test.Log(Status.Pass, title + "Test case Passsed");



                    if (title.Contains("Series"))
                    {


                        driver.Navigate().GoToUrl("https://beta.cricket.yahoo.sportz.io/series/sri-lanka-tour-of-australia-2019-1111");

                        Thread.Sleep(2000);

                        for (int j = 2; j <= 10; j++)
                        {
                            FunctionLibrary.waitForElement(driver, "/html/body/div[1]/div/myapp/section[1]/div/div/div/div/section/div/div/div[2]/div/a[" + j + "]");

                            FunctionLibrary.clickAction(driver, "/html/body/div[1]/div/myapp/section[1]/div/div/div/div/section/div/div/div[2]/div/a[" + j + "]", "xpath");

                            test.Log(Status.Pass, driver.Title + "Test case Passsed");
                            Console.WriteLine(driver.Title);

                        }


                    }




                }
                driver.Close();
            }



            catch (Exception)
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                ss.SaveAsFile(@"C:\Users\Satyanarayan\source\git\YahooSmokeTest\YahooSmokeTest\Screenshot\\Beta\\" + imgName + ".png");
                test.Log(Status.Fail,driver.Title +"Test case failed");
            }





            extent.Flush();
        }

        
    }
    
}

using System;
using System.IO;
using System.Reflection;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace NUnit
{
    [Parallelizable(ParallelScope.All)]
    public class Test : IDisposable
    {

        public IWebDriver driver;


        public void Initalizedriver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                case "Firefox":
                    driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                case "IE":
                    driver = new InternetExplorerDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                default:
                    driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
            }
        }







        public void Go()
        {

            // driver = new ChromeDriver();

            Initalizedriver("Chrome");
            string url = "https://www.cricbuzz.com";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

        }




        [Test]
        public void VerifyTitle1()
        {
            Go();
            string title = driver.Title;
            Thread.Sleep(1000);

            Assert.AreEqual("World Cup 2019, Cricket Score, Schedule, Latest News, Stats & Videos | Cricbuzz.com", title);
          
        }


        [Test]
        public void VerifyTitle2()
        {
            Go();
            string title = driver.Title;
            Thread.Sleep(1000);

            Assert.AreEqual("World Cup 2019, Cricket Score, Schedule, Latest News, Stats & Videos | Cricbuzz.com", title);
         
        }



        [Test]
        public void VerifyTitle3()
        {
            Go();
            string title = driver.Title;
            Thread.Sleep(1000);

            Assert.AreEqual("World Cup 2019, Cricket Score, Schedule, Latest News, Stats & Videos | Cricbuzz.com", title);
          
        }


        [Test]
        public void VerifyTitle7()
        {
            Go();
            string title = driver.Title;
            Thread.Sleep(1000);

            Assert.AreEqual("World Cup 2019, Cricket Score, Schedule, Latest News, Stats & Videos | Cricbuzz.com", title);
            
        }



        [Test]
        public void VerifyTitle5()
        {
            Go();
            string title = driver.Title;
            Thread.Sleep(1000);
            Assert.AreEqual("World Cup 2019, Cricket Score, Schedule, Latest News, Stats & Videos | Cricbuzz.com", title);
         
        }




        /**********Helper Methods *******/




        public void Dispose()
        {
            driver.Quit();
        }



    }
}

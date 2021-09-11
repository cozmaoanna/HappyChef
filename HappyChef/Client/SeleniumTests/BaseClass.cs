using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Remote;

namespace HappyChef.Client.SeleniumTests
{


    [TestFixture]
    public class BaseClass
    {
        public static string UserName;
        public static string Password;
        public static string URL;


        public BaseClass()
        {
            UserName = $"firstuser@testorg.com";
            Password = "D12c8x3@";
            URL = $"https://localhost:44316/";
        }

      
        [SetUp]
        public virtual void SetupTest()
        {

            switch (URL)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    var chromeOptions = new ChromeOptions();
                    
                    chromeOptions.AddArguments("window-size=1920,1080");
                    chromeOptions.AddArguments("start-maximized");
                    chromeOptions.AddArguments("disable-gpu");
                    chromeOptions.AddArguments("no-sandbox");
                    chromeOptions.AddArguments("ignore-certificate-errors"); //*/
                     driver = new ChromeDriver(chromeOptions);//*/
                    //driver = new ChromeDriver();
                    break;
            }


            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
//driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            waitSync = new WebDriverWait(driver, TimeSpan.FromSeconds(500));
            waitForToastMessage = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            longWait = new WebDriverWait(driver, TimeSpan.FromSeconds(250));

            //  driver.Navigate().GoToUrl(baseURL);

            // Init();
        }

        public virtual void Init()
{
    //throw new NotImplementedException();
}
        public static RemoteWebDriver driver;
        private StringBuilder verificationErrors = new StringBuilder();
        protected string baseURL;
        
        public WebDriverWait wait;
        public WebDriverWait waitSync;

         public WebDriverWait waitForToastMessage;
        public WebDriverWait longWait;







        [TearDown]
        public void TeardownTest()
        {
            try
            {
                //NewMethod();
                Thread.Sleep(5000);
                driver.Close();
                driver.Quit();


            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        public void Logout()
        {
            wait.Until(x => x.FindElements(By.Id("logoutTop")));
            var logoff = driver.FindElementById("logoutTop");
            logoff.Click();
            wait.Until(x => x.FindElements(By.ClassName("btn")).FirstOrDefault(y => y.Text == "Logout"));
            var logOut = driver.FindElementsByClassName("btn").FirstOrDefault(x => x.Text == "Logout");
            logOut.Click();
        }


        public void Search()
        {
            wait.Until(x => x.FindElements(By.CssSelector("recipesearch")).FirstOrDefault(y => y.Text == "Recipe"));
            driver.FindElementByCssSelector("a[href=recipesearch]");
                        
            var search = driver.FindElementsByClassName("round").FirstOrDefault(x => x.Text == "Recipe Name");
            search.SendKeys("Chocolate Chicken");

            wait.Until(x => x.FindElements(By.TagName("h4")).FirstOrDefault(y => y.Text == "Chocolate Chicken"));

        }

        public void AddToFavs()
        {
            var addToFavorites = driver.FindElementsByClassName("btn").FirstOrDefault(x => x.Text == "Add to Favorites");
            addToFavorites.Click();
            ToastMessageConfirm("added to favs");
        }
        

        public void ToastMessageConfirm(string msg)
        {
            wait.Until(x => x.FindElements(By.Id("toast-container")).FirstOrDefault(y => y.Text.ToLower().Contains(msg.ToLower())));
            
        }


    }




        
        


        





    
}

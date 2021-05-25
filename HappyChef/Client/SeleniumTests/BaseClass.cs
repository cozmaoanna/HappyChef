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

        public string HappyChefTestBaseURL { get; set; }

        public string HappyChefTestDBConnection { get; set; }


        public string HappyChefTestUsername { get; set; }

        public string HappyChefTestPassword { get; set; }

        public string HappyChefTestHeadless { get; set; }

       




        [SetUp]
        public void Setup()
        {
            HappyChefTestBaseURL = LoadEnvironmentVariable("HappyChefTestBaseURL");
            HappyChefTestDBConnection = LoadEnvironmentVariable("HappyChefTestDBConnection");
            HappyChefTestUsername = LoadEnvironmentVariable("HappyChefTestUsername");
            HappyChefTestPassword = LoadEnvironmentVariable("HappyChefTestPassword");
            HappyChefTestHeadless = LoadEnvironmentVariable("HappyChefTestHeadless");
        
        }

        public string LoadEnvironmentVariable(string environmentVariable)
        {
            if (Environment.GetEnvironmentVariable(environmentVariable) == null)
            {
                throw (new Exception("Need environment variable :" + environmentVariable));
            }
            else
            {
                return Environment.GetEnvironmentVariable(environmentVariable);
            }


        }

        public static RemoteWebDriver driver;
        private StringBuilder verificationErrors = new StringBuilder();
        protected string baseURL;

        public static string emailURL;
        public static string addUserName = "SeleniumTest@testorg.com";

        public WebDriverWait wait;
        public WebDriverWait waitSync;


        public WebDriverWait waitForToastMessage;
        public WebDriverWait longWait;


        public static string AddNewUserName;

        public static string newUserPassword;


        public static char[] toTrim = { '\\', '\"' };





        public static string NewClientPassword
        {
            get => newUserPassword;
            set => newUserPassword = value;
        }
        public static string NewEmailURL
        {

            get => $"{emailURL}".TrimEnd(toTrim);

            set => emailURL = value;
        }


        public BaseClass()
        {
            AddNewUserName = $"{addUserName}@testorg.com";
        }




        [SetUp]
        public virtual void SetupTest()
        {
            //ConfigHelper.FirefoxDriverOptions = new FirefoxOptions();
            //    ConfigHelper.FirefoxDriverOptions.BrowserExecutableLocation = @"C:\\prj\\Tools\\geckodriver - v0.23.0 - win64";

            //    ConfigHelper.WebDriverGlobal = new FirefoxDriver();
            //    //(ConfigHelper.FirefoxDriverOptions);


            //ReadOnlyCollection<IWebElement> element = wait.Until(
            //    //    ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Take '])[3]/following::span[1]")));

            switch (HappyChefTestBaseURL)
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
                    if (HappyChefTestHeadless.ToLower() == "true")
                    {
                        chromeOptions.AddArguments("headless");
                    }
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
        public virtual void Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

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

       


        public void LoginClientMethod()
        {
            driver.Navigate().GoToUrl(HappyChefTestBaseURL);
            wait.Until(x => x.FindElements(By.TagName("button")).FirstOrDefault(y => y.Text == "Sign In"));
            var username = driver.FindElementById("userName");
            username.SendKeys(HappyChefTestUsername);
            var password = driver.FindElementById("password");
            password.SendKeys(HappyChefTestPassword);
            var loginbutton = driver.FindElementByClassName("btn");
            loginbutton.Click();

            wait.Until(x => x.FindElements(By.TagName("h4"))).FirstOrDefault(y => y.Text == HappyChefTestUsername);
        }

        public void LoginAdminMethod()
        {
            driver.Navigate().GoToUrl(HappyChefTestBaseURL);
            wait.Until(x => x.FindElements(By.TagName("button")).FirstOrDefault(y => y.Text == "Sign In"));
            var username = driver.FindElementById("userName");
            username.SendKeys("admin@testorg.com");


            var password = driver.FindElementById("password");
            password.SendKeys("test123!");
            var loginbutton = driver.FindElementByClassName("btn");
            loginbutton.Click();

        }

        public void LogoutMethod()
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
            wait.Until(x => x.FindElements(By.ClassName("btn")).FirstOrDefault(y => y.Text == "Recipe"));
            var search = driver.FindElementsByClassName("btn").FirstOrDefault(x => x.Text == "Search");
            search.Click();
        }
      
        public void Recipe()
        {
            var recipeChicken = driver.FindElement(By.ClassName("fa-trash-alt"));

            // var deleteSnapshot = driver.FindElements(By.TagName("span")).FirstOrDefault(x => x.Text == "Delete Snapshot");
            recipeChicken.Click();

            wait.Until(x => x.FindElements(By.ClassName("card-body")).FirstOrDefault(x => x.Text.Contains("Chicken")));
            wait.Until(x => x.FindElements(By.ClassName("btn")).FirstOrDefault(x => x.Text.Contains("Confirm")));

            ConfirmButton();
        }

        public void ConfirmButton()
        {
            wait.Until(x => x.FindElements(By.ClassName("btn")).FirstOrDefault(y => y.Text == "Confirm"));
            var confirmButton = driver.FindElementsByClassName("btn").FirstOrDefault(x => x.Text == "Confirm");
            confirmButton.Click();
        }

        public void CloseXButton()
        {
            var closeX = driver.FindElementByClassName("close");
            closeX.Click();
        }
        public void SaveButton()
        {
            var saveButton = driver.FindElementsByClassName("btn").FirstOrDefault(x => x.Text == "Save");
            saveButton.Click();
        }


      


        protected IWebElement GetNewClientNameRow(string newClientName)
        {
            return driver.FindElementsByTagName("tr").FirstOrDefault(x => x.Text.ToLower().Contains(newClientName.ToLower()));
        }

        public void ToastMessageConfirm(string msg)
        {
            wait.Until(x => x.FindElements(By.Id("toast-container")).FirstOrDefault(y => y.Text.ToLower().Contains(msg.ToLower())));
            // var success = driver.FindElements(By.ClassName("toast-message")).FirstOrDefault(y => y.Text.ToLower().Contains(msg.ToLower()));
            //  Assert.IsNotNull(success);
        }


     



        public void deleteMailNewUser()
        {


            SqlConnection deleteNewUser = new SqlConnection(HappyChefTestDBConnection.ToString());


            try
            {
                string strSQL = @"delete Mail where Recipient like '%testUseraksdj%'";


                SqlDataAdapter adaptor = new SqlDataAdapter(strSQL, deleteNewUser);


                DataSet dataset = new DataSet();

                adaptor.Fill(dataset);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }



        }
        public void deleteUser()
        {


            SqlConnection deleteNewUser = new SqlConnection(HappyChefTestDBConnection.ToString());


          




            try
            {
                string strSQL = @"delete from Email where UserName like '%SeleniumTest%'";


                SqlDataAdapter adaptor = new SqlDataAdapter(strSQL, deleteNewUser);


                DataSet dataset = new DataSet();

                adaptor.Fill(dataset);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }



        }

       



    }
}

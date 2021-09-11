using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyChef.Client.SeleniumTests
{
    public class Login : BaseClass
    {
        [Test]
        public void LoginMethod()
        {
            driver.Navigate().GoToUrl(URL);
            driver.FindElementByCssSelector("a[href=authentication/login]");
            wait.Until(x => x.FindElements(By.TagName("button")).FirstOrDefault(y => y.Text == "Sign In"));
            var username = driver.FindElementByPartialLinkText("email");
            username.SendKeys(UserName);
            var password = driver.FindElementByPartialLinkText("password");
            password.SendKeys(Password);
            var loginbutton = driver.FindElementByClassName("btn");
            loginbutton.Click();
            //assert
            wait.Until(x => x.FindElements(By.TagName("h4"))).FirstOrDefault(y => y.Text == UserName);
            string pathFavorites = $"{URL}/favorites";
            Assert.AreEqual(driver.Url, pathFavorites);
        }
    }
}

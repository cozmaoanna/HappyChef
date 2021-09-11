using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyChef.Client.SeleniumTests
{
    public class RemoveFavorites : Login
    {
        [Test]
        public void RemoveFavoritesMethod()
        {
          
            var removeFavorites = driver.FindElementsByClassName("btn-warning").FirstOrDefault(x => x.Text == "Remove");
            if (removeFavorites == null)
            {
                Search();
                AddToFavs();
            }
            else
            {
                wait.Until(x => x.FindElements(By.ClassName("FindElementsByClassName")).FirstOrDefault(y => y.Text == "Remove"));
                removeFavorites.Click();
                ToastMessageConfirm("Recipe Removed from favs");
            }

        }
    }
}

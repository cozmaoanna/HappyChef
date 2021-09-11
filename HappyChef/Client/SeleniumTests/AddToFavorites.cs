using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HappyChef.Client.SeleniumTests
{
    public class AddToFavorites : Login
    {
         
        [Test]

        public void AddToFavoritesMethod()
        {
        LoginMethod();
        Search();
        AddToFavs();
        Logout();

        }
    }
}
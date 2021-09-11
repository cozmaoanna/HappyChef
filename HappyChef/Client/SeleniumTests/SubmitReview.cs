using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyChef.Client.SeleniumTests
{
    public class SubmitReview : Login
    {
        public void SubmitReviewMethod()
        {
            LoginMethod();
            Search();
            string pathFavorites = $"{URL}/favorites";
            Assert.AreEqual(driver.Url, pathFavorites);

            //  class="btn btn-sm btn-primary" Reviews
            wait.Until(x => x.FindElements(By.ClassName("btn-primary")).FirstOrDefault(x => x.Text == "Reviews"));
            var reviewButton = driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text == "Reviews");
            reviewButton.Click();

            //  class="btn btn-sm btn-primary"  Create Review
            var createReviewButton = driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text == "Create Review");
            createReviewButton.Click();

            // oi oi-star unselectedstar
            var reviewStar = driver.FindElementByClassName("oi-star");
            reviewStar.Click();

            // <textarea rows= "10" cols= "40" class="valid"></textarea>
            var writeReview = driver.FindElementByClassName("valid");
            writeReview.SendKeys("Chocolate chicken is amazing");

            //<button class="btn btn-sm btn-primary" type="submit"> Submit Review</button>
            var submitReviewButton = driver.FindElementsByClassName("btn-primary").FirstOrDefault(x => x.Text == "Submit Review");
            submitReviewButton.Click();

            ToastMessageConfirm("Submitted review");
            Logout();
        }
    }
}

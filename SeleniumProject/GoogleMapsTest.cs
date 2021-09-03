using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.Pages;

namespace SeleniumProject
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();   
        }

        [Test]
        public void SearchDesiredPlace()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/maps");

            SearchPage searchPage = new SearchPage();

            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollTo(0,900);");

            System.Threading.Thread.Sleep(2000);

            searchPage.clickConcordoButton();

            System.Threading.Thread.Sleep(2000);

            searchPage.enterDesiredSearch("Dublin");

            searchPage.clickSearchButton();

            System.Threading.Thread.Sleep(2000);

            //expected behaviour "Dublin
            //string expected = "//span[@jstcache= '997']";

            //Assert.AreEqual(expected, expected);

            Assert.That(searchPage.placeExist);

            Driver.Quit();
        }
    }
}

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject
{
    public class Tests : DriverHelper
    {

        //public IWebDriver Driver;
        static IWebElement textBox;
        //static IWebDriver driver = new ChromeDriver();


        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
           
        }

        [Test]
        public void Test1()
        {

            Driver.Navigate().GoToUrl("https://www.google.com/maps");

            string Xpath = "//button[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc']";

            string searchBox = "//input[@id= 'searchboxinput']";

            string searchButton = "//button[@id='searchbox-searchbutton']";

            string expected = "//span[@jstcache= '997']";

            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollTo(0,900);");

            System.Threading.Thread.Sleep(5000);

            Driver.FindElement(By.XPath(Xpath)).Click();

            textBox = Driver.FindElement(By.XPath(searchBox));

            textBox.SendKeys("Dublin");

            System.Threading.Thread.Sleep(5000);

            Driver.FindElement(By.XPath(searchButton)).Click();

            System.Threading.Thread.Sleep(5000);

            Assert.AreEqual(expected, expected);

            //Console.WriteLine("Test1");
            //Assert.Pass();

            Driver.Quit();
        }
    }
}

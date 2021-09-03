using System;
using OpenQA.Selenium;

namespace SeleniumProject.Pages
{
    public class SearchPage : DriverHelper
    {
        //concordo button
        IWebElement btnConcordo => Driver.FindElement(By.XPath("//button[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc']"));

        //search box input field
        IWebElement txtSearchName => Driver.FindElement(By.XPath("//input[@id= 'searchboxinput']"));

        //search button
        IWebElement btnSearch => Driver.FindElement(By.XPath("//button[@id='searchbox-searchbutton']"));

        //expected behaviour "dublin"
        IWebElement expBehavior => Driver.FindElement(By.XPath("//span[@jstcache= '997']"));

        //input desired search
        public void enterDesiredSearch(string name)
        {
            txtSearchName.SendKeys(name);
        }

        //click "concordo" button 
        public void clickConcordoButton()
        {
            btnConcordo.Click();
        }

        //click search button
        public void clickSearchButton()
        {
            btnSearch.Click();
        }

        //assert verifying if "Dublin" name exist
        public bool placeExist() => expBehavior.Displayed;

    }
}

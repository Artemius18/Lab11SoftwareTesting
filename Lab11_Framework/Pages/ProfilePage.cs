using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab11.Log.Log;
using static System.Net.WebRequestMethods;

namespace Lab11.Pages
{
    internal class ProfilePage : DriverInfo.DriverInfo
    {
        public ProfilePage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string _url_page = "https://open.spotify.com/user/31daidew2je6jqp6fmf5am6473nu";

        private readonly By Btn_Menu = By.XPath("/html/body/div[4]/div/div[2]/div[3]/div[1]/div[2]/div[2]/div/div/div[2]/main/section/div/div[1]/div[5]/span[2]/button");

        private readonly By inputName = By.XPath("/html/body/div[25]/div/div/div/form/div[2]/input");

        //private readonly By Input_Name = By.CssSelector("#user-edit-name");

        private readonly By Btn_SaveName = By.XPath("/html/body/div[25]/div/div/div/form/div[3]/button");
        

        public ProfilePage OpenProfilePage()
        {
            Info("[ProfilePage] OpenFavouritePage.");
            Driver.Navigate().GoToUrl(_url_page);
            Thread.Sleep(10000);
            return this;
        }

        public ProfilePage ClickOpenMenu()
        {
            Info("[ProfilePage] ClickOpenMenu.");
            Driver.FindElement(Btn_Menu).Click();
            Thread.Sleep(5000);
            return this;
        }

        //public ProfilePage ClickChangeName()
        //{
        //    Info("[ProfilePage] ClickChangeName.");
        //    Driver.FindElement(Btn_changeName).Click();
        //    Thread.Sleep(5000);
        //    return this;
        //}
        public ProfilePage InputNewName()
        {
            Info("[ProfilePage] InputNewName.");
            for (int i = 0; i < 15; i++)
                Driver.FindElement(inputName).Clear();

            Driver.FindElement(inputName).SendKeys("changedName");
            Thread.Sleep(5000);
            return this;
        }
        public ProfilePage ClickSaveName()
        {
            Info("[ProfilePage] ClickSaveName.");
            Driver.FindElement(Btn_SaveName).Click();
            Thread.Sleep(5000);
            return this;
        }
    }
}

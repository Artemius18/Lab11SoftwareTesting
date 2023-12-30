using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V118.Network;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab11.Log.Log;
using static System.Net.WebRequestMethods;

namespace Lab11.Pages
{
    internal class OptionsPage : DriverInfo.DriverInfo
    {
        public OptionsPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string _ulr_page = "https://open.spotify.com/preferences";
        private readonly By Btn_language_menu= By.CssSelector("#desktop\\.settings\\.selectLanguage");
        private readonly By Btn_SaveLanguage = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.jEMA2gVoLgPQqAFrPhFw > div.main-view-container > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-scrollbar-vertical-hidden > div.os-padding > div > div > div.main-view-container__scroll-node-child > main > div.LOsH9AUZc2uFRlhqtpRT > div:nth-child(2) > div > div:nth-child(3) > button");

        private readonly By Block_name = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.jEMA2gVoLgPQqAFrPhFw > div.main-view-container > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > main > div.LOsH9AUZc2uFRlhqtpRT > div:nth-child(2) > h2");


        public OptionsPage OpenOptionsPagee()
        {
            Info("[OptionsPage] OpenOptionsPagee.");
            Driver.Navigate().GoToUrl(_ulr_page);
            Thread.Sleep(10000);
            return this;
        }

        public OptionsPage Click_LanguageMenu()
        {
            Info("[OptionsPage] Click_LanguageMenu.");
            SelectElement select = new SelectElement(Driver.FindElement(Btn_language_menu));
            select.SelectByValue("en");
            Thread.Sleep(5000);
            return this;
        }
        public OptionsPage Click_SaveChange()
        {
            Info("[OptionsPage] Click_SaveChange.");
            Driver.FindElement(Btn_SaveLanguage).Click();
            Thread.Sleep(5000);
            return this;
        }

        public OptionsPage CheckChanges()
        {
            Info("[OptionsPage] Click_SaveChange.");
            /*
            if (Driver.FindElement(Block_name).Displayed)
                Assert.Pass();
            else
                Assert.Fail();
            */
            Thread.Sleep(5000);
            return this;
        }
    }
}

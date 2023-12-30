using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V118.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab11.Log.Log;
using static System.Net.WebRequestMethods;


namespace Lab11.Pages
{
    internal class SearchPage : DriverInfo.DriverInfo
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
        }
        private readonly string _url_page = "https://open.spotify.com/search";

        private readonly By Input_Search = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.jEMA2gVoLgPQqAFrPhFw > header > div.rovbQsmAS_mwvpKHaVhQ > div > div > form > input");
        private readonly By Block_searchResult = By.CssSelector("#searchPage > div > div > section.iGyMsGo7FgYQQThBj2y9.QyANtc_r7ff_tqrf5Bvc.Shelf > div.iKwGKEfAfW7Rkx2_Ba4E.Z4InHgCs2uhk0MU93y_a > div > div > div > div._gB1lxCfXeR8_Wze5Cx9");

        public SearchPage OpenSearchPage()
        {
            Info("[SearchPage] OpenSearchPage.");
            Driver.Navigate().GoToUrl(_url_page);
            Thread.Sleep(10000);
            return this;
        }

        public SearchPage InputSearch()
        {
            Info("[SearchPage] InputUserName.");
            Driver.FindElement(Input_Search).SendKeys("ПОП");
            Thread.Sleep(5000);
            return this;
        }

        public SearchPage CheckSearch()
        {
            Info("[SearchPage] CheckSearch.");
            if (Driver.FindElement(Block_searchResult).Displayed)
                Assert.Pass();
            else
                Assert.Fail();

            Thread.Sleep(5000);
            return this;
        }
    }
}

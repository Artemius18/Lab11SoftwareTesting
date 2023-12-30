using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab11.Log.Log;


namespace Lab11.Pages
{
    internal class FavouritePage : DriverInfo.DriverInfo
    {
        public FavouritePage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string _url_facebook = "https://www.facebook.com/Spotify";
        private readonly string _ulr_page = "https://open.spotify.com/collection/tracks";
        private readonly By favouritebutton = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.jEMA2gVoLgPQqAFrPhFw > div.main-view-container > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > main > section > div:nth-child(4) > div > div.JUa6JJNj7R_Y3i4P8YUX > div:nth-child(2) > div > div > div.HcMOFLaukKJdK5LfdHh0 > button.Button-sc-1dqy6lx-0.yUUNA.tGKwoPuvNBNK3TzCS5OH");
        private readonly By Btn_facebook = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.jEMA2gVoLgPQqAFrPhFw > div.main-view-container > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > main > div > nav > div.Footer__TopSection-sc-xwm5vq-1.cDoymc > div.SocialLinks__SocialContainer-sc-kqbr2e-0.lebRvI > div:nth-child(3) > a");



        public FavouritePage OpenFavouritePage()
        {
            Info("[FavouritePage] FavouritePage.");
            Driver.Navigate().GoToUrl(_ulr_page);
            Thread.Sleep(10000);
            return this;
        }

        public FavouritePage DeleteSong()
        {
            Info("[FavouritePage] InputUserName.");
            Driver.FindElement(favouritebutton).Click();
            Thread.Sleep(5000);
            return this;
        }
        public FavouritePage Click_OpenFacebook()
        {
            Info("[FavouritePage] Click_OpenFacebook.");
            Driver.FindElement(Btn_facebook).Click();
            Thread.Sleep(5000);
            return this;
        }

        public FavouritePage CheckOpened()
        {
            Info("[FavouritePage] CheckOpened.");
            Thread.Sleep(5000);
            foreach (string handle in Driver.WindowHandles)
            {
                Driver.SwitchTo().Window(handle);
                string currentUrl = Driver.Url;

                if (currentUrl == _url_facebook)
                {
                    Info("[MainPage] CheckOpened - OK.");
                    Assert.Pass();
                    return this;
                }
                else
                {
                    Info("[MainPage] CheckOpened - Error.");
                    Assert.Fail();

                    return this;
                }
            }
            return this;
        }
    }
}

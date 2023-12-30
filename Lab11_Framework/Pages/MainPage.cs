
using Ocelot.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V118.Network;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Lab11.Log.Log;
using static System.Net.WebRequestMethods;


namespace Lab11.Pages
{
    public class MainPage : DriverInfo.DriverInfo
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string _url_mainpage = "https://open.spotify.com/";


        private readonly By addPlayListButton = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.BdcvqBAid96FaHAmPYw_ > nav > div.EZFyDnuQnx5hw78phLqP.hjb8tUL3rpUa0ez4ZtAj > div.PpUTJL2NIYDUnmfzVIbE > div:nth-child(1) > header > div > span > button");
        private readonly By createPlayListButton = By.CssSelector("#context-menu > ul > li:nth-child(1) > button");
        private readonly By checkPlayListNameLocator = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.jEMA2gVoLgPQqAFrPhFw > div.main-view-container > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > main > div.GlueDropTarget.GlueDropTarget--tracks.GlueDropTarget--local-tracks.GlueDropTarget--episodes.GlueDropTarget--albums > section > div.contentSpacing.NXiYChVp4Oydfxd7rT5r.RMDSGDMFrx8eXHpFphqG > div.RP2rRchy4i8TIp1CTmb7 > span.rEN7ncpaUeSGL9z0NGQR > button > span > h1");

        //Добавить песню в плейлист
        private readonly By inputSongName = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.jEMA2gVoLgPQqAFrPhFw > div.main-view-container > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > main > div.GlueDropTarget.GlueDropTarget--tracks.GlueDropTarget--local-tracks.GlueDropTarget--episodes.GlueDropTarget--albums > section > div.rezqw3Q4OEPB1m4rmwfw > div.contentSpacing > section > div > div > input");
        private readonly By songLocator = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.jEMA2gVoLgPQqAFrPhFw > div.main-view-container > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > main > div.GlueDropTarget.GlueDropTarget--tracks.GlueDropTarget--local-tracks.GlueDropTarget--episodes.GlueDropTarget--albums > section > div.rezqw3Q4OEPB1m4rmwfw > div.contentSpacing > div > div:nth-child(1) > div > div:nth-child(2) > div:nth-child(1) > div > div.HcMOFLaukKJdK5LfdHh0 > button");

        //Добавить в избранное
        private readonly By addToFavouriteLocator = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.jEMA2gVoLgPQqAFrPhFw > div.main-view-container > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > main > div.GlueDropTarget.GlueDropTarget--tracks.GlueDropTarget--local-tracks.GlueDropTarget--episodes.GlueDropTarget--albums > section > div.rezqw3Q4OEPB1m4rmwfw > div.contentSpacing > div.ShMHCGsT93epRGdxJp2w.Ss6hr6HYpN4wjHJ9GHmi > div.JUa6JJNj7R_Y3i4P8YUX > div:nth-child(2) > div > div > div.HcMOFLaukKJdK5LfdHh0 > button.Button-sc-1dqy6lx-0.lhGroS.tGKwoPuvNBNK3TzCS5OH");


        //Удалить плейлист
        private readonly By deletePlayListLocator = By.CssSelector("#main > div > div.ZQftYELq0aOsg6tPbVbV > div.jEMA2gVoLgPQqAFrPhFw > div.main-view-container > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > main > div.GlueDropTarget.GlueDropTarget--tracks.GlueDropTarget--local-tracks.GlueDropTarget--episodes.GlueDropTarget--albums > section > div.rezqw3Q4OEPB1m4rmwfw > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.os-host-scrollbar-vertical-hidden.os-host-transition > div.os-padding > div > div > div > div > button > span > svg");
        private readonly By deletePlayListButton = By.CssSelector("#context-menu > ul > li:nth-child(3) > button");
        private readonly By deletePlayListApprove = By.CssSelector("body > div:nth-child(39) > div > div > div > div > button.Button-sc-qlcn5g-0.keyrGu");

        public MainPage OpenMainPage()
        {
            Info("[MainPage] OpenMainPage.");
            Driver.Navigate().GoToUrl(_url_mainpage);
            Thread.Sleep(10000);
            return this;
        }

        public MainPage addPlayList()
        {
            Info("[MainPage] InputUserName.");
            Driver.FindElement(addPlayListButton).Click();
            Thread.Sleep(5000);
            return this;
        }
        public MainPage CreatePlayList()
        {
            Info("[MainPage] createPlayListButton.");
            Driver.FindElement(createPlayListButton).Click();
            Thread.Sleep(5000);
            return this;
        }

        public MainPage CheckPage()
        {
            Info("[MainPage] CheckPage.");
            if (Driver.FindElement(checkPlayListNameLocator).Displayed)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
            Thread.Sleep(5000);
            return this;
        }




        public MainPage FindSong()
        {
            Info("[MainPage] FindSong.");
            Driver.FindElement(inputSongName).SendKeys("Хозяин леса");
            Thread.Sleep(5000);
            return this;
        }

        public MainPage AddSong()
        {
            Info("[MainPage] createPlayListButton.");
            Driver.FindElement(songLocator).Click();
            Thread.Sleep(5000);
            return this;
        }
        public MainPage AddToFavourite()
        {
            Info("[MainPage] addToFavourite.");
            Driver.FindElement(addToFavouriteLocator).Click();
            Thread.Sleep(5000);
            return this;
        }




        public MainPage DeletePlayList_1()
        {
            Info("[MainPage] DeletePlayList_1.");
            Driver.FindElement(deletePlayListLocator).Click();
            Thread.Sleep(5000);
            return this;
        }

        public MainPage DeletePlayList_2()
        {
            Info("[MainPage] DeletePlayList_2.");
            Driver.FindElement(deletePlayListButton).Click();
            Thread.Sleep(5000);
            return this;
        }
        public MainPage DeletePlayList_3()
        {
            Info("[MainPage] DeletePlayList_3.");
            //Driver.FindElement(deletePlayListApprove).Click();

            // Создаем экземпляр класса Actions
            Actions actions = new Actions(Driver);
            // Отправляем клавишу Enter к элементу
            actions.SendKeys(Keys.Enter).Perform();
            Thread.Sleep(5000);
            return this;
        }

    }
    
}

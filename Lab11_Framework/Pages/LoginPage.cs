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
using static Lab11.Log.Log;
using static System.Net.WebRequestMethods;

namespace Lab11.Pages
{
    public class LoginPage : DriverInfo.DriverInfo
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string username = "resatora1@rambler.ru";
        private readonly string password = "Asdasdqwe123#";

        private readonly string _url_mainpage = "https://open.spotify.com/";
        private readonly string _url_login = "https://accounts.spotify.com/ru/login?continue=https%3A%2F%2Fopen.spotify.com%2F";

        private readonly By usernameLocator = By.CssSelector("#login-username");
        private readonly By passwordLocator = By.CssSelector("#login-password");
        private readonly By loginButtonLocator = By.CssSelector("#login-button > span.ButtonInner-sc-14ud5tc-0.cJdEzG.encore-bright-accent-set");

        public LoginPage OpenLoginPage()
        {
            Info("[LoginPage] Login page opened.");
            Driver.Navigate().GoToUrl(_url_login);
            Thread.Sleep(10000);
            return this;
        }

        public LoginPage InputUserName()
        {
            Info("[LoginPage] InputUserName.");
            Driver.FindElement(usernameLocator).SendKeys(username);
            Thread.Sleep(5000);
            return this;
        }
        public LoginPage InputUserPassword()
        {
            Info("[LoginPage] InputUserPassword.");
            Driver.FindElement(passwordLocator).SendKeys(password);
            Thread.Sleep(5000);
            return this;
        }
        public LoginPage LoginButton()
        {
            Info("[LoginPage] LoginButton.");
            Driver.FindElement(loginButtonLocator).Click();
            Thread.Sleep(5000);
            return this;
        }
    }
}

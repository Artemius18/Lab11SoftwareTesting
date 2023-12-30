using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab11.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static Lab11.DriverInstance.DriverInstance;


namespace Lab11.Tests
{
    //Авторизация
    [TestClass]
    public class Test_1
    {

        private LoginPage _loginPage;

        [SetUp]
        public void Setup()
        {
            _loginPage = new LoginPage(Driver);
        }

        [Test]
        public void Test1()
        {
            _loginPage.OpenLoginPage();
            _loginPage.InputUserName();
            _loginPage.InputUserPassword();
            _loginPage.LoginButton();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}

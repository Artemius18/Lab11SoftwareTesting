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
    //Сменить имя профиля
    [TestClass]
    public class Test_7
    {

        private ProfilePage _ProfilePage;

        [SetUp]
        public void Setup()
        {
            _ProfilePage = new ProfilePage(Driver);
        }

        [Test]
        public void Test7()
        {
            _ProfilePage.OpenProfilePage();
            //_ProfilePage.ClickOpenMenu();
            //_ProfilePage.InputNewName();
            //_ProfilePage.ClickSaveName();

            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}

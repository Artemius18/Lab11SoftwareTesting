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
    //Создать плейлист
    [TestClass]
    public class Test_2
    {

        private MainPage _mainPage;

        [SetUp]
        public void Setup()
        {
            _mainPage = new MainPage(Driver);
        }

        [Test]
        public void Test2()
        {
            _mainPage.OpenMainPage();
            //_mainPage.addPlayList();
            //_mainPage.CreatePlayList();
            //_mainPage.CheckPage();
            Thread.Sleep(5000);
        }

        [TearDown]
            public void TearDown()
            {
        }

    }
}

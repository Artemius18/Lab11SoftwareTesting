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
    //Удалить плейлист
    [TestClass]
    public class Test_5
    {

        private MainPage _mainPage;

        [SetUp]
        public void Setup()
        {
            _mainPage = new MainPage(Driver);
        }

        [Test]
        public void Test5()
        {
            _mainPage.DeletePlayList_1();
            _mainPage.DeletePlayList_2();
            _mainPage.DeletePlayList_3();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}

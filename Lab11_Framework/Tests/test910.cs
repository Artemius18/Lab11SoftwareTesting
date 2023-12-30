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
    //Тест перехода в соц сеть
    [TestClass]
    public class test910
    {

        private FavouritePage _FavouritePage;

        [SetUp]
        public void Setup()
        {
            _FavouritePage = new FavouritePage(Driver);
        }

        [Test]
        public void Test10()
        {
            _FavouritePage.OpenFavouritePage();
            _FavouritePage.Click_OpenFacebook();
            _FavouritePage.CheckOpened();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}

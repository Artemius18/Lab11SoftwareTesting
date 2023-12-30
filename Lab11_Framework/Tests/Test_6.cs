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
    //Удалить песню из избранного
    [TestClass]
    public class Test_6
    {

        private FavouritePage _FavouritePage;

        [SetUp]
        public void Setup()
        {
            _FavouritePage = new FavouritePage(Driver);
        }

        [Test]
        public void Test6()
        {
            _FavouritePage.OpenFavouritePage();
            //_FavouritePage.DeleteSong();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}

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
    //Тестирование поисковика
    [TestClass]
    public class Test_9
    {

        private SearchPage _SearchPage;

        [SetUp]
        public void Setup()
        {
            _SearchPage = new SearchPage(Driver);
        }

        [Test]
        public void Test9()
        {
            //_SearchPage.OpenSearchPage();
            //_SearchPage.InputSearch();
            //_SearchPage.CheckSearch();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}

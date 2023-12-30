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
    //Сменить язык
    [TestClass]
    public class Test_8
    {

        private OptionsPage _OptionsPage;

        [SetUp]
        public void Setup()
        {
            _OptionsPage = new OptionsPage(Driver);
        }

        [Test]
        public void Test8()
        {
            //_OptionsPage.OpenOptionsPagee();
            //_OptionsPage.Click_LanguageMenu();
            //_OptionsPage.Click_SaveChange();
            //_OptionsPage.CheckChanges();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
        }

    }
}

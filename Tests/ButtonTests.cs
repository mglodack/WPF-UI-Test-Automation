using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Tests
{
    [TestClass]
    public class ButtonTests : WpfAppSession
    {
        [TestMethod]
        public void ClickButton_Test()
        {
            var button1 = session.FindElementByAccessibilityId("button1");

            Assert.AreEqual("Click me", button1.GetAttribute("Name"));

            button1.Click();

            Assert.AreEqual("clicked", button1.GetAttribute("Name"));
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Tests
{
    [TestClass]
    public class TextBlockTests : WpfAppSession
    {
        [TestMethod]
        public void TextBlockText_InitialState()
        {
            var tabBar = session.FindElementByClassName(nameof(TabControl));
            var tabItems = tabBar.FindElementsByClassName(nameof(TabItem));

            // textBlock examples tab
            tabItems[1].Click();

            var textBlock = session.FindElementByAccessibilityId("textBlock");

            Assert.AreEqual("Test", textBlock.Text);
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

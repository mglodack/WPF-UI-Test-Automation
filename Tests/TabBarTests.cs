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
    public class TabBarTests : WpfAppSession
    {
        [TestMethod]
        public void ClickTabBar_Tests()
        {
            var tabBar = session.FindElementByClassName(nameof(TabControl));
            var tabItems = tabBar.FindElementsByClassName(nameof(TabItem));

            Assert.IsTrue(tabItems.Any());

            var firstItem = tabItems.First();
            Assert.IsTrue(firstItem.Selected);
        }

        [TestMethod]
        public void ClickTabBar_ClickSecondTab()
        {
            var tabBar = session.FindElementByClassName(nameof(TabControl));
            var tabItems = tabBar.FindElementsByClassName(nameof(TabItem));

            Assert.IsTrue(tabItems.Any());

            var firstItem = tabItems.First();
            Assert.IsTrue(firstItem.Selected);

            Assert.IsTrue(tabItems.Count > 1);

            var secondItem = tabItems[1];
            secondItem.Click();

            Assert.IsFalse(firstItem.Selected);
            Assert.IsTrue(secondItem.Selected);
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

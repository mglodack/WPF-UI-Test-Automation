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
    public class ListBoxTests : WpfAppSession
    {
        [TestMethod]
        public void Test()
        {
            var tabBar = session.FindElementByClassName(nameof(TabControl));
            var tabItems = tabBar.FindElementsByClassName(nameof(TabItem));

            // ListBox examples tab
            tabItems[3].Click();

            var listBox = session.FindElementByClassName(nameof(ListBox));
            Assert.IsNotNull(listBox);
            listBox.Click();

            var comboBoxItems = listBox.FindElementsByClassName(nameof(ListBoxItem));

            Assert.IsTrue(comboBoxItems.Any());
            comboBoxItems.Last().Click();
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

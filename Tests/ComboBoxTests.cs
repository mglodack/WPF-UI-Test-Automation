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
    public class ComboBoxTests : WpfAppSession
    {
        [TestMethod]
        public void Test()
        {
            var tabBar = session.FindElementByClassName(nameof(TabControl));
            var tabItems = tabBar.FindElementsByClassName(nameof(TabItem));

            // ComboBox examples tab
            tabItems[2].Click();

            var comboBox = session.FindElementByClassName(nameof(ComboBox));
            comboBox.Click();

            var comboBoxItems = comboBox.FindElementsByClassName(nameof(ListBoxItem));

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

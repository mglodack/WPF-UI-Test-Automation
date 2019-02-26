using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public abstract class WpfAppSession
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        protected static WindowsDriver<WindowsElement> session;

        public static void Setup(TestContext context)
        {
            var currentPath = Directory.GetCurrentDirectory();
            var dirPath = new DirectoryInfo(currentPath).Parent.Parent.Parent;
            var appPath = Path.Combine(
                dirPath.FullName,
                "WpfTestAutomation",
                "bin",
                "Debug",
                "WpfTestAutomation.exe");

            if (session == null)
            {
                DesiredCapabilities appCapabilities = new DesiredCapabilities();
                appCapabilities.SetCapability("app", appPath);
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
                Assert.IsNotNull(session);
                Assert.IsNotNull(session.SessionId);
            }
        }

        public static void TearDown()
        {
            // Close the application and delete the session
            if (session != null)
            {
                session.Close();

                session.Quit();
                session = null;
            }
        }
    }
}

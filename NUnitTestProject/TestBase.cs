using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace NUnitTestProject
{
   public class TestBase
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(@"C:\chromedriver_win32");
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://localhost:44314/");
            driver.Manage().Window.Size = new System.Drawing.Size(1532, 819);
        }

        public void Login(Logindata logindata)
        {
            driver.FindElement(By.CssSelector(".active > .nav-link")).Click();
            driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector(".active > .nav-link")).Click();
            driver.FindElement(By.Id("Email")).SendKeys(logindata.Username);
            driver.FindElement(By.Id("Password")).SendKeys(logindata.Password   );
            driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
        }

        public void Add(GroupData groupData)
        {
            driver.FindElement(By.LinkText("Add")).Click();
            driver.FindElement(By.Name("name")).Click();
            driver.FindElement(By.Name("name")).SendKeys(groupData.name);
            driver.FindElement(By.Name("decs")).SendKeys(groupData.decsriprion);
            driver.FindElement(By.Name("AtributeName")).SendKeys(groupData.type);
            driver.FindElement(By.CssSelector("input:nth-child(16)")).Click();
        }

    }
}

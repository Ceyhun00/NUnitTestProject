using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
namespace NUnitTestProject
{
    [TestFixture]
    public class UnitTest1 : TestBase
    {
        
        //[Test]
        //public void authorizee()
        //{
        //    driver.Navigate().GoToUrl("https://localhost:44314/");
        //    driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
        //    driver.FindElement(By.CssSelector(".active > .nav-link")).Click();
        //    driver.FindElement(By.Id("Email")).SendKeys("admin@mail.ru");
        //    driver.FindElement(By.Id("Password")).SendKeys("123456");
        //    driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
        //}
        [Test]
        public void TheUnitLogin()
        {
            OpenHomePage();
            Login(new Logindata("admin@mail.ru","123456"));

        }
        [Test]
        public void TheUnitLoginAdd()
        {
            OpenHomePage();
            Login(new Logindata("admin@mail.ru", "123456"));
            Add(new GroupData("Jeyhun", "oaoa", "Agility"));
        }


    }
}

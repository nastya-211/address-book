// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class AddressbookTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new FirefoxDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void addressbook()
    {
        driver.Navigate().GoToUrl("http://localhost:8080/addressbook/");
        driver.Manage().Window.Size = new System.Drawing.Size(550, 695);
        driver.FindElement(By.Name("user")).SendKeys("admin");
        driver.FindElement(By.Id("LoginForm")).Click();
        driver.FindElement(By.Name("pass")).Click();
        driver.FindElement(By.Name("pass")).SendKeys("secret");
        driver.FindElement(By.CssSelector("input:nth-child(7)")).Click();
        driver.FindElement(By.LinkText("groups")).Click();
        driver.FindElement(By.Name("new")).Click();
        driver.FindElement(By.Name("group_name")).Click();
        driver.FindElement(By.Name("group_name")).SendKeys("uno");
        driver.FindElement(By.Name("group_header")).Click();
        driver.FindElement(By.Name("group_header")).SendKeys("dos");
        driver.FindElement(By.Name("group_footer")).Click();
        driver.FindElement(By.Name("group_footer")).SendKeys("tres");
        driver.FindElement(By.Name("submit")).Click();
        driver.FindElement(By.LinkText("group page")).Click();
        driver.FindElement(By.LinkText("Logout")).Click();
    }
}

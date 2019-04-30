using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 

namespace Test_calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.calculator.net");
            driver.FindElement(By.XPath("//*[@id='sciout']/tbody/tr[2]/td[2]/div/div[2]/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='sciout']/tbody/tr[2]/td[2]/div/div[1]/span[4]")).Click();
            driver.FindElement(By.XPath("//*[@id='sciout']/tbody/tr[2]/td[2]/div/div[2]/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='sciout']/tbody/tr[2]/td[2]/div/div[5]/span[4]")).Click();
            IWebElement resultText = driver.FindElement(By.XPath(".//*[@id='sciOutPut']"));
            double actual = double.Parse(resultText.Text);
            double expected = 10.0;
            Assert.AreEqual(actual, expected, 0.00001, "Incorrect results when adding five and five");
            return;
        }
    }
}


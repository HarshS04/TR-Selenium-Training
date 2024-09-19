using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class SalesForceAssignment
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");

            //Select dropdown job title
            SelectElement selectjobtitle = new SelectElement(driver.FindElement(By.Id("UserTitle-byE8")));
            selectjobtitle.SelectByText("IT_Manager_AP");

            //Select Employees Count
            SelectElement selectemplyeecount = new SelectElement(driver.FindElement(By.Id("CompanyEmployees-gj6z")));
            selectemplyeecount.SelectByText("350");

            //Select country
            SelectElement selectcountry = new SelectElement(driver.FindElement(By.Id("CompanyCountry-h0nf")));
            selectcountry.SelectByText("GB");

            IWebElement checkbox = driver.FindElement(By.Name("SubscriptionAgreement"));
            if (!checkbox.Selected)
            {
                checkbox.Click();
            }

            driver.FindElement(By.Name("start my free trial")).Click();
        }
    }
}

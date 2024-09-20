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
        static void Main3(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");

            //Select dropdown job title
            SelectElement selectjobtitle = new SelectElement(driver.FindElement(By.XPath("//select[@name='UserTitle']")));
            selectjobtitle.SelectByText("IT Manager");

            //Select country
            SelectElement selectcountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectcountry.SelectByValue("GB");

            //Select Employees Count
            SelectElement selectemplyeecount = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectemplyeecount.SelectByValue("350");

            IWebElement checkbox = driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]"));
            if (!checkbox.Selected)
            {
                checkbox.Click();
            }

            driver.FindElement(By.Name("start my free trial")).Click();

            //get the error and display
            string actualError = driver.FindElement(By.XPath("//span[contains(text(),'valid phone')]")).Text;
            Console.WriteLine(actualError);

        }
    }
}

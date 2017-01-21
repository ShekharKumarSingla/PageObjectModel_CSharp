using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.PageObjects;

namespace ConsoleApplication1
{
 
    class FirstTestCase
    {
        //static IWebDriver driver = new ChromeDriver();

        public static void Main(string[] args)
        {
            
        }

        [SetUp]
        public static void initialize()
        {
            CommonMethod.driver = new ChromeDriver();
            Console.WriteLine("Opening browser");
            CommonMethod.driver.Manage().Window.Maximize();
        }

        [Test] // simple testcases
        public static void executeTest()
        {
            CommonMethod.driver.Url = "http://www.google.com";
            Console.WriteLine("Test Started");
            IWebElement search = CommonMethod.driver.FindElement(By.Id("lst-ib"));
            search.SendKeys("shekhar");
            search.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(3).TotalMilliseconds); // to see the result
            Console.WriteLine("Test Ended");
        }

        [Test] // page object model test case
        public static void anotherTest()
        {
            Console.WriteLine("second test");
            CommonMethod.driver.Url = "http://executeautomation.com/demosite/index.html";
            // selecting title
            SeleniumSetMethods.selectDropDown( "TitleId", PropertyType.Id, "Mr."); //custom methods
            // Entering name
            SeleniumSetMethods.EnterText("FirstName", "Shekhar", PropertyType.Name);
            // selecting checkbox
            SeleniumSetMethods.ClickElement("Hindi", PropertyType.Name);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(3).TotalMilliseconds); // to see the result
        }

        [Test] // using find testcase
        public static void pftestcases()
        {

            Console.WriteLine("third test");
            CommonMethod.driver.Url = "http://executeautomation.com/demosite/index.html";
            PageObjects EA = new PageObjects();
            EA.chkHindi.Click();
            EA.txtFirstName.SendKeys("Shekhar Kumar");
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(3).TotalMilliseconds); // to see the result
        }

        [TearDown]
        public static void cleanup()
        {
            CommonMethod.driver.Close();
            Console.WriteLine("Closing browser");
        }
    }
}

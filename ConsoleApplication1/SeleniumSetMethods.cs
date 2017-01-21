using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication1
{
    class SeleniumSetMethods
    {
        //Enter text method
        public static void EnterText( String elementXpath, String value, PropertyType elementtype)
        {
            switch (elementtype)
            {
                case PropertyType.Name:
                    CommonMethod.driver.FindElement(By.Name(elementXpath)).SendKeys(value);
                    break;

                case PropertyType.Id:
                    CommonMethod.driver.FindElement(By.Id(elementXpath)).SendKeys(value);
                    break;
                default:
                    Console.WriteLine("invalid element type");
                    break;
            }
        }

        //Click method
        public static void ClickElement(String elementXpath, PropertyType elementtype)
        {
            switch (elementtype)
            {
                case PropertyType.Name:
                    CommonMethod.driver.FindElement(By.Name(elementXpath)).Click();
                    break;

                case PropertyType.Id:
                    CommonMethod.driver.FindElement(By.Id(elementXpath)).Click();
                    break;
                default:
                    Console.WriteLine("invalid element type");
                    break;
            }
        }

        //select dropdown

        public static void selectDropDown(String elementXpath, PropertyType elementtype, String value)
        {
            switch (elementtype)
            {
                case PropertyType.Name:
                    new SelectElement(CommonMethod.driver.FindElement(By.Name(elementXpath))).SelectByText(value);
                    break;

                case PropertyType.Id:
                    new SelectElement(CommonMethod.driver.FindElement(By.Id(elementXpath))).SelectByText(value);
                    break;
                default:
                    Console.WriteLine("invalid element type");
                    break;
            }
        }


    }
}

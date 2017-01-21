using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PageObjects
    {
        public PageObjects()
        {
            PageFactory.InitElements(CommonMethod.driver, this);
        }

        [FindsBy(How=How.Id, Using ="TitleId")]
        public IWebElement ddlTitle { get; set; }


        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }


        [FindsBy(How = How.Name, Using = "Hindi")]
        public IWebElement chkHindi { get; set; }
    }
}

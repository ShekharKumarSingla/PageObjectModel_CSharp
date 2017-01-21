using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        ClassName,
        CssName
    }
    class CommonMethod
    {
        public static IWebDriver driver
        {

            get;
            set;
        }
    }
}

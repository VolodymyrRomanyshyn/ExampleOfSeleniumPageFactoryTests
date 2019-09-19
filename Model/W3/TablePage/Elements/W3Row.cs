using Framework.Driver;
using Framework.PageDecorators.Attributes;
using Framework.Pages;
using Framework.WebElements;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Model.W3.Elements
{
    public class W3Row : SubPage
    {
        [XPath("*")] public IList<BaseElement> Cells;

        public W3Row(IWebElement Element, BaseDriver Driver, string Name) : base(Element, Driver, Name)
        {
        }

        public BaseElement this[int Cell] => Cells[Cell];
    }
}

using Framework.Driver;
using Framework.PageDecorators.Attributes;
using Framework.Pages;
using Framework.WebElements;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Model.W3.Elements
{
    /// <summary>
    /// The implementation of left side buttons 
    /// </summary>
    public class W3LetSideButtons : SubPage
    {
        [XPath("a")] private IList<Button> Buttons;

        public W3LetSideButtons(IWebElement Element, BaseDriver Driver, string Name) : base(Element, Driver, Name)
        {
        }

        public IButton Home => Buttons[0];
        public IButton Introduction => Buttons[1];
        // etc
        public IButton Tables => Buttons[16];
        // etc
    }
}

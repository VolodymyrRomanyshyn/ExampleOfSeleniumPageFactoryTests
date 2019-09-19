using Framework.Driver;
using Framework.PageDecorators.Attributes;
using Framework.Pages;
using Framework.WebElements;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace Model.W3.Elements
{
    /// <summary>
    /// The implementation of table with structure:
    /// tbody/
    ///     tr/
    ///         td
    ///         td
    ///         td
    ///     tr/
    ///         td
    ///         td
    ///         td
    ///  etc   
    /// </summary>

    public class W3Table : SubPage
    {
        [XPath("tbody/tr")] public IList<W3Row> Rows;

        public W3Table(IWebElement Element, BaseDriver Driver, string Name) : base(Element, Driver, Name)
        {
        }

        public IBaseElement FindCountryByCompany(string name) => Rows.FirstOrDefault(Row => Row[0].VisibleText.Equals(name))[2];

        public W3Row this[int Row] => Rows[Row];
    }
}

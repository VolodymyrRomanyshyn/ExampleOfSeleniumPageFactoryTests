using Framework.Driver;
using Framework.PageDecorators.Attributes;
using Framework.Pages;
using Model.W3.Elements;

namespace Model.W3
{
    public class W3TablePage : BasePage
    {
        [Id("customers")] public W3Table Table;

        public W3TablePage(BaseDriver baseDriver) : base(baseDriver)
        {
        }
    }
}

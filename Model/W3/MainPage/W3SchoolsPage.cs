using Framework.Driver;
using Framework.PageDecorators.Attributes;
using Framework.Pages;
using Model.W3.Elements;

namespace Model.W3
{
    /// <summary>
    /// the implementation of PageObject of Main page 
    /// </summary>
    public class W3SchoolsPage : BaseStartPage
    {
        [Id("leftmenuinnerinner")] public W3LetSideButtons LeftSideButtons;
        // etc
        // other elements of Page here

        public W3SchoolsPage(BaseDriver baseDriver, string link) : base(baseDriver, link)
        {
        }
    }
}

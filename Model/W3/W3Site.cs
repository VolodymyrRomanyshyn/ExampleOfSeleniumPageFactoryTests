using Framework.SiteDecorators.Attributes;
using Framework.Sites;

namespace Model.W3
{
    public class W3Site : BaseSite
    {
        public W3Site() : base(new BrowserSettings())
        {
        }

        [Link("https://www.w3schools.com/html/default.asp")]
        public W3SchoolsPage W3SchoolsPage;

        public W3TablePage W3TablePage;
    }
}

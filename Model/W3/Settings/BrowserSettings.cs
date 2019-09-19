using Framework.BrowserSettings;
using System;

namespace Model.W3
{
    public class BrowserSettings : ISettings
    {
        public TimeSpan TimeWait => TimeSpan.FromSeconds(20); // Waiting for elements, waiting for changing status if elements visible not visible etc.

        public TimeSpan ReportTimeWait => TimeSpan.FromMinutes(2); // the same but for report pages

        public string Browser => "chrome"; // Choosing type of browser chrome/firefox
    }
}

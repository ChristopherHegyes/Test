using OpenQA.Selenium.Chrome;

namespace Pages
{
    public class TestBase
    {
        private static ChromeDriver driver;

        public static ChromeDriver Driver
        {
            get { return driver; }
            set { driver = value; }
        }

    }
}

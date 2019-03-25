using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Pages
{
    public class Home : PageBase
    {
        [FindsBy(How = How.TagName, Using = "p")]
        protected IWebElement PTag { get; set; }

        [FindsBy(How = How.TagName, Using = "h1")]
        protected IWebElement H1Tag { get; set; }


        public Home()
        {
            PageFactory.InitElements(Driver, this);
        }

        public string GetTagText(string tag)
        {
            if (tag == "p")
                return PTag.Text;
            else
                return H1Tag.Text;
        }


    }
}

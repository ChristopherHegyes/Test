using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Pages
{
    public class Hello : PageBase
    {
        [FindsBy(How = How.Id, Using = "hello-text")]
        protected IWebElement HelloText { get; set; }

        public Hello()
        {
            PageFactory.InitElements(Driver, this);
        }

        public string GetHelloText()
        {
            return HelloText.Text;
        }
    }
}

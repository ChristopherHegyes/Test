using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pages
{
    abstract public class PageBase : TestBase
    {
        [FindsBy(How = How.Id, Using = "dh_logo")]
        protected IWebElement Logo { get; set; }

        [FindsBy(How = How.Id, Using = "home")]
        protected IWebElement HomeButton { get; set; }

        [FindsBy(How = How.Id, Using = "form")]
        protected IWebElement FormButton { get; set; }

        [FindsBy(How = How.Id, Using = "error")]
        protected IWebElement ErrorButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "active")]
        protected IWebElement ActiveButton { get; set; }

        [FindsBy(How = How.Id, Using = "site")]
        protected IWebElement UITestingButton { get; set; }

        


        public string GetTitle()
        {
            return Driver.Title;
        }

        public string GetLogoSRC()
        {
            return Logo.GetAttribute("src");
        }

        public string GetURL()
        {
            return Driver.Url;
        }

        public void ClickHome()
        {
            HomeButton.Click();
        }

        public void ClickForm()
        {
            FormButton.Click();
        }

        public void ClickError()
        {
            ErrorButton.Click();
        }

        public string GetActiveButton()
        {
            return ActiveButton.Text;
        }

        public void ClickUITesting()
        {
            UITestingButton.Click();
        }

    }
}

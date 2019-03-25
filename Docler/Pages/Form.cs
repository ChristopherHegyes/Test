using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pages
{
    public class Form : PageBase
    {
        [FindsBy(How = How.Id, Using = "hello-input")]
        protected IWebElement InputField { get; set; }

        [FindsBy(How = How.Id, Using = "hello-submit")]
        protected IWebElement SubmitButton { get; set; }

        public Form()
        {
            PageFactory.InitElements(Driver, this);
        }

        public bool IsInputFieldAvailable()
        {
            return InputField.Displayed;
        }

        public bool IsSubmitButtonAvailable()
        {
            return SubmitButton.Displayed;
        }

        public void EnterText(string text)
        {
            InputField.SendKeys(text);
        }

        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }



    }
}

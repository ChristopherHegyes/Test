using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pages;
using TechTalk.SpecFlow;

namespace Docler
{
    [Binding]
    public class WebsiteTestsSteps : TestBase
    {
        private PageBase actualPage = null;

        [Given(@"I have opened '(.*)'")]
        public void GivenIHaveOpened(string page)
        {
            Driver.Navigate().GoToUrl(page);
            if (page.Contains("form"))
                actualPage = new Form();
            else if (page.Contains("hello"))
                actualPage = new Hello();
            else if (page.Contains("error"))
                actualPage = new Error();
            else
                actualPage = new Home();

        }

        [Given(@"I have opened the Home page")]
        public void GivenIHaveOpenedTheHomePage()
        {
            Driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        [Given(@"I have opened the Form page")]
        public void GivenIHaveOpenedTheFormPage()
        {
            Driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
        }

        [When(@"I click on the Home button")]
        public void WhenIClickOnTheHomeButton()
        {
            actualPage.ClickHome();
        }
        
        [When(@"I click on the Form button")]
        public void WhenIClickOnTheFormButton()
        {
            actualPage.ClickForm();
        }
        
        [When(@"I click on the Error button")]
        public void WhenIClickOnTheErrorButton()
        {
            actualPage.ClickError();
        }
        
        [When(@"I click on the UI Testing button")]
        public void WhenIClickOnTheUITestingButton()
        {
            actualPage.ClickUITesting();
        }
        
        [When(@"I enter (.*) to input form and click on the submit button")]
        public void WhenIEnterToInputFormAndClickOnTheSubmitButton(string text)
        {
            Form formPage = new Form();
            formPage.EnterText(text);
            formPage.ClickSubmitButton();
        }        


        [Then(@"the Title should be '(.*)'")]
        public void ThenTheTitleShouldBe( string expectedTitle)
        {
            Assert.AreEqual(expectedTitle, actualPage.GetTitle());
        }


        [Then(@"the logo_src should be (.*)")]
        public void ThenTheLogo_SrcShouldBe(string expectedLogoSRC)
        {
            Assert.IsTrue(actualPage.GetLogoSRC().Contains(expectedLogoSRC));
        }

        [Then(@"I should get navigated to (.*)")]
        public void ThenIShouldGetNavigatedTo(string expectedURL)
        {
            Assert.AreEqual(expectedURL, Driver.Url);
        }
        
        [Then(@"(.*) button should turn to active status")]
        public void ThenButtonShouldTurnToActiveStatus(string button)
        {
            Assert.AreEqual(button, actualPage.GetActiveButton());
        }

        [Then(@"I should get a 404 HTTP response code")]
        public void ThenIShouldGetAHTTPResponseCode()
        {
            Assert.AreEqual("404 Error: File not found :-)", actualPage.GetTitle());
        }
        
        [Then(@"(.*) tag should have (.*) as text")]
        public void TagShouldHaveText(string tag, string text)
        {
            Home homePage = new Home();
            Assert.AreEqual(text, homePage.GetTagText(tag));
        }
        
        [Then(@"I should see one input box and one submit button")]
        public void ThenIShouldSeeOneInputBoxAndOneSubmitButton()
        {
            Form formPage = new Form();
            Assert.IsTrue(formPage.IsInputFieldAvailable() && formPage.IsSubmitButtonAvailable());
        }
        
        [Then(@"I shoud get redirected to the Hello page")]
        public void ThenIShoudGetRedirectedToTheHelloPage()
        {
            Assert.IsTrue(Driver.Url.Contains("http://uitest.duodecadits.com/hello.html"));
        }
        
        [Then(@"(.*) text should appear")]
        public void ThenTextShouldAppear(string text)
        {
            Hello helloPage = new Hello();
            Assert.AreEqual(text, helloPage.GetHelloText());
        }

    }
}

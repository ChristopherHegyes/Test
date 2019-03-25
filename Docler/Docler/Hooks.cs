using Pages;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace Docler
{
    [Binding]
    public sealed class Hooks : TestBase
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
            Driver.Dispose();
        }
    }
}

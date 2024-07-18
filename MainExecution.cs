using Microsoft.Playwright.NUnit;

namespace NightFexDemo
{
    public class MainExecution : PageTest
    {
        Loginpage login = new Loginpage();
        Dashboard dashboard = new Dashboard();

        [SetUp]
        public void Setup()
        {
        }

      
        [Test]
        public async Task NightFaxLogin()
        {
            await login.Login(Page);
            await dashboard.dashboard(Page);
        }
    }
}
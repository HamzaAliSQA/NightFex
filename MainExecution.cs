using Microsoft.Playwright.NUnit;

namespace NightFexDemo
{
    public class MainExecution : PageTest
    {
        Loginpage login = new Loginpage();
        Dashboard dashboard = new Dashboard();
        Delivered delivered = new Delivered();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task NightFex()
        {
            await login.Login(Page);
            await dashboard.dashboard(Page);
            await Task.Delay(3000);
            await delivered.SalesDelivered(Page);
            await Task.Delay(5000);

        }
    }
}
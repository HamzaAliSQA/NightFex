using Microsoft.Playwright.NUnit;

namespace NightFexDemo
{
    public class MainExecution : PageTest
    {
        Loginpage login = new Loginpage();
        Dashboard dashboard = new Dashboard();
        Basepage bp = new Basepage();
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task NightFex_ParallelLogin()
        {
            for (int i = 1; i <= 100; i++)
            {
                var Page = await Context.NewPageAsync();
                await bp.Goto(Page, "https://gyh.mydealerkpi.com/login");
                await bp.Write(Page, "//input[@placeholder='Username']", "TEST12", "username");
                await bp.Write(Page, "//input[@placeholder='Password']", "N1234F", "password");
                await bp.Click(Page, "//input[contains(@class,'ui-button')]", "LoginButton");
                await Task.Delay(100);
            }
            await Task.Delay(3000);
        }
        [Test]
        public async Task NightFaxLogin()
        {
            await login.Login(Page);
            await dashboard.dashboard(Page);
        }
    }
}
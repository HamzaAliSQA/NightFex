using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFexDemo
{
    public class Loginpage
    {
        Basepage bp = new Basepage();
        public async Task Login(IPage page)
        {
            await bp.Goto(page, "https://gyh.mydealerkpi.com/login");
            await bp.Write(page, "//input[@placeholder='Username']", "TEST12", "username");
            await bp.Write(page, "//input[@placeholder='Password']", "N1234F", "password");
            await bp.Click(page, "//input[contains(@class,'ui-button')]", "LoginButton");
            await Task.Delay(10000);
        }
    }
}

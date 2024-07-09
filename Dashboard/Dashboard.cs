using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFexDemo
{
    public class Dashboard
    {
        Basepage bp = new Basepage();
        public async Task dashboard(IPage page)
        {
            bp.Click(page, "//section[@class='tabs']//button/span[text()='June']", "currentMonth");
        }
    }
}

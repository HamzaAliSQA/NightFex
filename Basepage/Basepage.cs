using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFexDemo
{
    public class Basepage
    {
        public async Task Goto(IPage page,string url)
        {
            await page.GotoAsync(url);
        }

        public async Task Write(IPage page, string loc, string text, string stepdetail)
        {
            var locator = await page.QuerySelectorAsync(loc);
            if (locator != null)
            {
                await locator.FillAsync(text);
            }
            else
            {
                Console.WriteLine($"{stepdetail} Not Found ");
            }
        }

        public async Task Click(IPage page, string loc, string stepdetail)
        {
            var locator = await page.QuerySelectorAsync(loc);
            if (locator != null)
            {
                await locator.ClickAsync();
            }
            else
            {
                Console.WriteLine($"{stepdetail} Not Found ");
            }
        }
    }
}

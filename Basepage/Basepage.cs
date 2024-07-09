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
        public async Task SimpleClick(IPage page, string loc)
        {
            var locator = await page.QuerySelectorAsync(loc);
            if (locator != null)
            {
                await locator.ClickAsync();
            }
            else
            {
                Console.WriteLine("Not Found");
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
        public async Task Assertion(IPage page, string selector, string expText, string stepdetail="")
        {
            var element = await page.WaitForSelectorAsync(selector);
            if (element == null)
            {
                Assert.Fail($"No element found with selector: {selector}");
                return; // Ensure we do not proceed further if the element is null
            }

            var actualText = await element.InnerTextAsync();
            if (actualText == expText)
            {
                Assert.That(actualText, Is.EqualTo(expText), $"Expected text: {expText} matches the actual text: {actualText}.");
                //await extent.TakeScreenshot(page, Status.Pass, stepdetail);
            }
            else
            {
                Assert.That(actualText, Is.Not.EqualTo(expText), $"Expected text: {expText} does not match the actual text: {actualText}.");
            }
        }
        public async Task Keyboardaction(IPage page, string action)
        {
            if (action == "up")
            {
                await page.Keyboard.PressAsync("ArrowUp");
            }
            else if (action == "down")
            {
                await page.Keyboard.PressAsync("ArrowDown");
            }
            else if (action == "tab")
            {
                await page.Keyboard.PressAsync("Tab");
            }
            else if (action == "enter")
            {
                await page.Keyboard.PressAsync("Enter");
            }
        }
        public async Task Wait(int wait)
        {
            await Task.Delay(wait);
        }
        public async Task ExecuteFunctionWithErrorHandling(IPage page, Func<IPage, Task> function)
        {
            try
            {
                await function(page); // Invoke the function asynchronously
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                //await extent.TakeScreenshot(page, Status.Fail);
            }
        }
    }
}

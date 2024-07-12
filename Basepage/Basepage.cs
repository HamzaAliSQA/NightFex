using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NightFexDemo
{
    public class Basepage
    {
        public int num;

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
                Console.WriteLine($"{stepdetail} field is filled");
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
                Console.WriteLine($"{stepdetail} field is Clicked");
            }
            else
            {
                Console.WriteLine($"{stepdetail} Not Found ");
            }
        }
        public async Task Assertion(IPage page, string selector,int expvalue, string stepdetail="")
        {
            var element = await page.WaitForSelectorAsync(selector);
            if (element == null)
            {
                Assert.Fail($"No element found with selector: {selector}");
                return; // Ensure we do not proceed further if the element is null
            }
            var actualText = await element.InnerTextAsync();
            int actualValue;
            if (int.TryParse(actualText, out actualValue))
            {
                if (actualValue == expvalue)
                {
                    Assert.AreEqual(expvalue, actualValue);
                    Console.WriteLine($"Expected value: {expvalue} matches the actual value: {actualValue}.");
                    //await extent.TakeScreenshot(page, Status.Pass, stepdetail);
                }
                else
                {
                    Assert.AreEqual(expvalue, actualValue);
                    Console.WriteLine($"Expected value: {expvalue} does not match the actual value: {actualValue}.");
                }
            }
            else
            {
                Assert.Fail($"Unable to parse element text '{actualText}' as integer.");
            }
        }

        public async Task htmlExtractor(IPage page, string selector, string stepdetails = "")
        {

            var element = await page.WaitForSelectorAsync(selector);
            if (element == null)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                var actualText = await element.InnerTextAsync();
                num = int.Parse(actualText);
                //Console.WriteLine($"number: {num}");
            }

        }
        public async Task CountValue(IPage page, string tableRowSelector, string stepdetails = "")
        {
            // Wait for the table rows to be available in the DOM
             var element = await page.WaitForSelectorAsync(tableRowSelector);
            if (element == null)
            {
                Console.WriteLine("Element not found");
                return;
            }
            // Query all rows within the table
            var rows = await page.QuerySelectorAllAsync(tableRowSelector);
            if (rows == null )
            {
                Console.WriteLine("Rows Not Found");
            }
            else
            {
                int totalRows = rows.Count;
                bool noRecordsFound = false;
                foreach (var row in rows)
                {
                    var textContent = await row.TextContentAsync();
                    if (textContent != null && textContent.Contains("No records found"))
                    {
                        noRecordsFound = true;
                        break;
                    }
                }
                if (noRecordsFound)
                {
                    totalRows = 0;
                }
                Console.WriteLine($"{stepdetails} Number: {num} is equal to total number of rows: {totalRows}");
            }
        }

        public async Task Assertion(IPage page, string selector, string expText, string stepdetail = "")
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
                Assert.That(actualText, Is.EqualTo(expText));
                Console.WriteLine($"Expected text: {expText} matches the actual text: {actualText}.");
                //await extent.TakeScreenshot(page, Status.Pass, stepdetail);
            }
            else
            {
                Assert.That(actualText, Is.Not.EqualTo(expText));
                Console.WriteLine($"Expected text: {expText} does not match the actual text: {actualText}.");
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


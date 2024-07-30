using Microsoft.Playwright;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace NightFexDemo
{
    public class Basepage
    {
        public int num;
        public decimal ExtractedNum;


        public async Task Goto(IPage page, string url)
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
        public async Task Assertion(IPage page, string selector, int expvalue, string stepdetail = "")
        {
            var element = await page.WaitForSelectorAsync(selector);
            if (element == null)
            {
                Assert.Fail($"No element found with selector: {selector}");
                return; // Ensure we do not proceed further if the element is null
            }
            var actualText = await element.InnerTextAsync();
            //int actualValue;
            if (int.TryParse(actualText, out int actualValue))
            {
                if (actualValue == expvalue)
                {
                    Assert.AreEqual(expvalue, actualValue);
                    Console.WriteLine($"Expected value: {expvalue} matches the actual value: {actualValue}, {stepdetail}");
                    //await extent.TakeScreenshot(page, Status.Pass, stepdetail);
                }
                else
                {
                    Assert.AreEqual(expvalue, actualValue);
                    Console.WriteLine($"Expected value: {expvalue} does not match the actual value: {actualValue}, {stepdetail}.");
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
        public async Task CountValue(IPage page, string tableRowSelector, string nextpage = "", string stepdetails = "")
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
            if (rows == null)
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

                else if (num > 0 && num <= 1000)
                {
                    await NumberAssertion(page,num,totalRows,stepdetails);
                    //Console.WriteLine($"{stepdetails} Number: {num} is equal to total number of rows: {totalRows}");
                }
                else if (num >= 1001 && num <= 20000)
                {
                    await SimpleClick(page, nextpage);
                    await Wait(3000);
                    var elem = await page.WaitForSelectorAsync(tableRowSelector);
                    var nextPageRows = await page.QuerySelectorAllAsync(tableRowSelector);
                    int nextpagecount = nextPageRows.Count;
                    totalRows += nextpagecount;
                    await NumberAssertion(page, num, totalRows,stepdetails);
                }
                else
                {
                    Console.WriteLine($"total number of rows: {totalRows}");
                }
            }
        }

        public async Task NumberAssertion(IPage page, int actualText, int expText, string stepdetail = "")
        {
            if (actualText == expText)
            {
                Assert.That(actualText, Is.EqualTo(expText));
                //Console.WriteLine($"Expected text: {expText} matches the actual text: {actualText},  {stepdetail}");

                Console.WriteLine($"{stepdetail} Number: {actualText} is equal to total number of rows: {expText}");
                //await extent.TakeScreenshot(page, Status.Pass, stepdetail);
            }
            else
            {
                Assert.That(actualText, Is.Not.EqualTo(expText));
                Console.WriteLine($"Expected text: {expText} does not match the actual text: {actualText},  {stepdetail}.");
            }
        }


        public async Task tabsnumber(IPage page, string Tabloc, string radiobtnLoc, string grandTtloc, string assert1Des, string assert2Des)
        {
            var elementHandle = await page.QuerySelectorAsync(Tabloc); // Replace with your actual selector
            if (elementHandle != null)
            {
                var originalText = await elementHandle.TextContentAsync();
                if (!string.IsNullOrEmpty(originalText))
                {
                    // Extract the number using regular expression
                    var match = Regex.Match(originalText, @"\((\d+)\)");
                    string trimmedValue = match.Success ? match.Groups[1].Value : string.Empty;
                    int Value = int.Parse(trimmedValue);
                    Console.WriteLine("Trimmed Value: " + Value);


                    await Assertion(page, radiobtnLoc, Value, assert1Des);
                    await Assertion(page, grandTtloc, Value, assert2Des);
                }
                else
                {
                    Console.WriteLine("Does not match the value");
                }
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
       
        public async Task SalesPercentage(IPage page, string selector, string stepdetail="")
        {
            var element = await page.WaitForSelectorAsync(selector);
            if (element == null)
            {
                Console.WriteLine("Element not found");
                return;
            }
            var actualText = await element.InnerTextAsync();
            if (actualText == null)
            {
                Console.WriteLine("not found");
            }

            //for triming the values before/after slash
            var trimmedText = actualText.Split('/')[0].Trim();
            var val1 = trimmedText.Replace(",", "");
            int intValue1 = int.Parse(val1);
            num = intValue1;

            var trimmedText2 = actualText.Split('/')[1].Trim();
            var val2 = trimmedText2.Split(' ')[0].Trim();
            var timmedval2 = val2.Replace(",", "");
            int intValue2 = int.Parse(timmedval2);
            
            //for calculating the percentage
            float per = ((float)intValue1 / intValue2) * 100;

            // Round the percentage to two decimal places
            float roundedPer = (float)Math.Round(per, 2);
       
            // Extract the percentage part from the string
            var percentageText = actualText.Split('(', ')')[1].Replace("%", "").Trim();

            // Convert the percentage to float and then to an integer representing hundredths
            float actualPer = float.Parse(percentageText);
            //For Assertion
            await AssertValues(actualPer, roundedPer);

        }

        public async Task AssertValues<T>(T actualValue, T expectedValue,string detail="")
        {
            if (actualValue.Equals(expectedValue))
            {
                Assert.That(actualValue, Is.EqualTo(expectedValue));
                Console.WriteLine($"Expected value: {expectedValue} matches the actual value: {actualValue}, {detail}");
                //await extent.TakeScreenshot(page, Status.Pass, stepdetail); // Uncomment if using async context
            }
            else
            {
                Assert.That(actualValue, Is.Not.EqualTo(expectedValue));
                Console.WriteLine($"Expected value: {expectedValue} does not match the actual value: {actualValue}, {detail}.");
                //await extent.TakeScreenshot(page, Status.Fail, stepdetail); // Uncomment if using async context
            }
        }


        public async Task TextExtract(IPage page, string loc)
        {
            var element = await page.WaitForSelectorAsync(loc);
            if (element == null)
            {
                Console.WriteLine("Element not found");
                return;
            }
            var actualText = await element.InnerTextAsync();
            if (actualText == null)
            {
                Console.WriteLine("not found");
            }
            //For Extraction the numbers from the HTML
            if (decimal.TryParse(actualText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value))
            {
                ExtractedNum = value;
                Console.WriteLine($"{ExtractedNum} Extracted numbers from HTML.");
            }
        }

        public async Task CardsNumberCal(IPage page, string Unitloc, string DaysWLoc, string DaysMnthLoc, string AvgLoc, string trackingNo, string detail = "")
        {
            await TextExtract(page,Unitloc);
            decimal UnitValue = ExtractedNum;
            await TextExtract(page,DaysWLoc);
            decimal DaysWorkedvalue = ExtractedNum;
            await TextExtract(page,DaysMnthLoc);
            decimal DaysInMonthval = ExtractedNum;

            decimal calavg = ((decimal)UnitValue / DaysWorkedvalue);
            decimal RoundedAvgCal = (decimal)Math.Round(calavg, 2);

            await TextExtract(page,AvgLoc);
            decimal actualAvg = ExtractedNum;

            await AssertValues(actualAvg, RoundedAvgCal,"Assertion of Average Values");
            //for Tracking Number calculation
            decimal CalculatedTrackingNo = RoundedAvgCal * DaysInMonthval;
            await TextExtract(page,trackingNo);
            decimal actualTrackingNo = ExtractedNum;
            await AssertValues(actualTrackingNo, CalculatedTrackingNo,"Assertion of Tracking Values");
            
        }
        public async Task TtlPreOwnedSummition(IPage page,string CertifiedLoc,string NonCertLoc, string otherMakesNoLoc, string ttlPreOwnedNoLoc, string detail="" )
        {
            await TextExtract(page, CertifiedLoc);
            decimal val1 = ExtractedNum;
            await TextExtract(page, NonCertLoc);
            decimal val2 = ExtractedNum;
            await TextExtract(page, otherMakesNoLoc);
            decimal val3 = ExtractedNum;
            decimal calculatedSum = val1 + val2 + val3;

            await TextExtract(page, ttlPreOwnedNoLoc);
            decimal actualSum = ExtractedNum;

            //for Assertion
            await AssertValues(actualSum,calculatedSum,detail);
        }

        public async Task GrandTotalCard(IPage page, string NewLoc, string CertLoc, string NonCertLoc, string OtherMakesLoc, string GTotlNo,string detail = "")
        {
            
            await TextExtract(page, NewLoc);
            decimal val1 = ExtractedNum;
            await TextExtract(page, CertLoc);
            decimal val2 = ExtractedNum;
            await TextExtract(page, NonCertLoc);
            decimal val3 = ExtractedNum;
            await TextExtract(page, OtherMakesLoc);
            decimal val4 = ExtractedNum;
            decimal calculatedSum = val1 + val2 + val3 + val4;

            await TextExtract(page, GTotlNo);
            decimal actualSum = ExtractedNum;

            //for Assertion
            await AssertValues(actualSum, calculatedSum, detail);
        }

        public async Task Extraction(IPage page, string selector, string stepdetail = "")
        {
            var element = await page.WaitForSelectorAsync(selector);
            if (element == null)
            {
                Console.WriteLine("Element not found");
                return;
            }
            var actualText = await element.InnerTextAsync();
            if (actualText == null)
            {
                Console.WriteLine("not found");
            }

            var trimmedText = actualText.Split('(', ')')[1].Trim();
            if (int.TryParse(trimmedText, out int num2))
            {
                Console.WriteLine($"Total Value is: { trimmedText}");
            }
            else
            {
                // Handle cases where '=' is not present but we need to extract a number
                var match = Regex.Match(actualText, @"(\d+)");
                if (match.Success)
                {
                    var number = match.Value;
                    Console.WriteLine(number);

                }
            }
        }
    }
}

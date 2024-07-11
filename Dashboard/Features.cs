using Microsoft.Playwright;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NightFexDemo
{
    public class Features
    {
        Basepage bp = new Basepage();
        public async Task Days(IPage page)
        {
            DateTime currentDate = DateTime.Now;

            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(1);


            // Get the number of days in the current month
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            Console.WriteLine($"Number of Days in Current Month: {daysInMonth}");

            // Calculate days worked and days left
            int daysWorked = (currentDate - firstDayOfMonth).Days + 1;
            int daysLeft = (lastDayOfMonth - currentDate).Days - 1;

            // Print the results
            Console.WriteLine($"Days Worked This Month: {daysWorked}");
            Console.WriteLine($"Days Left This Month: {daysLeft}");

            //Days Month
            await bp.Assertion(page, "//th[text() ='Days in a month']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]", daysInMonth, "Current Month of Days");

            //Days Worked
            await bp.Assertion(page, "//th[text() ='Days in a month']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[2]", daysWorked, "Days of Worked");

            //Days Left
            await bp.Assertion(page, "//th[text() ='Days in a month']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[3]", daysLeft, "Days Left");

        }

        public async Task SalesDelivered(IPage page)
        {
           
            await bp.htmlExtractor(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]");
            Console.WriteLine("Delivered Numbers");
            await bp.Assertion(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]",bp.num,"count");
            
            await bp.Click(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]/a", "Deivered");

            if (bp.num > 25)
            {
                //For BreadCrumps
                await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
                await bp.SimpleClick(page, "//span[text() ='100']/parent::li");
                Console.WriteLine("breadcrumbs clicked");
            }
            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "count value");
            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
        
        }
        public async Task NotDelivered(IPage page)
        {
            await bp.htmlExtractor(page, "//th[text() ='Not Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[2]");
            Console.WriteLine("Not Delivered Numbers");
            await bp.Assertion(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[2]", bp.num, "not delivered count");
            await bp.Click(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[2]/a","not delivered");

            if (bp.num > 25)
            {
                //For BreadCrumps
                await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
                await bp.SimpleClick(page, "//span[text() ='100']/parent::li");
                Console.WriteLine("breadcrumbs clicked");
            }

            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "Not delivered row count");

            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");

        }
<<<<<<< Updated upstream
        public async Task Saved(IPage page)
        {
            await bp.htmlExtractor(page, "//th[text() ='Saved']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[3]");
            Console.WriteLine("Saved Numbers");
            await bp.Assertion(page, "//th[text() ='Saved']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[3]", bp.num, "saved count");
            await bp.Click(page, "//th[text() ='Saved']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[3]/a", "saved clicked");
=======
        public async Task ExistingCustomers(IPage page)
        {
            //Get the first value
            await bp.ExtractFirstValue(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]", "count");
            
            await bp.Click(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td/a", "Existing Customers");
            await Task.Delay(4000);
            
            //Rows Count
            await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "count value");

            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
            await Task.Delay(2000);

        }

>>>>>>> Stashed changes

            if (bp.num > 25)
            {
                //For BreadCrumps
                await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
                await bp.SimpleClick(page, "//span[text() ='100']/parent::li");
                Console.WriteLine("breadcrumbs clicked");
            }

            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "saved row count");

            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
        }
        public async Task Closed(IPage page)
        {
            await bp.htmlExtractor(page, "//th[text() ='Closed']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[4]");
            Console.WriteLine("Closed Numbers");
            await bp.Assertion(page, "//th[text() ='Closed']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[4]", bp.num, "Closed count");
            await bp.Click(page, "//th[text() ='Closed']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[4]/a", "Closed clicked");

            if (bp.num > 25)
            {
                //For BreadCrumps
                await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
                await bp.SimpleClick(page, "//span[text() ='100']/parent::li");
                Console.WriteLine("breadcrumbs clicked");
            }

            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "saved row count");

            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
        }
        public async Task Finalized(IPage page)
        {
            await bp.htmlExtractor(page, "//th[text() ='Finalized']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[5]");
            Console.WriteLine("Finalized Numbers");
            await bp.Assertion(page, "//th[text() ='Finalized']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[5]", bp.num, "Finalized count");
            await bp.Click(page, "//th[text() ='Finalized']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[5]/a", "Finalized clicked");
                //For BreadCrumps
                await bp.Wait(4000);
                await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
                await bp.SimpleClick(page, "//span[text() ='100']/parent::li");
                Console.WriteLine("breadcrumbs clicked");
            //}

            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "Finalized row count");

            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
        }

        public async Task Funded(IPage page)
        {
            await bp.htmlExtractor(page, "//th[text() ='Funded']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[6]");
            Console.WriteLine("Funded Numbers");
            await bp.Assertion(page, "//th[text() ='Funded']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[6]", bp.num, "Funded count");
            await bp.Click(page, "//th[text() ='Funded']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[6]/a", "Funded number");
                //For BreadCrumps
                await bp.Wait(4000);
                await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
                await bp.SimpleClick(page, "//span[text() ='100']/parent::li");
                Console.WriteLine("breadcrumbs clicked");

            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "Funded rows count");

            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
        }
        public async Task NotFunded(IPage page)
        {
            await bp.htmlExtractor(page, "//th[text() ='Not Funded']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[7]");
            Console.WriteLine("Not Funded Numbers");
            await bp.Assertion(page, "//th[text() ='Not Funded']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[7]", bp.num, "Not Funded count");
            await bp.Click(page, "//th[text() ='Not Funded']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[7]/a", "Not Funded number");
            if (bp.num > 25)
            {
                //For BreadCrumps
                await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
                await bp.SimpleClick(page, "//span[text() ='100']/parent::li");
                Console.WriteLine("breadcrumbs clicked");
            }
            
            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "Not Funded rows count");

            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
        }
    }
}

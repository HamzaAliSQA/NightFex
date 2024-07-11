using Microsoft.Playwright;
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

            //For BreadCrumps
            await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
            await bp.SimpleClick(page, "//span[text() ='100']/parent::li");
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

            //For BreadCrumps
            //await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
            //await bp.SimpleClick(page, "//span[text() ='100']/parent::li");
            //Console.WriteLine("breadcrumbs clicked");

            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "count value");

            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");

        }

    }
}

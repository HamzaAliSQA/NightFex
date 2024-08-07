﻿        using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NightFexDemo
{
    public class Features
    {
        Basepage bp = new Basepage();

        public async Task TabNumbersAssertion(IPage page)
        {
            await bp.Click(page, "//button[text()='Show Sources']", "Showsources button");

            Console.WriteLine("\n1: NEW / USED table Fields Assertions:");

            //give xpath of desired radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[3]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab

            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[3]/div/a", "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "assertion of July Tab and Combined val", "assertion of July Tab and grand Total Unit");

            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[1]/div/a", "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "assertion of July Tab and Combined val", "assertion of July Tab and grand Total Unit");
            await bp.Wait(5000);


            //2nd Xpath of the RR - API	 radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[2]/div/input");
            await bp.Wait(5000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[2]/div/a", "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab 2 and RR - API val", "Assertion of July Tab 2 and grand Total Unit");
            await bp.Wait(5000);


            //3rd Xpath of the AUTHENTICOM radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[3]/div/input");
            await bp.Wait(5000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[3]/div/a", "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab 3 and AUTHENTICOM val", "Assertion of July Tab 3 and grand Total Unit");
            await bp.Wait(5000);


            //4rd Xpath of the SYSTEM radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[4]/div/input");
            await bp.Wait(5000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[4]/div/a", "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab 4 and SYSTEM val", "Assertion of July Tab 4 and grand Total Unit");
            await bp.Wait(5000);


            //5th Xpath of the RDL - RR radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[5]/div/input");
            await bp.Wait(5000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[5]/div/a", "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab 5 and RDL - RR val", "Assertion of July Tab 5 and grand Total Unit");
            await bp.Wait(8000);


            /*---------------NEW-------------*/
            //give xpath of desired radio button for assertion of sales
            Console.WriteLine("\n2: New table Fields Assertions: ");
            await bp.SimpleClick(page, "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[1]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[1]//a", "//span[text() =' New ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab and Combined val of New tab", "Assertion of July Tab and New Total Unit");
            await bp.Wait(5000);

            //2nd Xpath of the RR - API	 radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[2]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[2]//a", "//span[text() =' New ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab and RR - API val of New tab", "Assertion of July Tab and New Total Unit");
            await bp.Wait(5000);


            //3rd Xpath of the AUTHENTICOM radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[3]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[3]//a", "//span[text() =' New ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab and AUTHENTICOM val of New tab", "Assertion of July Tab and New Total Unit");
            await bp.Wait(5000);


            //4th Xpath of the SYSTEM radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[4]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[4]//a", "//span[text() =' New ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab and SYSTEM val of New tab", "Assertion of July Tab and New Total Unit");
            await bp.Wait(5000);

            //5th Xpath of the RDL - RR radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[5]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[5]//a", "//span[text() =' New ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab and RDL - RR val of New tab", "Assertion of July Tab and New Total Unit");
            await bp.Wait(8000);

            /*---------------USED-------------*/

            await bp.SimpleClick(page, "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[5]/div/input");
            await bp.Wait(4000);

            //give xpath of desired radio button for assertion of sales
            Console.WriteLine("\n3: Used table Fields Assertions: ");
            await bp.SimpleClick(page, "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[1]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[1]//a", "//span[text() =' Total Pre-owned ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab and Combined val of New tab", "Assertion of July Tab and New Total Unit");
            await bp.Wait(5000);

            //2nd Xpath of the RR - API	 radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[2]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[2]//a", "//span[text() =' Total Pre-owned ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab and RR - API val of New tab", "Assertion of July Tab and New Total Unit");
            await bp.Wait(5000);


            //3rd Xpath of the AUTHENTICOM radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[3]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[3]//a", "//span[text() =' Total Pre-owned ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab and AUTHENTICOM val of New tab", "Assertion of July Tab and New Total Unit");
            await bp.Wait(5000);


            //4th Xpath of the SYSTEM radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[4]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[4]//a", "//span[text() =' Total Pre-owned ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab and SYSTEM val of New tab", "Assertion of July Tab and New Total Unit");
            await bp.Wait(5000);

            //5th Xpath of the RDL - RR radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[5]/div/input");
            await bp.Wait(4000);

            //Month Tab => New/Used radio button => GrandTotal tab
            await bp.tabsnumber(page, "//span[text() ='July']//parent::button", "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[5]//a", "//span[text() =' Total Pre-owned ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Assertion of July Tab and RDL - RR val of New tab", "Assertion of July Tab and New Total Unit");
            await bp.Wait(8000);
            
            //For Unchceked the radio button
            await bp.SimpleClick(page, "//th[text() ='Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[5]/div/input");
            await bp.Wait(4000);
        }

        public async Task New_UnitValue(IPage page)
        {
            Console.WriteLine("New Unit");
            await bp.SimpleClick(page, "//th[text() ='New']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tbody/tr/td[1]/div/input");
            await bp.Wait(4000);

            await bp.htmlExtractor(page, "//span[text() =' New ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]");
            Console.WriteLine("\n In New table the unit values: ");
            await bp.Assertion(page, "//span[text() =' New ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", bp.num, "Unit count");
            await bp.Click(page, "//span[text() =' New ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "New table Unit ");

            if (bp.num > 25)
            {
                //For BreadCrumps
                await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
                await bp.SimpleClick(page, "//span[text() ='100']/parent::li");
                Console.WriteLine("breadcrumbs clicked");
            }

            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "Unit row count");

            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
            await bp.Wait(4000);

            //New / USED
            Console.WriteLine("\nNew / Used \nCombined:");
            await bp.SimpleClick(page, "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[1]/div/input");
            await bp.Wait(4000);

            await bp.htmlExtractor(page, "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]");
            Console.WriteLine("\n In New table the unit values: ");
            await bp.Assertion(page, "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", bp.num, "Grand total Unit count");
            await bp.Click(page, "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Grand total table Unit ");
            await bp.Wait(4000);

            if (bp.num > 25)
            {
                //For BreadCrumps
                await bp.SimpleClick(page, "//span[text()='100']/parent::div//following-sibling::div/span");
                await bp.Wait(4000);
                await bp.SimpleClick(page, "//span[text() ='250']/parent::li");
                await bp.Wait(4000);
                Console.WriteLine("breadcrumbs clicked");
                await bp.Wait(4000);
            }

            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "Grand total row count");
            await bp.Wait(4000);
            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
            await bp.Wait(4000);

            Console.WriteLine("\nNew / Used \nSystem:");
            await bp.SimpleClick(page, "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[4]/div/input");
            await bp.Wait(4000);

            await bp.htmlExtractor(page, "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]");
            Console.WriteLine("\n In New table the unit values: ");
            await bp.Assertion(page, "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", bp.num, "Grand total Unit count");
            await bp.Click(page, "//span[text() =' Grand Total ']/parent::td/parent::tr/parent::thead//following-sibling::tbody/tr[2]/td/span[2]", "Grand total table Unit ");
            await bp.Wait(4000);

            if (bp.num > 25)
            {
                //For BreadCrumps
                await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
                await bp.Wait(4000);
                await bp.SimpleClick(page, "//span[text() ='25']/parent::li");
                await bp.Wait(4000);
                Console.WriteLine("breadcrumbs clicked");
                await bp.Wait(4000);
            }

            //Rows count
            await bp.CountValue(page, "//th[text() ='Date ']/following-sibling::th[text()='Type ']/parent::tr/parent::thead/following-sibling::tbody//tr", "Grand total row count");
            await bp.Wait(4000);
            //close the screen
            await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
            await bp.Wait(4000);
        }
        public async Task Days(IPage page)
        {
            DateTime currentDate = DateTime.Now;

            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(1);


            // Get the number of days in the current month
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            Console.WriteLine($"Number of Days in Current Month: {daysInMonth}");

            
            await bp.htmlExtractor(page, "//th[contains(text(),'Todays Sales ')]/ancestor::table//tbody[1]//td[1]");
            await bp.Wait(5000);

            if (bp.num > 0)
            {
                int daysWorked = (currentDate - firstDayOfMonth).Days + 1;

                Console.WriteLine($"Days Worked This Month: {daysWorked}");

                await bp.Assertion(page, "//th[text() ='Days in a month']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[2]", daysWorked, "Days of Worked");

            }
            else
            {
                int daysWorked = (currentDate - firstDayOfMonth).Days;
                int daysLeft = (lastDayOfMonth - currentDate).Days;


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
        //public async Task CalculateValue(IPage page)
        //{
        //    await bp.htmlExtractor(page, "//th[contains(text(),'Todays Sales ')]/ancestor::table//tbody[1]//td[1]");
        //    await bp.Wait(5000);

        //    if(bp.num> 0)
        //    {
        //        DateTime currentDate = DateTime.Now;
        //        DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

        //        int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
        //        Console.WriteLine($"Number of Days in Current Month: {daysInMonth}");

        //        int daysWorked = (currentDate - firstDayOfMonth).Days +1;

        //        Console.WriteLine($"Days Worked This Month: {daysWorked}");
               
        //        await bp.Assertion(page, "//th[text() ='Days in a month']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[2]", daysWorked, "Days of Worked");

        //    }

        //}
        public async Task SalesDelivered(IPage page)
        {
           
            await bp.htmlExtractor(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]");
            Console.WriteLine("Delivered Numbers");
            await bp.Assertion(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]",bp.num,"count");
            
            await bp.Click(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]/a", "Delivered");

            if (bp.num >= 25)
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
        public async Task Saved(IPage page)
        {
            await bp.htmlExtractor(page, "//th[text() ='Saved']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[3]");
            Console.WriteLine("Saved Numbers");
            await bp.Assertion(page, "//th[text() ='Saved']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[3]", bp.num, "saved count");
            await bp.Click(page, "//th[text() ='Saved']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[3]/a", "saved clicked");

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
            Console.WriteLine("Finalized No");
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

        
      
        public async Task MTD_ExistingCustomers(IPage page)
        {
            await bp.Click(page, "//button[text()='Show Sources']", "Showsources button");

            //give xpath of desired radio button for assertion of sales
            await bp.SimpleClick(page, "//th[text() ='New / Used']/parent::tr/parent::thead/parent::table//following-sibling::tbody//following-sibling::tr/td[3]/div/input");
            await bp.Wait(4000);
            Console.WriteLine("MTD Existing Customer Sales");

            //for calculating and assertion the percentage
            await bp.SalesPercentage(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]","MTD Exist Percentage");

            await bp.Click(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]/a", "MTD Existing Customers");
            await bp.Wait(4000);
            try
            {
                if (bp.num > 25)
                {
                    //For BreadCrumps
                    Console.WriteLine("breadcrumbs clicked");
                    await bp.SimpleClick(page, "//span[text()='25']/parent::div//following-sibling::div/span");
                    await bp.Wait(2000);
                    await bp.SimpleClick(page, "//span[text() ='500']/parent::li");
                    await bp.Wait(4000);

                    //Rows Count
                    await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "", "MTD count");

                    //close the screen
                    await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
                    await Task.Delay(2000);
                }
                else
                {
                    //Rows Count
                    await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "", "MTD count");

                    //close the screen
                    await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
                    await Task.Delay(2000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"MTD Existing Customer error: {ex}");
            }
        }


        public async Task MTD_NewCustomers(IPage page)
        {
            //Get the first value
            Console.WriteLine("New Customer Sales");

            //for calculating and assertion the percentage
            await bp.SalesPercentage(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[2]", "MTD New Cust Percentage");

            await bp.Click(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[2]/a", "MTD New Customers");
            await bp.Wait(4000);
            try
            {
                if (bp.num > 25)
                {
                    //For BreadCrumps
                    Console.WriteLine("breadcrumbs clicked");
                    await bp.SimpleClick(page, "//div[@aria-label='dropdown trigger']/parent::div//following-sibling::div/span");
                    await bp.SimpleClick(page, "//span[text() ='500']/parent::li");
                    await bp.Wait(4000);
                    //Rows Count
                    await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "", "MTD New Cust count value");

                    //close the screen
                    await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
                    await Task.Delay(2000);
                }
                else
                {
                    //Rows Count
                    await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "", "MTD New Cust count value");

                    //close the screen
                    await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
                    await Task.Delay(2000);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"MTD New Customer error: {ex}");
            }
            
        }


        //>>>>>>>>>>XXXXXXXXX<<<<<<<<<<<<<<<<<
        public async Task YTD_ExistingCustomers(IPage page)
        {

            Console.WriteLine("YTD Existing Customer Sales");

            //for calculating and assertion the percentage
            await bp.SalesPercentage(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[3]", "YTD Exist Cust Percentage");


            try
            {
                await bp.Click(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[3]/a", "YTD New Customers");
                await Task.Delay(4000);
                if (bp.num > 25)
                {
                    //For BreadCrumps
                    Console.WriteLine("breadcrumbs clicked");
                    await bp.SimpleClick(page, "//div[@aria-label='dropdown trigger']/parent::div//following-sibling::div/span");
                    await bp.SimpleClick(page, "//span[text() ='500']/parent::li");
                    await bp.Wait(4000);
                    //Rows Count
                    await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "", "YTD New Cust count value");

                    //close the screen
                    await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
                    await Task.Delay(2000);
                }
                else
                {
                    await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "", "YTD New Cust count value");

                    //close the screen
                    await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
                    await Task.Delay(2000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"YTD Existing Customer error: {ex}");
            }
        }
        public async Task YTD_NewCustomers(IPage page)
        {
            
            //Get the first value
            Console.WriteLine("YTD New Customer Sales");

            //for calculating and assertion the percentage
            await bp.SalesPercentage(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[4]", "YTD New Cust Percentage");


            await bp.Click(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[4]/a", "New Customers");
            await Task.Delay(6000);
            try
            {
                if (bp.num > 25)
                {
                    //For BreadCrumps
                    Console.WriteLine("breadcrumbs clicked");
                    await bp.SimpleClick(page, "//div[@aria-label='dropdown trigger']/parent::div//following-sibling::div/span");
                    await bp.SimpleClick(page, "//span[text() ='1000']/parent::li");
                    await bp.Wait(4000);
                    //Rows Count
                    await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "", "New Cust count value");

                    //close the screen
                    await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
                    await Task.Delay(2000);
                }
                else
                {
                    await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "", "New Cust count value");

                    //close the screen
                    await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
                    await Task.Delay(2000);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"YTD New Customer error: {ex}");
            }
            
        }
        public async Task BOT_ExistingCustomers(IPage page)
        {
            Console.WriteLine("BOT Existing Customer Sales");

            //for calculating and assertion the percentage
            await bp.SalesPercentage(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[5]", "BOT Exist Cust Percentage");

            await bp.Click(page, "//th[text() ='Existing Customers (Sales Count)']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[5]/a", "BOT Existing Customers");
            await Task.Delay(6000);
            try
            {
                if (bp.num > 25)
                {
                    //For BreadCrumps
                    Console.WriteLine("breadcrumbs clicked");
                    await bp.SimpleClick(page, "//div[@aria-label='dropdown trigger']/parent::div//following-sibling::div/span");
                    await bp.SimpleClick(page, "//span[text() ='1000']/parent::li");
                    await bp.Wait(3000);

                    //Rows Count for Page# 1
                    await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "//button[text()=' 2 ']", "Existing Cust count value");

                    //close the screen
                    await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
                    await Task.Delay(2000);
                }
                else
                {
                    //Rows Count for Page# 1
                    await bp.CountValue(page, "//th[text() ='Customer# ']/following-sibling::th[text()='Customer Name ']/parent::tr/parent::thead/following-sibling::tbody//tr", "//button[text()=' 2 ']", "Existing Cust count value");

                    //close the screen
                    await bp.SimpleClick(page, "//button[contains(@class,'p-dialog-header-close')]");
                    await Task.Delay(2000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"BOT Existing Customer: {ex}");
            }
           
        }
       
        public async Task NewCard(IPage page)
        {
            Console.WriteLine("New Card");
            await bp.CardsNumberCal(page, "//div[@class='saleStatSec']/div[2]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='row headTableHolder']//div[1]//td[2]", "//div[@class='row headTableHolder']//div[1]//td[1]", "//div[@class='saleStatSec']/div[2]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[2]//tbody[1]/tr[2]/td[2]");
        }

        public async Task CertifiedCard(IPage page)
        {
            Console.WriteLine("Certified Card");
            await bp.CardsNumberCal(page, "//div[@class='saleStatSec']/div[3]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='row headTableHolder']//div[1]//td[2]", "//div[@class='row headTableHolder']//div[1]//td[1]", "//div[@class='saleStatSec']/div[3]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[3]//tbody[1]/tr[2]/td[2]");
        }
        public async Task Non_CertifiedCard(IPage page)
        {
            Console.WriteLine("Non Certified Card");
            await bp.CardsNumberCal(page, "//div[@class='saleStatSec']/div[4]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='row headTableHolder']//div[1]//td[2]", "//div[@class='row headTableHolder']//div[1]//td[1]", "//div[@class='saleStatSec']/div[4]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[4]//tbody[1]/tr[2]/td[2]");
        }
        public async Task OtherMakes(IPage page)
        {
            Console.WriteLine("Other Makes Card");
            await bp.CardsNumberCal(page, "//div[@class='saleStatSec']/div[5]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='row headTableHolder']//div[1]//td[2]", "//div[@class='row headTableHolder']//div[1]//td[1]", "//div[@class='saleStatSec']/div[5]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[5]//tbody[1]/tr[2]/td[2]");
        }

        public async Task TotalPreOwnedCard(IPage page)
        {
            //For the Sum of Unit Values of cards.
            Console.WriteLine("Total Pre-Owned Card \n Totatl Number of Unit Values of Total PreOwned Card");
            await bp.TtlPreOwnedSummition(page, "//div[@class='saleStatSec']/div[3]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='saleStatSec']/div[4]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='saleStatSec']/div[5]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='saleStatSec']/div[6]//tbody[1]/tr[2]/td[1]/span[2]", "Assertion of Total Unit Values");
            
            //For the Sum of Tracking Numbers of Total Preowned Card
            Console.WriteLine("Totatl Number of Tracking Values of Total PreOwned Card");
            await bp.TtlPreOwnedSummition(page, "//div[@class='saleStatSec']/div[3]//tbody[1]/tr[2]/td[2]", "//div[@class='saleStatSec']/div[4]//tbody[1]/tr[2]/td[2]", "//div[@class='saleStatSec']/div[5]//tbody[1]/tr[2]/td[2]", "//div[@class='saleStatSec']/div[6]//tbody[1]/tr[2]/td[2]", "Assertion of Total Tracking Values");
            
            //For the Sum of Average Numbers of Total Preowned Card
            Console.WriteLine("Totatl Number of Average Values of Total Preowned Card");
            await bp.TtlPreOwnedSummition(page, "//div[@class='saleStatSec']/div[3]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[4]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[5]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[6]//tbody[1]/tr[2]/td[3]", "Assertion of Total Average Values");
        }

        public async Task GrandTotalCard(IPage page)
        {
            //For the Sum of Unit Values of cards.
            Console.WriteLine("Grand Total \n Totatl Number of Unit Values of Grand Total Card");
            await bp.GrandTotalCard(page, "//div[@class='saleStatSec']/div[2]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='saleStatSec']/div[3]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='saleStatSec']/div[4]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='saleStatSec']/div[5]//tbody[1]/tr[2]/td[1]/span[2]", "//div[@class='saleStatSec']/div[7]//tbody[1]/tr[2]/td[1]/span[2]","Assertion of Grand Total Unit Values");

            //For the Sum of Tracking Numbers of Total Preowned Card
            Console.WriteLine("Totatl Number of Tracking Values of  Grand Total Card");
            await bp.GrandTotalCard(page, "//div[@class='saleStatSec']/div[2]//tbody[1]/tr[2]/td[2]", "//div[@class='saleStatSec']/div[3]//tbody[1]/tr[2]/td[2]", "//div[@class='saleStatSec']/div[4]//tbody[1]/tr[2]/td[2]", "//div[@class='saleStatSec']/div[5]//tbody[1]/tr[2]/td[2]", "//div[@class='saleStatSec']/div[7]//tbody[1]/tr[2]/td[2]", "Assertion of Grand Total Tracking Values");

            //For the Sum of Average Numbers of Total Preowned Card
            Console.WriteLine("Totatl Number of Average Values of  Grand Total Card");
            await bp.GrandTotalCard(page, "//div[@class='saleStatSec']/div[2]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[3]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[4]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[5]//tbody[1]/tr[2]/td[3]", "//div[@class='saleStatSec']/div[7]//tbody[1]/tr[2]/td[3]","Assertion of Grand Total of Average Values");
        }




        public async Task TotalTradeIn(IPage page)
        {
            await page.EvaluateAsync(@"window.scrollBy(0, 1000);");
            await bp.Wait(3000);

            //Total trade
            Console.WriteLine("'The Total Trade'");
            await bp.Extraction(page, "//p-radiobutton[@value ='tradeIn']/parent::div/span", "The total Trade value");
            await bp.Wait(3000);
            await bp.CountValue(page, "//th[text() =' Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "total trade");
            await bp.Wait(3000);


            //Sold
            Console.WriteLine("\n'The Sold'");
            await bp.Click(page, "//p-radiobutton[@value ='sold']//div[2]", "Sold Radio button");
            await bp.Wait(5000);
            await bp.Extraction(page, "//p-radiobutton[@value ='sold']/parent::div/span", "The total Sold value");
            await bp.Wait(5000);
            await bp.CountValue(page, "//th[text() =' Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "total Sold");
            await bp.Wait(5000);

            //Funded
            Console.WriteLine("\n'The Funded'");
            await bp.Click(page, "//p-radiobutton[@value ='funded']//div[2]", "Funded Radio button");
            await bp.Wait(3000);
            await bp.Extraction(page, "//p-radiobutton[@value ='funded']/parent::div/span", "The total funded value");
            await bp.Wait(3000);
            await bp.CountValue(page, "//th[text() =' Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "total Sold");
            await bp.Wait(3000);

            //Not Funded
            Console.WriteLine("\n'The Not Funded'");
            await bp.Click(page, "//p-radiobutton[@value ='notfunded']//div[2]", "notfunded Radio button");
            await bp.Wait(3000);
            await bp.Extraction(page, "//p-radiobutton[@value ='notfunded']/parent::div/span", "The total Not funded value");
            await bp.Wait(5000);
            await bp.CountValue(page, "//th[text() =' Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "total Sold");
            await bp.Wait(5000);

            //WholeSale
            Console.WriteLine("\n'The Whole Sale Value'");
            await bp.Extraction(page, "//span[text() =' Wholesale ']/parent::div/span[2]", "The total Whole Sale");
            await bp.Wait(3000);
            await bp.CountValue(page, "//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "Whole Sale");
            await bp.Wait(3000);

            //DEALER TRADE
            Console.WriteLine("\n'The Dealer trade'");
            await bp.Extraction(page, "//span[text() =' Dealer Trade ']/parent::div/span[2]", "The total Whole Sale");
            await bp.Wait(3000);
            await bp.CountValue(page, "//th[text() ='Deal Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "Whole Sale");
            await bp.Wait(3000);

            //Lease Return
            Console.WriteLine("\n'The Dealer trade'");
            await bp.Extraction(page, "//span[text() =' Lease Return ']/parent::div/span[2]", "The total Whole Sale");
            await bp.Wait(3000);
            await bp.CountValue(page, "//th[text() ='Lender ']/parent::tr/parent::thead//following-sibling::tbody//tr", "Whole Sale");
            await bp.Wait(3000);

            Console.WriteLine("\nTOP SALES MANAGER");
            await bp.CountValue(page, "//th[text() ='User Name ']/parent::tr/parent::thead//following-sibling::tbody//tr/td[text() ='1']", "Top sales Manager");
        }

        public async Task Sales(IPage page)
        {
            DateTime currentDate = DateTime.Now;

            DateTime dayBeforeYesterday = currentDate.AddDays(-2);
            DateTime yesterday = currentDate.AddDays(-1);
            DateTime today = currentDate;

            /*--------------Before Yesterday--------------*/
            Console.WriteLine($"\nDay Before Yesterday's Date: {dayBeforeYesterday.ToShortDateString()} ({dayBeforeYesterday.DayOfWeek})");

            //New
            await bp.htmlExtractor(page, "//th[text() = 'Day Before Yesterdays Sales ( Mon, Jul 22, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[1]");
            await bp.Wait(3000);

            Console.WriteLine("1:The New sales Record:");
            await bp.Click(page, "//th[text() = 'Day Before Yesterdays Sales ( Mon, Jul 22, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[1]", "New value");
            await bp.Wait(3000);

            await bp.CountValue(page, "//strong[text() =' New ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "New Rows Count");
            await bp.Wait(3000);

            await bp.SimpleClick(page, "//strong[text() =' New ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);


            //certified
            await bp.htmlExtractor(page, "//th[text() = 'Day Before Yesterdays Sales ( Mon, Jul 22, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[2]");
            await bp.Wait(3000);

            Console.WriteLine("2:The Certified sales Record:");
            await bp.Click(page, "//th[text() = 'Day Before Yesterdays Sales ( Mon, Jul 22, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[2]", "Certified Value");
            await bp.Wait(3000);


            await bp.CountValue(page, "//strong[text() =' Certified ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Certified Rows Count");

            await bp.SimpleClick(page, "//strong[text() =' Certified ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);

            //Not certified
            await bp.htmlExtractor(page, "//th[text() = 'Day Before Yesterdays Sales ( Mon, Jul 22, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[3]");
            await bp.Wait(3000);

            Console.WriteLine("3:The Not Certified sales Record:");
            await bp.Click(page, "//th[text() = 'Day Before Yesterdays Sales ( Mon, Jul 22, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[3]", "Certified Value");
            await bp.Wait(3000);


            await bp.CountValue(page, "//strong[text() =' Non-Certified ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Not Certified Rows Count");

            await bp.SimpleClick(page, "//strong[text() =' Non-Certified ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);

            //Other Makes
            await bp.htmlExtractor(page, "//th[text() = 'Day Before Yesterdays Sales ( Mon, Jul 22, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[4]");
            await bp.Wait(3000);

            Console.WriteLine("4:The Other Makes sales Record:");
            await bp.Click(page, "//th[text() = 'Day Before Yesterdays Sales ( Mon, Jul 22, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[4]", "Other Makes Value");
            await bp.Wait(3000);


            await bp.CountValue(page, "//strong[text() =' Other-Makes ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Other Makes Rows Count");

            await bp.SimpleClick(page, "//strong[text() =' Other-Makes ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);
         
            /*-------------Yesterday Date--------------*/
            Console.WriteLine($"\nYesterday's Date: {yesterday.ToShortDateString()} ({yesterday.DayOfWeek})");

            //New
            await bp.htmlExtractor(page, "//th[text() = 'Yesterdays Sales ( Tue, Jul 23, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[1]");
            await bp.Wait(3000);

            Console.WriteLine("1:The New sales Record:");
            await bp.Click(page, "//th[text() = 'Yesterdays Sales ( Tue, Jul 23, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[1]", "New value");
            await bp.Wait(3000);


            await bp.CountValue(page, "//strong[text() =' New ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Rows Count");
            await bp.Wait(3000);

            await bp.SimpleClick(page, "//strong[text() =' New ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);

            //certified
            await bp.htmlExtractor(page, "//th[text() = 'Yesterdays Sales ( Tue, Jul 23, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[2]");
            await bp.Wait(3000);

            Console.WriteLine("2:The Certified sales Record:");
            await bp.Click(page, "//th[text() = 'Yesterdays Sales ( Tue, Jul 23, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[2]", "Certified Value");
            await bp.Wait(3000);


            await bp.CountValue(page, "//strong[text() =' Certified ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Certified Rows Count");

            await bp.SimpleClick(page, "//strong[text() =' Certified ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);

            //Not certified
            await bp.htmlExtractor(page, "//th[text() = 'Yesterdays Sales ( Tue, Jul 23, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[3]");
            await bp.Wait(3000);

            Console.WriteLine("3:The Not Certified Sales Record:");
            await bp.Click(page, "//th[text() = 'Yesterdays Sales ( Tue, Jul 23, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[3]", "Not Certified Value");
            await bp.Wait(3000);


            await bp.CountValue(page, "//strong[text() =' Non-Certified ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Certified Rows Count");

            await bp.SimpleClick(page, "//strong[text() =' Non-Certified ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);

            //other makes
            await bp.htmlExtractor(page, "//th[text() = 'Yesterdays Sales ( Tue, Jul 23, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[4]");
            await bp.Wait(3000);

            Console.WriteLine("4:The Other Makes Sales Record:");
            await bp.Click(page, "//th[text() = 'Yesterdays Sales ( Tue, Jul 23, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[4]", "Other Makes Value");
            await bp.Wait(3000);


            await bp.CountValue(page, "//strong[text() =' Other-Makes ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Other Makes Rows Count");

            await bp.SimpleClick(page, "//strong[text() =' Other-Makes ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);


            /*-------------Todays Date----------*/
            Console.WriteLine($"\nToday's Date: {today.ToShortDateString()} ({today.DayOfWeek})");

            //New
            await bp.htmlExtractor(page, "//th[text() = 'Todays Sales ( Wed, Jul 24, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[1]");
            await bp.Wait(3000);

            Console.WriteLine("1:The New sales Record:");
            await bp.Click(page, "//th[text() = 'Todays Sales ( Wed, Jul 24, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[1]", "New value");
            await bp.Wait(3000);

            await bp.CountValue(page, "//strong[text() =' New ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Rows Count");
            await bp.Wait(3000);

            await bp.SimpleClick(page, "//strong[text() =' New ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);

            //certified
            await bp.htmlExtractor(page, "//th[text() = 'Todays Sales ( Wed, Jul 24, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[2]");
            await bp.Wait(3000);

            Console.WriteLine("2:The Certified sales Record:");
            await bp.Click(page, "//th[text() = 'Todays Sales ( Wed, Jul 24, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[2]", "Certified Value");
            await bp.Wait(3000);

            await bp.CountValue(page, "//strong[text() =' Certified ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Certified Rows Count");

            await bp.SimpleClick(page, "//strong[text() =' Certified ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);


            //Not certified
            await bp.htmlExtractor(page, "//th[text() = 'Todays Sales ( Wed, Jul 24, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[3]");
            await bp.Wait(3000);

            Console.WriteLine("3:The Not Certified sales Record:");
            await bp.Click(page, "//th[text() = 'Todays Sales ( Wed, Jul 24, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[3]", "Certified Value");
            await bp.Wait(3000);

            await bp.CountValue(page, "//strong[text() =' Non-Certified ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Certified Rows Count");

            await bp.SimpleClick(page, "//strong[text() =' Non-Certified ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);

            //Other makes
            await bp.htmlExtractor(page, "//th[text() = 'Todays Sales ( Wed, Jul 24, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[4]");
            await bp.Wait(3000);

            Console.WriteLine("4:The Other Makes sales Record:");
            await bp.Click(page, "//th[text() = 'Todays Sales ( Wed, Jul 24, 2024 ) ']/parent::tr/parent::thead/parent::table//tbody[1]//td[4]", "Other Makes Value");
            await bp.Wait(3000);

            await bp.CountValue(page, "//strong[text() =' Other-Makes ']/parent::div/parent::p-header/parent::span/parent::div/following-sibling::div/div[4]//th[text() ='Date ']/parent::tr/parent::thead//following-sibling::tbody//tr", "", "Other Makes Rows Count");

            await bp.SimpleClick(page, "//strong[text() =' Other-Makes ']/parent::div/parent::p-header/parent::span/following-sibling::div//button");
            await bp.Wait(3000);
        }

    }
}

﻿using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFexDemo
{
    public class Dashboard
    {
        Basepage bp = new Basepage();
        Features features = new Features();
        Header header = new Header();
        public async Task dashboard(IPage page)
        {

           
         
           // await features.Days(page);
            await features.MTD_ExistingCustomers(page);
            await features.NewCard(page);
            await features.CertifiedCard(page);
            await features.Non_CertifiedCard(page);
            await features.OtherMakes(page);
            await features.TotalPreOwnedCard(page);
            await features.GrandTotalCard(page);

            //await features.MTD_NewCustomers(page);
            //await features.BOT_ExistingCustomers(page);
            //await features.YTD_ExistingCustomers(page);
            //await features.YTD_NewCustomers(page);

            //await features.TabNumbersAssertion(page);
            //await features.SalesDelivered(page);
            //await features.NotDelivered(page);
            //await features.Saved(page);
            //await features.Closed(page);
            //await features.Finalized(page);
            //await features.Funded(page);
            //await features.NotFunded(page);

            ////await header.Headers(page);
            ////await features.New_UnitValue(page);
            //await features.Agefilter(page);


            //await features.TotalTradeIn(page);
            //await features.Sales(page);
        }
    }
}

using Microsoft.Playwright;
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
            await features.Days(page);
            await features.TabNumbersAssertion(page);
            //await features.SalesDelivered(page);
            //await features.NotDelivered(page);
            //await features.Saved(page);
            //await features.Closed(page);
            //await features.Finalized(page);
            //await features.Funded(page);
            //await features.NotFunded(page);
            //await features.ExistingCustomers(page);
            //await header.Headers(page);
        }
    }
}

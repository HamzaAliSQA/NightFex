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
        public async Task dashboard(IPage page)
        {
            await features.Days(page);
            await features.SalesDelivered(page);
            await features.NotDelivered(page);
        }
    }
}

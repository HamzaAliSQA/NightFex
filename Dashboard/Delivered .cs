using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NightFexDemo
{
    public class Delivered
    {
        Basepage bp = new Basepage();
        public async Task SalesDelivered(IPage page)
        {
           
            await bp.htmlExtractor(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]");          
            await bp.Assertion(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]",bp.num,"count");
            await bp.Click(page, "//th[text() ='Delivered']/parent::tr/parent::thead/parent::table//following-sibling::tbody//td[1]/a", "Deivered Click");

            await bp.CountValue(page, "//th[text() ='Date ']/parent::tr/parent::thead/following-sibling::tbody//tr","count value");


        }
     

    }
}

using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFexDemo
{
    public class RoleType
    {
        Basepage bp =new Basepage();
        public async Task RoletypeDropdown(IPage page)
        {
            await bp.Click(page, "//label[text()='Role Type:']/parent::div//following-sibling::div/select","drop down");
            await bp.Click(page, "//option[text() =' Sale Manager']","drop");
                                                                        
        
        }
    }
}

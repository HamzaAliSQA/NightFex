using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightFexDemo
{
    public class Header
    {
        Basepage bp = new Basepage();
        public async Task Headers(IPage page) 
        {
            //1
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[2]/li/button", "First drop-down");
            await bp.Wait(6000);
            
            //2
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[1]/app-todo-list//button", "Second drop-down");
            await bp.Wait(6000);
            
            //3
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[2]/app-todo-list//button", "Third drop-down");
            await bp.Wait(6000);
            
            //4
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[3]/app-todo-list//button", "Fourth drop-down");
            await bp.Wait(6000);
            
            //5
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[4]/app-todo-list//button", "Fifth drop-down");
            await bp.Wait(6000);

            //6
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[5]/app-todo-list//button", "Sixth drop-down");
            await bp.Wait(6000);

            //7
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[6]/app-todo-list//button", "Seventh drop-down");
            await bp.Wait(6000);

            //8
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[7]//a[@title ='F&I Rotation']", "Members Modal");
            await bp.Wait(6000);

            //Count the total rows
            await bp.CountValue(page, "//h1[text() ='Pending Auto-Transfer']/parent::div//table[2]//tbody//tr", "Count total Values ");
            await bp.Wait(6000);
            
            //CLose Modal
            await bp.Click(page, "//button[text() ='Close']", "Close Modal");
            await bp.Wait(6000);

            //Theme
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[8]//label", "Light Theme");
            await bp.Wait(6000);
            
            //drak
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[8]//label", "Dark theme");
            await bp.Wait(6000);

            //Screen Size
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[9]//a[@class ='no-hover d-flex align-items-center justify-content-center']", "Screen Maximized");
            await bp.Wait(6000);
            
            //Screen Minimized
            await bp.Click(page, "//a[@class ='exitFullScreenTrigger']", "Screen Minimized");
            await bp.Wait(6000);

            //Profile Drpdwn
            await bp.Click(page, "//div[@class ='pull-right pd-zero headNav']//ul[3]//li[10]//section", "Profile");
            await bp.Wait(6000);


        }
    }
}

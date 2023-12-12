using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace INSYProject
{
    public class Recreationalmaterials
    {
       
        public int ItemId { get; set; }
        public string Name { get; set; }

        public bool Availability { get; set; }
        public bool OnSiteUseOnly




        public string CheckAvailabilityForOnSiteUse(int itemId)
        {
            if (Availability&& OnSiteUseOnly)
            {
                return "It is availabel and on site use only";
            }
            else if (Availability)
            {
                return "It is availabel and can carry out";
            }
            else
            {
                return "Out of order";
            }
        }
        
        



    }  
}

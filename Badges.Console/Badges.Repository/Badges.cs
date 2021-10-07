using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesRepository
{
    public class Badges
    {

        public Badges() { }

        public Badges(string badgeID)
        {
            BadgeID = badgeID;
                     
        }
        public string BadgeID { get; set; }

        public List<string> ListOfDoorNames { get; set; } = new List<string>();


            
    }
}


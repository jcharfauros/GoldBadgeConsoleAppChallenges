using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadges_Repository
{    
    public class BadgeContent
    {
        public int BadgeID { get; set; }
        public List<string> DoorName { get; set; }               
        public string BadgeName { get; set; }               

        public BadgeContent() { }

        public BadgeContent(int badgeID, List<string> doorName, string badgeName)
        {
            BadgeID = badgeID;
            DoorName = doorName;
            BadgeName = badgeName;
        }
    }
}

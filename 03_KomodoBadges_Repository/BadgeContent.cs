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
        public List<string> AccessToDoor { get; set; }               
        public string BadgeName { get; set; }

        //i want to show a if a badge has door access
        //public bool HasDoorAccess { get; set; }

        public BadgeContent() { }

        public BadgeContent(int badgeID, List<string> accessToDoor, string badgeName)
        {
            BadgeID = badgeID;
            AccessToDoor = accessToDoor;
            BadgeName = badgeName;
        }
    }
}

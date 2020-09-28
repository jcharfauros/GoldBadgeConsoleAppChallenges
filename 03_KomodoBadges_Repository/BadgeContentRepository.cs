using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadges_Repository
{
    public class BadgeContentRepository
    {
        //found dictionary examples on microsoft, geeksforgeeks, stackoverflow,
        //but i don't understand it. ASK SOMEONE or more googling. 
        public Dictionary<int, string> _listOfBadges = new Dictionary<int, string>();
        // CREATE NEW BADGE
        // does not like the .Add, error wants (int key, string value)
        public void AddBadgeToList(BadgeContent badge)
        {
            _listOfBadges.Add(badge.BadgeID, badge.BadgeName);
                            //WHY, i want to add badge has access
            //_listOfBadges.Add(badge.AccessToDoor);            
        }
        // READ/SHOW --show list of all badge and door access
        public Dictionary<int, string> GetBadgeList()
        {
            return _listOfBadges;
        }
        // UPDATE doors on badge
        public void DoorAccess(int badgeID, string accessToDoor)
        {
            //how to put in dictionary list?
            List<string> doorAccess = _listOfBadges;
                doorAccess.Add(accessToDoor);
        }
        // DELETE all doors on existing badge
        // do i need to add bool like in other projects?
        public void RemoveDoorFromBadge(int badgeID, string accessToDoor)
        {
            //how to put in dictionary list?
            List<string> doorAccess = _listOfBadges;
                doorAccess.Remove(accessToDoor);
        }
    }
}

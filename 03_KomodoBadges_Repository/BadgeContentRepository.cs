using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadges_Repository
{
    public class BadgeContentRepository
    {
        public Dictionary<int, BadgeContent> _badgeList = new Dictionary<int, BadgeContent>();

        public List<BadgeContent> GetBadgeList()
        {
            var badgeList = _badgeList.Values.ToList();
            return badgeList;

        }
        // CREATE NEW BADGE
        public void CreateBadge(int badgeID, List<string> doorName, string badgeName)
        {
            BadgeContent newBadge = new BadgeContent(badgeID, doorName, badgeName);
            _badgeList.Add(newBadge.BadgeID, newBadge);
        }

        // UPDATE doors on badge
        public void UpdateAccess(int badgeUpdate, BadgeContent badgeUpdated)
        {
            BadgeContent updateBadge = GetBadgeID(badgeUpdate);
            updateBadge.DoorName = badgeUpdated.DoorName;
        }

        // DELETE all doors on existing badge        
        public void deleteaccess(int deleteBadge)
        {
            BadgeContent badgeDelete = GetBadgeID(deleteBadge);
            if (badgeDelete.BadgeID == deleteBadge)
            {
                badgeDelete.DoorName = new List<string>() { };
            }
            else
            {
                Console.WriteLine("There is no badge with that ID.");
            }
        }

        //helper
        private BadgeContent GetBadgeID(int badge)
        {
            BadgeContent badge1;
            if (_badgeList.ContainsKey(badge))
            {
                badge1 = _badgeList[badge];
                return badge1;
            }
            else
            {
                return null;
            }
        }

    }
}

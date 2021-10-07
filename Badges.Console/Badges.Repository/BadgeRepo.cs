using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesRepository
{
    public class BadgesRepo
    {
        List<Badges>ListOfDoorNames = new List<Badges>();
        public readonly List<Badges> _contentDirectory = new List<Badges>();

        public bool AddContentToDirectory(Badges badge)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(badge);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public List<Badges> GetContents()
        {
            return _contentDirectory;
        }

        public Badges GetByBadgeID(string BadgeID)
        {
            foreach (Badges badge in _contentDirectory)
            {
                if (badge.BadgeID.ToLower() == BadgeID.ToLower())
                {
                    return badge;
                }
            }
            return null;
        }
    }
}


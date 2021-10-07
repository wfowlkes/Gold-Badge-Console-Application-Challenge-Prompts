using ChallengeTwoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoRepository
{
    public class ClaimRepository : Claims
    {
        public readonly List<Claims> _contentDirectory = new List<Claims>();

        public bool AddContentToDirectory(Claims claim)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(claim);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public List<Claims> GetContents()
        {
            return _contentDirectory;
        }

        public Claims GetByClaimID(string ClaimID)
        {
            foreach (Claims claims in _contentDirectory)
            {
               if (claims.ClaimID.ToLower() == ClaimID.ToLower())
                {
                    return claims;
                }
            }
            return null;



        }
    }
}

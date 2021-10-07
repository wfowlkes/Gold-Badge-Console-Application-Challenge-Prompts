using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoRepository
{
    public class Claims
    {
        public enum ClaimType
        {
            Car = 1,
            Home,
            Theft
        }
        public Claims() { }

        public Claims(string claimID, ClaimType typeOfClaim, string description, string claimAmount, string dateOfIncident, string dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            TypeOfClaim = typeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
        public string ClaimID { get; set; }

        public ClaimType TypeOfClaim{ get; set; }

        public string Description { get; set; }

        public string ClaimAmount { get; set; }

        public string DateOfIncident { get; set; }

        public string DateOfClaim { get; set; }

        public bool IsValid { get; set; }

      

                }
            }
        

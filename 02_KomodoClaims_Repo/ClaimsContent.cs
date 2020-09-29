using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims_Repo
{
    public enum ClaimType
    {
        Car = 1,
        Home,
        Theft
    }
    public class ClaimsContent
    {
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfAccident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsVaild { get; set; }

        public ClaimsContent() { }

        public ClaimsContent(int claimID, ClaimType claimType, string description,
            double claimAmount, DateTime dateOfAccident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfClaim;
            IsVaild = isValid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims_Repo
{
    public class ClaimsRepository
    {
        private Queue<ClaimsContent> _listOfClaimsInQue = new Queue<ClaimsContent>();

        // create new claim
        public void EnterANewClaim(ClaimsContent newClaim)
        {
            _listOfClaimsInQue.Enqueue(newClaim);
        }

        // read/view claims
        public Queue<ClaimsContent> ReturnAllClaims()
        {
            return _listOfClaimsInQue;
        }

        // take care of next
        public ClaimsContent NextClaim()
        {
            ClaimsContent nextClaim = _listOfClaimsInQue.Peek();
            Console.WriteLine("\n\nHere are the details for the next claim to be handled:\n\n");
            Console.WriteLine($"ClaimID: {nextClaim.ClaimID}\n");
            Console.WriteLine($"Type: {nextClaim.ClaimType}\n");
            Console.WriteLine($"Description: {nextClaim.Description}\n");
            Console.WriteLine($"Amount: {nextClaim.ClaimAmount}\n");
            Console.WriteLine($"DateOfAccident: {nextClaim.DateOfAccident}\n");
            Console.WriteLine($"DateOfClaim: {nextClaim.DateOfClaim}\n");
            Console.WriteLine($"IsValid: {nextClaim.IsVaild}");
            return nextClaim;
        }

        //remove the topmost element of the queue
        public void NextInQueue()
        {
            _listOfClaimsInQue.Dequeue();
        }
    }
}

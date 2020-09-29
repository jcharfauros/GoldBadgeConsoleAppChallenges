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
                               
        // view claims
        public Queue<ClaimsContent> ReturnAllClaims()
        {
            return _listOfClaimsInQue;
        }

        // take care of next

        // create new claim
        public void EnterANewClaim(ClaimsContent newClaim)
        {
            _listOfClaimsInQue.Enqueue(newClaim);
        }
    } 
}

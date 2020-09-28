using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims_Repo
{
    public class ClaimsRepository
    {
        //private Queue<ClaimsContent> _listOfClaimsInQue = new Queue<ClaimsContent>();
        
        private List<ClaimsContent> _listOfClaimsContent = new List<ClaimsContent>();

        //Get the list of call the claims
        public void AddClaimsToList(ClaimsContent content)
        {
            _listOfClaimsContent.Add(content);
        }
        
        //Queue list
        //public Queue<ClaimsContent> ReturnAllClaims()
        //{
        //    return _listOfClaimsInQue;
        //}
        
        public List<ClaimsContent> Returnallclaims()
        {
            return _listOfClaimsContent;
        }



        //Take care of the next claim
        //NextClaim


        //Create a new claim
        //EnterANewClaim
    }
}

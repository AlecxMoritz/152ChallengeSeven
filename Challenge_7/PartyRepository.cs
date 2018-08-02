using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7
{
    class PartyRepository
    {
        private List<Party> _partyRepo = new List<Party>();

        // add party
        public void AddParty(Party party)
        {
            _partyRepo.Add(party);
        }

        // remove party
        public void RemovePartyByID(int id)
        {
            int Index = 0;

            foreach(Party party in _partyRepo)
            {
                if(party.PartyID == id)
                {
                    Index = _partyRepo.IndexOf(party);
                }
            }
            _partyRepo.RemoveAt(Index);
        }

        // get parties
        public List<Party> GetPartyList()
        {
            return _partyRepo;
        }

        public int Count()
        {
            return _partyRepo.Count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7
{
    public class Party
    {
        private List<Burger> _burgerList = new List<Burger>();
        private List<Treat> _treatList = new List<Treat>();

        public int PartyID { get; set; }
        public string Location { get; set; }
        public string Purpose { get; set; }

        public Party()
        {
            
        }

        public Party(int partyID, string partyLocation, string partyPurpose)
        {
            PartyID = partyID;
            Location = partyLocation;
            Purpose = partyPurpose;
        }

        /// add treat
        public void AddTreat(Treat treat)
        {
            _treatList.Add(treat);
        }

        ///count total treat cost
        public decimal GetTotalTreatCost()
        {
            decimal sum = 0;

            foreach (Treat treat in _treatList)
            {
                sum += treat.MainCost + treat.MiscCost;
            }

            return sum;
        }

        ///count main treat cost
        public decimal GetMainTreatCost()
        {
            decimal sum = 0;

            foreach(Treat treat in _treatList)
            {
                sum += treat.MainCost;
            }
            return sum;
        }

        /// count misc treat cost
        public decimal GetMiscTreatCost()
        {
            decimal sum = 0;

            foreach (Treat treat in _treatList)
            {
                sum += treat.MiscCost;
            }

            return sum;
        }

        /// add burger
        public void AddBurger(Burger burger)
        {
            _burgerList.Add(burger);
        }

        /// count main burger cost
        public decimal GetMainBurgerCost()
        {
            decimal sum = 0;

            foreach (Burger burger in _burgerList)
            {
                sum += burger.MainCost;
            }

            return sum;
        }

        /// count misc burger cost
        public decimal GetMiscBurgerCost()
        {
            decimal sum = 0;

            foreach (Burger burger in _burgerList)
            {
                sum += burger.MiscCost;
            }

            return sum;
        }

        /// count total burger cost
        public decimal GetTotalBurgerCost()
        {
            decimal sum = 0;

            foreach (Burger burger in _burgerList)
            {
                sum += burger.MainCost + burger.MiscCost;
            }

            return sum;
        }

        // count total cost both
        public decimal TotalCostBoth()
        {
            decimal sum = 0;
            foreach(Treat treat in _treatList)
            {
                sum += treat.MainCost + treat.MiscCost;
            }

            foreach(Burger burger in _burgerList)
            {
                sum += burger.MainCost + burger.MiscCost;
            }

            return sum;
        }

        // count main cost both
        public decimal MainCostBoth()
        {
            decimal sum = 0;
            foreach (Treat treat in _treatList)
            {
                sum += treat.MainCost;
            }

            foreach (Burger burger in _burgerList)
            {
                sum += burger.MainCost;
            }

            return sum;
        }
        // count misc cost both
        public decimal MiscCostBoth()
        {
            decimal sum = 0;
            foreach (Treat treat in _treatList)
            {
                sum += treat.MiscCost;
            }

            foreach (Burger burger in _burgerList)
            {
                sum += burger.MiscCost;
            }

            return sum;
        }

        // count total count of both lists
        public int CountTicketsUsed()
        {
            return _treatList.Count + _burgerList.Count;
        }

        /// count number of treats
        public int CountTreatTickets()
        {
            return _treatList.Count;
        }

        /// count number of burgers
        public int CountBurgerTickets()
        {
            return _burgerList.Count;
        }
    }
}

using System;
using Challenge_7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_7_Tests
{
    [TestClass]
    public class PartyTests
    {

        [TestMethod]
        public void Party_MainCost_ReturnMainCostAsDecimal()
        {
            Treat treat = new Treat(TreatType.Popcorn, 1.25m, .50m);
            Burger burger = new Burger(BurgerType.Hamburger, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddBurger(burger);
            partyRepo.AddTreat(treat);

            decimal Expected = 2.50m;
            decimal Actual = partyRepo.MainCostBoth();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Party_MiscCost_ReturnMiscCostAsDecimal()
        {

            Treat treat = new Treat(TreatType.Popcorn, 1.25m, .50m);
            Burger burger = new Burger(BurgerType.Hamburger, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddBurger(burger);
            partyRepo.AddTreat(treat);

            decimal Expected = 1.00m;
            decimal Actual = partyRepo.MiscCostBoth();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Party_TotalCost_ReturnTotalCostAsDecimal()
        {
            Treat treat = new Treat(TreatType.Popcorn, 1.25m, .50m);
            Burger burger = new Burger(BurgerType.Hamburger, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddBurger(burger);
            partyRepo.AddTreat(treat);

            decimal Expected = 3.50m;
            decimal Actual = partyRepo.TotalCostBoth();

            Assert.AreEqual(Expected, Actual);
        }
    }
}

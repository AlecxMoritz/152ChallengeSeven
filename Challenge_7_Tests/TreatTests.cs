using System;
using Challenge_7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_7_Tests
{
    [TestClass]
    public class TreatTests
    {
        [TestMethod]
        public void Treat_AddTreat_CountIncreases()
        {
            Treat treat = new Treat(TreatType.Popcorn, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddTreat(treat);

            int Expected = 1;
            int Actual = partyRepo.CountTreatTickets();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Treat_GetMainCost_ReturnMainCostAsDecimal()
        {
            Treat treat = new Treat(TreatType.Popcorn, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddTreat(treat);

            decimal Expected = 1.25m;
            decimal Actual = partyRepo.GetMainTreatCost();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Treat_GetMiscCost_ReturnMiscCostAsDecimal()
        {
            Treat treat = new Treat(TreatType.Popcorn, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddTreat(treat);

            decimal Expected = .50m;
            decimal Actual = partyRepo.GetMiscTreatCost();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Treat_GetTotalCost_ReturnTotalCostAsDecimal()
        {
            Treat treat = new Treat(TreatType.Popcorn, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddTreat(treat);

            decimal Expected = 1.75m;
            decimal Actual = partyRepo.GetTotalTreatCost();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Treat_GetTotalTickets_ShouldReturnTotalAsInt()
        {
            Treat treat = new Treat(TreatType.Popcorn, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddTreat(treat);

            int Expected = 1;
            int Actual = partyRepo.CountTreatTickets();

            Assert.AreEqual(Expected, Actual);
        }
    }
}

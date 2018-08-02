using System;
using Challenge_7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_7_Tests
{
    [TestClass]
    public class BurgerTests
    {
        [TestMethod]
        public void Burger_AddBurger_CountIncreases()
        {
            Burger burger = new Burger(BurgerType.Hamburger, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddBurger(burger);

            int Expected = 1;
            int Actual = partyRepo.CountBurgerTickets();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Burger_GetMainCost_ReturnMainCostAsDecimal()
        {
            Burger burger = new Burger(BurgerType.Hamburger, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddBurger(burger);

            decimal Expected = 1.25m;
            decimal Actual = partyRepo.GetMainBurgerCost();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Burger_GetMiscCost_ReturnMiscCostAsDecimal()
        {
            Burger burger = new Burger(BurgerType.Hamburger, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddBurger(burger);

            decimal Expected = .50m;
            decimal Actual = partyRepo.GetMiscBurgerCost();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Burger_GetTotalCost_ReturnTotalCostAsDecimal()
        {
            Burger burger = new Burger(BurgerType.Hamburger, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddBurger(burger);

            decimal Expected = 1.75m;
            decimal Actual = partyRepo.GetTotalBurgerCost();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Burger_GetTotalTickets_ShouldReturnTotalAsInt()
        {
            Burger burger = new Burger(BurgerType.Hamburger, 1.25m, .50m);
            Party partyRepo = new Party();
            partyRepo.AddBurger(burger);

            int Expected = 1;
            int Actual = partyRepo.CountBurgerTickets();

            Assert.AreEqual(Expected, Actual);
        }

    }
}

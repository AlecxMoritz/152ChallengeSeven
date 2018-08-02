using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7
{
    class ProgramUI
    {
        private Party _seededParty = new Party();
        private PartyRepository _partyRepo = new PartyRepository();

        public void Run()
        {
            SeedData();
            RunStartMenu();
        }


        // stuff




        private void RunStartMenu()
        {
            Console.WriteLine("Welcome to Komodo Barbeque Ticket Manager");
            bool AppRunning = true;

            while (AppRunning)
            {
                Console.Clear();
                ShowStartMenu();
                int choice = GetMenuChoice();

                switch (choice)
                {
                    case 1:
                        ListParties();
                        break;

                    case 2:
                        LogPartyInfo();
                        break;

                    case 3:
                        DeleteParty();
                        break;

                    case 4:
                        AppRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid entry.");
                        break;
                }
                if(!AppRunning)
                {
                    break;
                }
            }

        }



        private void ShowStartMenu()
        {
            Console.WriteLine("What would you like to do?\n" +
                                "1. View Parties\n" +
                                "2. Enter Barbeque information\n" +
                                "3. Remove Barbeque\n" +
                                "4. Quit");
        }


        public void SeedData()
        {
            _seededParty.PartyID = 1;
            _seededParty.Location = "Cool Creek Park";
            _seededParty.Purpose = "Friends and Family Day";

            Burger burger = new Burger(BurgerType.Hamburger, 1.50m, .50m);
            Burger hotdog = new Burger(BurgerType.HotDog, 1.50m, .50m);
            Burger veggieBurger = new Burger(BurgerType.VeggieBurger, 1.50m, .50m);

            Treat icecream = new Treat(TreatType.IceCream, .75m, .25m);
            Treat popcorn = new Treat(TreatType.Popcorn, .25m, .10m);

            for(int i = 0; i <= 5; i++)
            {
                _seededParty.AddBurger(burger);
                _seededParty.AddBurger(hotdog);
                _seededParty.AddBurger(veggieBurger);
                _seededParty.AddTreat(icecream);
                _seededParty.AddTreat(popcorn);
            }
            _partyRepo.AddParty(_seededParty);
        }

       private int GetMenuChoice()
        {
            Console.Write("Please enter a choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public void ListParties()
        {
            Console.Clear();
            List<Party> displayList = _partyRepo.GetPartyList();
            foreach(Party party in displayList)
            {
                Console.WriteLine($"{party.PartyID} || {party.Location} ||{party.Purpose}\n" +
                    $"Total Costs:\n" +
                    $"Total Cost:{party.TotalCostBoth()} || Total Food Product Cost: {party.MainCostBoth()} || Total Misc. Cost: {party.MiscCostBoth()}\n\n" +
                    $"Food Costs:\n" +
                    $"Total Cost: {party.MainCostBoth()} || Total Burger Booth: {party.GetMainBurgerCost()} || Total Treat Booth: {party.GetMainTreatCost()}\n\n" +
                    $"Misc. Costs:\n" +
                    $"Total Cost: {party.MiscCostBoth()} || Total Burger Booth: {party.GetMiscBurgerCost()} || Total Treat Booth: {party.GetMiscTreatCost()}\n\n");
            }
            Console.ReadLine();
        }

        public void LogPartyInfo()
        {
            Console.Clear();
            Console.WriteLine("Enter the party ID number");
            int partyID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the party location");
            string partyLocation = Console.ReadLine();

            Console.WriteLine("Please enter the party purpose");
            string partyPurpose = Console.ReadLine();

            Party newParty = new Party(partyID, partyLocation, partyPurpose);

            Console.WriteLine("How many hot dogs were sold?");
            int dogNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the cost of the hot dog, bun included? Ex: 1.20");
            decimal dogMainPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is the misc. cost of the hot dog?");
            decimal dogMiscPrice = Convert.ToDecimal(Console.ReadLine());
            Burger hotdog = new Burger(BurgerType.HotDog, dogMainPrice, dogMiscPrice);
            AddBurgersToParty(newParty, hotdog, dogNum);

            Console.WriteLine("How many hamburgers were sold?");
            int hamNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the cost of the hamburger, bun included? Ex: 1.20");
            decimal hamMainPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is the misc. cost of the hamburger?");
            decimal hamMiscPrice = Convert.ToDecimal(Console.ReadLine());
            Burger hamburger = new Burger(BurgerType.Hamburger, hamMainPrice, hamMiscPrice);
            AddBurgersToParty(newParty, hamburger, hamNum);

            Console.WriteLine("How many veggie burgers were sold?");
            int vegNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the cost of the veggie burger, bun included? Ex: 1.20");
            decimal vegMainPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is the misc. cost of the veggie burger?");
            decimal vegMiscPrice = Convert.ToDecimal(Console.ReadLine());
            Burger veggieburger = new Burger(BurgerType.VeggieBurger, vegMainPrice, vegMiscPrice);
            AddBurgersToParty(newParty, veggieburger, hamNum);

            Console.WriteLine("How many gallons of ice cream were sold?");
            int iceNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the cost of the ice cream? Ex: 1.20");
            decimal iceMainPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is the misc. cost of the ice cream?");
            decimal iceMiscPrice = Convert.ToDecimal(Console.ReadLine());
            Treat icecream = new Treat(TreatType.IceCream, iceMainPrice, iceMiscPrice);
            AddTreatsToParty(newParty, icecream, iceNum);

            Console.WriteLine("How many bags of popcorn were sold?");
            int popNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the cost of the popcorn itself per bag? Ex: 1.20");
            decimal popMainPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is the misc. cost of the popcorn?");
            decimal popMiscPrice = Convert.ToDecimal(Console.ReadLine());
            Treat popcorn = new Treat(TreatType.Popcorn, popMainPrice, popMiscPrice);
            AddTreatsToParty(newParty, popcorn, popNum);

            _partyRepo.AddParty(newParty);
            Console.WriteLine("Party Added -- Burgers and Treats recorded.");
        }

        public void DeleteParty()
        {
            Console.Clear();
            Console.Write("Enter the ID of the party you would like to remove: ");
            int deleteTarget = Convert.ToInt32(Console.ReadLine());
            try
            {
                _partyRepo.RemovePartyByID(deleteTarget);
                Console.WriteLine("Party deleted.");
            }
            catch (Exception)
            {
                Console.WriteLine("Party by this ID does not exist");
            }
            Console.ReadLine();
        }

        public void AddBurgersToParty(Party party, Burger burger, int counter)
        {
            for(int i = 0; i < counter; i++)
            {
                party.AddBurger(burger);
            }
        }

        public void AddTreatsToParty(Party party, Treat treat, int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                party.AddTreat(treat);
            }
        }
    }
}

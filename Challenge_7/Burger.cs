using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7
{
    public enum BurgerType
    {
        HotDog = 1,
        Hamburger,
        VeggieBurger
    }

    public class Burger
    {
        public BurgerType TypeOfBurger { get; set; }
        public decimal MainCost { get; set; }
        public decimal MiscCost { get; set; }

        public Burger(BurgerType type, decimal mainCost, decimal miscCost)
        {
            TypeOfBurger = type;
            MainCost = mainCost;
            MiscCost = miscCost;
        }
    }
}
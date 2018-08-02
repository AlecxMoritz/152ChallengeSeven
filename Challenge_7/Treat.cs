using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7
{
    public enum TreatType
    {
        IceCream = 1,
        Popcorn
    }

    public class Treat
    {
        public TreatType TypeOfTreat { get; set; }
        public decimal MainCost { get; set; }
        public decimal MiscCost { get; set; }

        public Treat(TreatType type, decimal mainCost, decimal miscCost)
        {
            TypeOfTreat = type;
            MainCost = mainCost;
            MiscCost = miscCost;
        }
    }
}

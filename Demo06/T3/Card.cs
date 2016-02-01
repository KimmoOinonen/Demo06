using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Card
    {
        public string Land { get; set; }
        public int CardNumber { get; set; }
        public string CardName { get; set; }

        public override string ToString()
        {
            return "Card Land: " + Land + " Card number: " + CardNumber + " Card name: " + CardName;
        }
    }
}

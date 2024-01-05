using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTommyUke7
{
    public class ElectronicItem : InventoryItem, ISellable
    {
        public string Forsikring { get; set; }

        public string Spenning { get; set; }

        public ElectronicItem(string navn, int antall, double pris, string forsikring, string spenning) : base(navn, antall, pris)
        {
            Forsikring = forsikring;
            Spenning = spenning;
        }
        public double PrisKalkulasjon()
        {
            var antall = Antall;
            var pris = Pris;
            var totalPris = antall * pris;
            Console.WriteLine($"TotalPris: {totalPris:C},-");
            return Antall * Pris;
        }
    }
}

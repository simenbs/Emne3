using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PPTommyUke7
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        public string Størrelse { get; set; }

        public string Farge { get; set; }



        public ClothingItem(string størrelse, string farge,string navn, int antall, double pris) : base(navn, antall, pris)
        {
           Størrelse = størrelse;
           Farge = farge;
        }

        public double PrisKalkulasjon()
        {
            var antall = Antall;
            var pris = Pris;
            var totalPris = antall * pris;
            Console.WriteLine($"TotalPris: {totalPris:C},-");
            return Antall * Pris;

        }

        public override void PrintItems()
        {
            base.PrintItems();
        }
    }
}

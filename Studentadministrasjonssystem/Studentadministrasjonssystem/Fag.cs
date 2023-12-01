using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    public class Fag
    {
        public string Fagkode { get; set; }
        public string Fagnavn { get; set; }
        public int AntallStudiepoeng { get; set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fagkode: {Fagkode}, Fagnavn: {Fagnavn}, Studiepoeng: {AntallStudiepoeng}");
        }

    }
}

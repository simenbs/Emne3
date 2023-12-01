using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    public class Karakter
    {  
        public Student Student { get; set; }
        public Fag Fag { get; set; }
        public int Karakterverdi { get; set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {Student.Navn}, Fag: {Fag.Fagnavn},Karakterverdi: {Karakterverdi}");
        }
    }
}

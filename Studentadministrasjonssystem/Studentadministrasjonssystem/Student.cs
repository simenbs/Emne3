using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    public class Student
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public string Studieprogram { get; set; }
        public int StudentID { get; set; }
        public List<Fag> FagListe { get; set; }


        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {Navn}, Alder: {Alder}, Studie: {Studieprogram}, StudentID: {StudentID}, Fagliste: {FagListe},");
        }

    }
}

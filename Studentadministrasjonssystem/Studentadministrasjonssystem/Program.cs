namespace Studentadministrasjonssystem
{
    public class Program
    {
        public static void Main(string[] args)
        {

 
            // Her oppretter jeg 2 nye studentobjekter
            Student student1 = new Student { Navn = "Simen", Alder = 32, Studieprogram = "Programmering", StudentID = 123 };
            Student student2 = new Student { Navn = "Jon", Alder = 52, Studieprogram = "NK", StudentID = 78 };

            // Her kaller vi på studentinformasjonen som er lagt til i objekter
            student1.SkrivUtInfo();
            student2.SkrivUtInfo();

            // Oprettelse av fagobjekter

            Fag fag1 = new Fag { Fagkode = "ABC10011",Fagnavn = "Javascript",  AntallStudiepoeng = 15, };
            Fag fag2 = new Fag { Fagkode = "ABC10099",Fagnavn = "cSharp",  AntallStudiepoeng = 30, };

            // Lager en liste av 3 nye fag
            List<Fag> fagListe = new List<Fag>
            {
                new Fag { Fagkode = "CSS2043", Fagnavn = "CSS", AntallStudiepoeng = 10 },
                new Fag { Fagkode = "PN2088", Fagnavn = "Python", AntallStudiepoeng = 15 },
                new Fag { Fagkode = "HTML1999", Fagnavn = "HTML", AntallStudiepoeng = 20 },

            };

            // Legger til fagene i Student-objektene
            student1.FagListe = new List<Fag> { fag1, fagListe[0] };
            student2.FagListe = new List<Fag> { fag2, fagListe[1], fagListe[2] };



            fag1.SkrivUtInfo();
            fag2.SkrivUtInfo();

            // Oprette karakterobjektene

            Karakter Godkjent = new Karakter { Student = student1, Fag = fag1, Karakterverdi = 6 };
            Karakter Stryk = new Karakter { Student = student2, Fag = fag2, Karakterverdi = 1 };

            Godkjent.SkrivUtInfo();
            Stryk.SkrivUtInfo();
        }
    }
}
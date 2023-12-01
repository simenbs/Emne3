using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplantasjon2
{
    class Person
    {
        public string Navn { get; set; }
        public string HelseStatus { get; set; }

        public Person(string navn, string helsestatus)
        {
            Navn = navn;
            HelseStatus = helsestatus;
        }

        public void NyreSjekk(Organ organ)
        {

            Random rng = new Random();
            int sjangse = rng.Next(100);


            // legger til en usikkerhet ved at transplantasjonen faktisk blir vellykket.
            //så jeg har gitt den 80/20 for å være vellykket slik at 

            if (organ.Type == "Nyre" && organ.HelseStatus == "Frisk" && sjangse < 80)
            {
                Console.WriteLine($"{Navn} Har fått en ny nye av {organ.DonorNavn} Og transplantasjonen var vellykket!");
                HelseStatus = "Frisk";
            }
            else
            {
                Console.WriteLine($"{Navn}, vi beklager, men transplantasjonen var ikke vellykket. {Navn} trenger fortsatt nyre");
            }
        }
    }
}

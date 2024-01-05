using System.Threading.Channels;

namespace PPTommyUke7
{
    public class Program
    {
        static void Main(string[] args)
        {
            var clothingItem = new ClothingItem("XL", "Brun", "Bukse", 8, 499);
            var clothingItem1 = new ClothingItem("XL", "Gul", "Genser", 8, 499);

            var electronicItem = new ElectronicItem("Fryser", 4, 3599, "Skadeforsikring 12mnd", "240v");



            clothingItem.PrintItems();

            clothingItem.PrisKalkulasjon();
            Console.ReadKey();
            Console.Clear();
            electronicItem.PrintItems();

            electronicItem.PrisKalkulasjon();
            Console.ReadKey();


        }
       
    }
}
//Lag en base klasse som heter “InventoryItem” hvor du har info om itemets navn, antall og pris.
//Lag to klasser til, ClothingItem og ElectronicItem. Disse skal ha informasjon om størrelse og farge f.eks på klær og f.eks forsikringsinformasjon og spenning på det elektriske.
//La disse klassene arve av baseklassen, slik at de også får bruke navn, antall og pris.


//Lag et interface ISellable som har en funksjon som kalkulerer pris.
//Implementer dette interfacet i ClothingItem og ElectronicItem


//Lag noen forskjellige items for å sjekke at det fungerer som tenkt.
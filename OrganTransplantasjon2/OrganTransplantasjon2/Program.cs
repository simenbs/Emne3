namespace OrganTransplantasjon2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person bernt = new Person("Bernt", "Ufrisk");
            Person kåre = new Person("Kåre", "Frisk");
            Organ kåreNyre = new Organ("Nyre", "Frisk", "Kåre");

            Console.WriteLine($"{bernt.Navn}'s helsestatus før transplantasjon: {bernt.HelseStatus}");
            bernt.NyreSjekk(kåreNyre);
            
            Console.WriteLine($"{bernt.Navn}'s helsestatus etter transplantasjon: {bernt.HelseStatus}");
        }
    }
}
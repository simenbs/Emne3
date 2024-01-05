namespace konvertering
{
    internal class Program
    {
        static void Main(string[] args)
        //En konsollapp hvor brukeren skal kunne konvertere mellom Celsius og Fahrenheit.
        // Programmet skal be brukeren først velge om h*n vil konvertere fra C til F eller fra F til C.
        // Deretter taste inn gradetallet, og få opp hva dette tallet er konvertert.
        // Formlene:
        // Temperature in degrees Fahrenheit (°F) = (Temperature in degrees Celsius (°C) * 9/5) + 32
        // Temperature in degrees Celsius (°C) = (Temperature in degrees Fahrenheit (°F) - 32) * 5/9
        {
            Console.WriteLine("Velg konverteringsmetode");
            Console.WriteLine("1. celcsi til fahren");
            Console.WriteLine("2. fahren til celsi");
            string choice = Console.ReadLine();
            Console.WriteLine("skriv temp som konverteres");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (choice == "1")
            {
                double fahren = (temp * 9 / 5 + 32);
                Console.WriteLine("tempen i konvertert til fahrenheit er : " +  fahren);
            }
            else if (choice == "2")
            {
                double celci = (temp - 32) * 5 / 9;
                Console.WriteLine("tempen konva til celci blir : " + celci);
            }
            else
            {
                Console.WriteLine("ugyldig");
            }
        }
    }
}
namespace BossFight1
{
    internal class Program
    {
        //dette programmet simulerer en kamp mellom en helt og en boss, men siden bossen har mye mer verdier
        //vil det være veldig liten sjangs for at bossen kan vinne jomindre helse justeres
        static void Main(string[] args)
        {
            //lager en helt og en boss fra gamecharacter klassen
            GameCharacter hero = new GameCharacter(100, 20, 40);
            GameCharacter boss = new GameCharacter(400, 20, 10);

            //selve kampen som er satt til å fortsette helt til noen ikke har mer helse
            while (hero.Health > 0 && boss.Health > 0)
            {
                //hvem som angriper, samtidig som det blir logget til konsollen
                hero.Fight(boss);
                Console.WriteLine($"Helten slo bossen for {hero.Strength} skade, bossen har nå {boss.Health} helse igjen");

                if (boss.Health <= 0)
                    break;

                boss.RandomStrenght();
                boss.Fight(hero);
                Console.WriteLine($"Bossen slo helten for {boss.Strength} skade, helten har nå {hero.Health} helse igjen");
            }

            //hvem som vant kampen
            if (hero.Health > 0)

                Console.WriteLine("Helten vinner kampen");
            else
                Console.WriteLine("Bossen vinner kampen");

        }
    }


}
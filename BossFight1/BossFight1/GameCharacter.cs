namespace BossFight1
{
    public class GameCharacter
    {
        // Gamecharacter klassen har 4 private variabler
        // initialstamina er nyttig for å når karakterene trenger å lade opp utholdenheten
        private int _health;

        private int _strength;

        private int _stamina;

        private int _initialStamina; // lage en initial helse verdi for å kunne bruke i recharge metode


        // Konstruktør for å initialisere verdiene når det blir opprettet.
        public GameCharacter(int health, int strength, int stamina)
        {
            _health = health;
            _strength = strength;
            _stamina = stamina;
            _initialStamina = stamina;
        }

        //Her gjør jeg de private variablene tilgjengelig
        public int Health { get { return _health; } }
        public int Strength { get { return _strength; } }

        public int Stamina { get { return _stamina; } }

        public void Fight(GameCharacter opponent)
        {
            //sjekker om karakteren har nok helse til å sloss
            if (_stamina <= 0)
            {
                // dersom den ikke har det vil den regenerere
                Recharge();
                return;
            }

            int damage = _strength; //for å legge til at skaden er lik strength
            opponent._health -= damage; //fjerne helse fra motstanderen per slag
            _stamina -= 10; //hver gang en karakter bruker fight metode mister den 10 helse

        }

        //metoden for å regenerere
        public void Recharge()
        {
            _stamina = _initialStamina;
        }

        public void RandomStrenght()
        {
            Random rnd = new Random();
            _strength = rnd.Next(0,31);
        }
        
    }
}

using System;
using System.Transactions;

namespace myProject
{
    class poke
    {
        private int _Id;
        private string _Pokemon;
        private string _Type;

        public poke()
        {
            _Id = 0;
            _Pokemon = "";
            _Type = "";
        }


        public poke(int i, string Pokemon, string Type)
        {
            _Id = i;
            _Pokemon = Pokemon;
            _Type = Type;
        }

        // GET FUNCTIONS VVVVV
        public string GetFullPoke()
        {
            return "Pokemon: " + _Pokemon + " - Type: " + _Type;
        }
        public int GetId()
        {
            return _Id;
        }
        public string GetTitle()
        {
            return _Pokemon;
        }
        public string GetType()
        {
            return _Type;
        }

        // SET FUNCTIONS VVVVVVV
        public void SetId(int identification)
        {
            _Id = identification;
        }
        public void SetPoke(string poke)
        {
            _Pokemon = poke;
        }
        public void SetType(string type)
        {
            _Type = type;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add your favorite pokemon! ");


            poke member30 = new poke();
            member30.SetId(30);
            member30.SetPoke("Blastoise");
            member30.SetType("Water");
            
            poke member10 = new poke(10, "Mew", "Psychic");

            poke member20 = new poke();
            Console.WriteLine("Enter an ID the pokemon: ");
            member20.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the name of the pokemon: ");
            member20.SetPoke(Console.ReadLine());
            Console.WriteLine("Enter the pokemon type (water, fire, etc.): ");
            member20.SetType(Console.ReadLine());

            Console.WriteLine("Enter an ID the pokemon: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the pokemon: ");
            string tempPoke = Console.ReadLine();
            Console.WriteLine("Enter the pokemon type (water, fire, etc.): ");
            string tempType = Console.ReadLine();
            poke member40 = new poke(tempID, tempPoke, tempType);

            Console.WriteLine();
            Console.WriteLine("Here's your favorite pokemon:");
            displayMembers(member10);
            displayMembers(member20);
            displayMembers(member30);
            displayMembers(member40);
        }
        static void displayMembers(poke member)
        {
            Console.WriteLine($"Poke ID: {member.GetId()}");
            Console.WriteLine(member.GetFullPoke());
            Console.WriteLine();
        }
    }
}

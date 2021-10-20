using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            Console.WriteLine($"{hero} will fight {villain}.");

            string heroWeapon = PickWeapon();
            string VillainWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villain} picked {VillainWeapon}");

        }

        private static string PickHero()
        {
            string[] superHeroes = { "Luke Skywalker", "Batman", "Spiderman", "Patric", "Lara croft" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);

            return superHeroes[randomIndex];
            
        }
        private static string PickVillain()
        {
            string[] Villains = { "Darth Vader", "Joker", "Voldemort", "T-9000", "Agent Smith" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Villains.Length);

            return Villains[randomIndex];
        }

        private static string PickWeapon()
        {
            string[] weapon = { "plastic fork", "banana", "frying pan", "purse", "Flip-flop" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, weapon.Length);

            return weapon[randomIndex];
        }

    }
}

using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            hero = RandomHero();
            villain = RandomVillain();
            Console.WriteLine($"Random hero: {hero} fights Random villain: {villain}.");
        }

        private static string RandomHero()
        {
            string[] heroes = { "Jako Hitler Jermolov", "Spongebob", "Spiderman", "Patrick", "Lara Croft", "Batman" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heroes.Length);

            string randomHero = heroes[randomIndex];
            return randomHero;
        }
        private static string RandomVillain()
        {
            string[] villains = { "xD", "Marko Moist", "neeger", "juut" };
            Random rnd = new Random();
            int randomindex = rnd.Next(0, villains.Length);

            return villains[randomindex];
        }
    }
}

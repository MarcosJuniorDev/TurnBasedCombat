

namespace ConsoleTurnBasedCombat.Entities
{
    internal class Enemy
    {
        public int Hp { get; set; } = 40;
        public Random Random { get; set; } = new Random();



        public int Dano()
        {
            int dano = Random.Next(1, 7);
            Console.WriteLine($"Enemy attacks player and deals {dano} damage!");
            return dano;

        }

        public int Heal()
        {
            int vida = Random.Next(3, 6);
            Console.WriteLine($"Enemy restores {vida} health points!");
            return vida;
        }
    }
}
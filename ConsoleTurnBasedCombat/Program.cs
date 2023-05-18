using ConsoleTurnBasedCombat.Entities;

namespace ConsoleTurnBasedCombat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy();

            while (player.Hp > 0 || enemy.Hp > 0)
            { 
                Console.WriteLine("-- PLAYER TURN --");
                Console.WriteLine($"Player HP: {player.Hp}. Enemy HP: {enemy.Hp}");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");
                char action = char.Parse(Console.ReadLine());
                if (action == 'a')
                {
                    enemy.Hp -= player.Dano();
                    if (enemy.Hp <= 0)
                    {
                        enemy.Hp = 0;
                        break;
                    }                    
                }
                else
                {
                    player.Hp += player.Heal();
                    if (player.Hp > 40) player.Hp = 40; 
                }                
                Console.WriteLine();
                Console.WriteLine("-- ENEMY TURN --");
                Console.WriteLine($"Player HP: {player.Hp}. Enemy HP: {enemy.Hp}");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");
                action = char.Parse(Console.ReadLine());
                if (action == 'a')
                {
                    player.Hp -= enemy.Dano();
                    if (player.Hp <= 0)
                    {
                        player.Hp = 0;
                        break;
                    }
                }
                else
                {
                    enemy.Hp += enemy.Heal();
                    if (enemy.Hp > 40) enemy.Hp = 40;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Player HP: {player.Hp}. Enemy HP: {enemy.Hp}");
            if (enemy.Hp == 0)
            {
                Console.WriteLine("GG you win!");
            }
            else
            {
                Console.WriteLine("WP you lose!");
            }

            


        }
    }
}
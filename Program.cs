using System.Reflection;

namespace Fighting 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Test code will run forever without further modification.
            // Look at the task in the file ExtraTask.md
            // =================================================================
            var player = new Player(100, 10);
            var ork = new Ork(200, 20, 10);
            bool playerIsDead = false;
            int turnNumber = 1;
            player.HasDied += number =>
            {
                Console.WriteLine(
                    $"Player died at turn {turnNumber} and the killing blow was {number} damage"
                    );
                playerIsDead = true;
            };
            while (!playerIsDead)
            {
                Console.WriteLine($"{turnNumber}. Turn");
                Fight(player, ork);
                turnNumber++;
            }
        }
        
        public static void Fight(IFight firstToStrike, IFight secondToStrike)
        {
            int damageFromFirst = firstToStrike.DealDamage();
            secondToStrike.TakeDamage(damageFromFirst);
            int damageFromSecond = secondToStrike.DealDamage();
            firstToStrike.TakeDamage(damageFromSecond);
            Console.WriteLine($"First: {firstToStrike}");
            Console.WriteLine($"Second: {secondToStrike}");
        }
    }
}
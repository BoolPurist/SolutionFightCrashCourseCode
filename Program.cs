namespace Fighting 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Player(100, 10);
            var turtle = new Turtle(25, 5, 5);
            var ork = new Ork(50, 10, 5);
            Fight(player, turtle);
            Fight(player, ork);
            Fight(player, ork);
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
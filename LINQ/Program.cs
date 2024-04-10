namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Super Mario 64",
                "Melee",
                "MegaMan",
                "Grill Yourself"
            };

            var orderedGames = videoGames.OrderBy(game => game.Length).ToList();

            Console.WriteLine("Ordered by name length");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}

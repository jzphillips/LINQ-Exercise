namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() {"God of War", "Assassin's Creed", "Call of Duty", "Bully"};
            var games = videoGames.OrderBy(g => g.Length);
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
        }
    }
}

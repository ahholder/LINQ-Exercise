namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>();
            //List<string> ordered = new List<string>();
            int tally = 0;
            //var games = args;
            games.Add("Darksiders");
            games.Add("Darksiders II");
            games.Add("Darksiders III");
            games.Add("Warcraft II");
            games.Add("Warcraft III");
            games.Add("Dota 2");
            games.Add("Starcraft");
            games.Add("Starcraft II");
            games.Add("Baulder's Gate");
            games.Add("Neverwinter Nights");
            //games.OrderBy(game => game.Length);
            //games.Sort();
            //for (var i = games.Max(); i >= 0; i++) 
            //games = games.OrderBy(game => game);
            Console.Write("Games: ");
            foreach (var gamer in games.OrderBy(game => game.Length))
            {
                tally += 1;
                if (tally != 1) Console.Write(", ");
                Console.Write(gamer);
                //Console.Write(gamer + gamer.Length);
            }
            /*Console.WriteLine("");
            Console.Write("Games Starting with 'D': ");
            foreach (var game in games.Where(start => start.ToUpper()[0] == 'D'))
            {
                tally += 1;
                if (tally != 1) Console.Write(", ");
                Console.Write(game);
            }*/
            //Console.WriteLine(games.Max());
        }
    }
}

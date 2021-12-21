using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameList = new List<string>() { "Call of Duty", "Madden", "Grand Theft Auto", "Mario Kart", "Star Fox", "FIFA", "Halo", "Mortal Kombat" };
            gameList.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}

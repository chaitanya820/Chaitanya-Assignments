using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    internal class Question__2
    { 
class Program
    {
        static void Main()
        {
            
            var participants = new List<(string Name, string Country)>
        {
            ("Player1", "USA"),
            ("Player2", "Canada"),
            ("Player3", "Mexico"),
            ("Player4", "USA"),
            ("Player5", "Canada"),
            ("Player6", "Mexico")
        };

            
            var halfSize = participants.Count / 2;
            var teamA = participants.Take(halfSize).ToList();
            var teamB = participants.Skip(halfSize).ToList();

            
            var matches = GenerateMatches(teamA, teamB);

           
            foreach (var match in matches)
            {
                Console.WriteLine($"Match: {match.Item1.Name} vs {match.Item2.Name}");
            }
        }

        static IEnumerable<(TItem1, TItem2)> GenerateMatches<TItem1, TItem2>(
            IEnumerable<TItem1> list1,
            IEnumerable<TItem2> list2)
        {
            return from item1 in list1
                   from item2 in list2
                   select (item1, item2);
        }
    }



}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {

        static void Main(string[] args)
        {

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var thSubstrings = words.Where(m => m.Contains("th"));

            foreach (var word in thSubstrings)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }



            ///////////////////////////////////////////////////////////////////////////////////

            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            var result = names.Distinct();
            foreach (string name in result)
            {
                Console.WriteLine(name);
                Console.ReadLine();
            }


            //////////////////////////////////////////////////

            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };


            var studentSplit = classGrades.Select(s => s.Split(',')).Select(s => s.Select(g => Int32.Parse(g)).ToArray());
            var studentOrder = studentSplit.Select(s => s.OrderBy(g => g).ToArray());
            var studentGradesLess = studentOrder.Select(s => s.Skip(1).ToArray());
            var studentGradeAverage = studentGradesLess.Select(s => s.Average(g => g)).ToArray();
            var classAverage = studentGradeAverage.Average(s => s);

            Console.WriteLine(classAverage);
            Console.ReadLine();





            /////////////////////////////////////////////////


            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            var inputFrequency = name.OrderBy(x => x).GroupBy(x => x).Select(x => x);
            foreach (var character in inputFrequency)
            {
                Console.WriteLine("" + character.Key + character.Count());

            }
            Console.ReadLine();










        }
    }
}




    








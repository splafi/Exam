using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            string[] command = Console.ReadLine().Split();


            while (!command[0].Equals("end"))
            {
                switch (command[0])
                {
                    case "reverse":
                        int start = int.Parse(command[2]);
                        int count = int.Parse(command[2]);
                        List<string> currList = input
                                            .Skip(start)
                                            .Take(count)
                                            .Reverse()
                                            .ToList();
                        input.RemoveRange(start, count);
                        input.InsertRange(start, currList);
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }

            string output =  string.Join(", ", input);
            Console.WriteLine($"[{output}]");
        }
    }
}

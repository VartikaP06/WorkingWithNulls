using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PlayerCharacter[] players = null;

            var p1 = players?[0]?.Name;
            var p2 = players?[1]?.Name;
            var p3 = players?[2]?.Name;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.ReadLine();
        }
    }
}

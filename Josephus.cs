using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Josephus
{
    class CalWinningPosition
    {
        static int josephus(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                return (josephus(n - 1, k)
                           + k - 1) % n + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of people");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 2;
            Console.WriteLine("The winning "
            + "position is " + josephus(n, k));
        }
    }
}

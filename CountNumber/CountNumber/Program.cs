using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class CountNumber
    {
        static void Main(string[] args)
        {
            string answer;
            int A = 0, B = 100;
            int count = 1;
            while (B > A + 1)
            {
                int c = (A + B) / 2;
                Console.Write("Q{0}: Does your number greater than {1}? ",
                count, c);
                count++;
                answer = Console.ReadLine();
                if (answer == "Y" || answer == "y")
                {
                    A = c + 1;
                }
                if (answer == "N" || answer == "n")
                {
                    B = c;
                }
            }
            Console.Write("Q{0}: Is your number {1}? ", count, A);
            answer = Console.ReadLine();
            if (answer == "Y")
                Console.WriteLine("{0} Is your number", A);
            if (answer == "N")
                Console.WriteLine("{0} Is your number", B);
        }
    }
}

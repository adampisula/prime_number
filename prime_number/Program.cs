using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(prime(num).ToString());
        }

        static bool prime(decimal a)
        {
            bool p = false;
            decimal n = 0;
            int x = 0;

            if (a % 2 != 0)
            {
                n = (a + 1) / 2;
            }
            else
            {
                return false;
            }

            for (int i = 2; i < n + 1; i++)
            {
                x = Convert.ToInt32(a % i);

                if (x == 0)
                {
                    p = false;
                    break;
                }
                else
                {
                    p = true;
                    continue;
                }
            }

            return p;
        }
    }
}

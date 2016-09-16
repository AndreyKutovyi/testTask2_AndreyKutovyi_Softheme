using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask2_AndreyKutovyi
{
    class Program
    {
        private static bool CheckSimple(int x)
        {
            for (int i = 2; i * i <= x; i++)
            {
                if ((x % i) == 0)
                return false;
            }
                return true;
        }

        static void Main(string[] args)
        {
            int n= 1000000;
            List<int> simpleNumber = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if (CheckSimple(i))
                {
                    simpleNumber.Add(i);
                }
            }
            
            foreach(int number in simpleNumber)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

        }
    }
}

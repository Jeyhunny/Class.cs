using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    internal class Factorial_Task
    {
        
        
            public int n;

            public void FactorialNumber(int n)
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }

                Console.WriteLine(result);
            }
        
    }
}

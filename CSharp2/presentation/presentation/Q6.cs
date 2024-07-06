using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    public class Q6
    {
        public void oddNumbers()
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.Write(i + " ");
                }
            }
        }
    }
}

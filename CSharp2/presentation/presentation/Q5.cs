using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    public class Q5
    {
        public void summation()
        {
            Console.WriteLine("Input three numbers separated by comma:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int sum = 0;
            foreach (string numStr in numbers)
            {
                sum += Convert.ToInt32(numStr.Trim()); 
            }
            Console.WriteLine($"The sum of three numbers: {sum}");
        }
    }
}

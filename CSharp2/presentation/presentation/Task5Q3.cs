using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    public class Task5Q3
    {
        int number;
        public Task5Q3(int num)
        {
            number = num;
        }
        public int fact()
        {
            int flag = 1;
            for (int i = 1; i <= number; i++)
            {
                flag = flag * i;
            }
            return flag;
        }
    }
}

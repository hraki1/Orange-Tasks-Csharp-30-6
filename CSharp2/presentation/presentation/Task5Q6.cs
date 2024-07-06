using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    public class Task5Q6
    {
        string year;
        string month;
        string day;
        public Task5Q6(string year, string month, string day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public void viewDate()
        {
            Console.WriteLine("Converted Date:");
            Console.WriteLine(year + "-" + month + "-" + day);
        }
    }
}

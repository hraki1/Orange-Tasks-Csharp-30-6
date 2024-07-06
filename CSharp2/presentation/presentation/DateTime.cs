using presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    public class DateDifference
    {
        public int day;
        public int month;
        public int year;
        public DateDifference(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        static public void differyear(DateDifference obj , DateDifference obj2)
        {
            int diffday = Math.Abs(obj.day - obj2.day) ;
            int diffmonth = Math.Abs(obj.month - obj2.month);
            int diffyear = Math.Abs(obj.year - obj2.year);
            Console.WriteLine("The diff between two years : ");
            Console.WriteLine(diffyear + " , " + diffmonth + " , "+ diffday);
        }
    }
}

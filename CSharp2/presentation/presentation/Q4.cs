using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    public class Q4
    {   
       public void viewFav(){
            string[] food = { "shawrmah", "mansaf", "kabsia", "burger", "zenger" };
            string[] sports = { "football", "tenis", "basketball" };
            string[] monie = { "Action", "comday", "Inception", "Forrest Gump" };
            // using foreach :
            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
            foreach (string item in sports)
            {
                Console.WriteLine(item);
            }
            foreach (string item in monie)
            {
                Console.WriteLine(item);
            }
            // using for loop:
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }
            for (int i = 0; i < monie.Length; i++)
            {
                Console.WriteLine(monie[i]);
            }
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }

        }
    }
}

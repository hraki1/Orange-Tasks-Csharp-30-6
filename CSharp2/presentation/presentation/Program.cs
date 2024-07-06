namespace presentation
{
    internal class Program
    {
        static public void printSumAndAv(int[]arr)
        {
            int sum = 0;
            double avg = 0.0;
            for (int i =0;i<arr.Length;i++)
            {
                sum += arr[i];
            }
            avg = (sum*1.0) / arr.Length;
            Console.WriteLine($"The summation of array is : {sum} , and the avarage is {avg}");
        }

        static public double cubeNumbers(int a)
        {
            return a * a * a;
        }

        static public void getYears(int []years)
        {
            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] > 1950)
                {
                    Console.WriteLine(years[i]);
                }
            }
        }

        static public double yearsToAge(double years)
        {
            return years * 365;
        }

        static public void farmerInof(int cows , int pigs , int chickens)
        {
            Console.WriteLine("chickens = "+chickens * 2);
            Console.WriteLine("cows = " + cows * 4);
            Console.WriteLine("pigs = " + pigs*4);
            int tot = chickens * 2 + cows * 4 + pigs * 4;
            Console.WriteLine("total numbers of legs is : " + tot);
        }

        static public void loginManager(string name , string pass)
        {
            string prename = "moahiemn";
            string password = "123";
            if (prename == name  &&  password == pass)
            {
                Console.WriteLine("Login succseefully");
            }
            else
            {
                Console.WriteLine("Login faild");
            }
        }

        static public void powerNumber(int basee, int pow)
        {
            int power = 1;
            for (int i = 1;i <= pow; i++)
            {
                power *= basee;
            }
            Console.WriteLine("The power of number is : " + power);
        }

        static public void leapyear(int y)
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("Leap years");
            }
            else
            {
                Console.WriteLine("Not Leap years");
            }
        }

        static public void primeNumber(int num)
        {
            string flag = "";
            for (int i = 2; i <= num / 2; i++)
            {
                if (i%2 != 0)
                {
                    flag = "Prime";
                }
                else
                {
                    flag = "Not Prime";
                }
            }
            Console.WriteLine("The result is :" + flag);
        }

        static public void stringCounter(string str)
        {
            string[] arr = str.Split(' ');
            int c = 0;
            for (int i = 0; i < arr.Length; i++) c++;
            Console.WriteLine("The number of words in string is : " + c);
            
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("======================================");
            //Person p1 = new Person();
            //p1.viewInfo();
            //Q8 obj = new Q8();
            //obj.printPattren();
            //powerNumber(2,3);
            //for(int i=1900; i<=2024; i++)
            //{
            //    leapyear(i);
            //}
            //primeNumber(8);
            // stringCounter("mohiamen mohiamen moahem");
            // Task5Q3 obj = new Task5Q3(5);
            // Console.WriteLine(obj.fact());
            //DateDifference obj1 = new DateDifference(3,11,1981);
            //DateDifference obj2 = new DateDifference(4, 9, 2013);
            //DateDifference.differyear(obj1, obj2);
            //Task5Q6 o = new Task5Q6("2002" , "1" , "14");
            //o.viewDate();
        }
    }
}
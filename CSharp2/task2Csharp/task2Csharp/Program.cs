using System.Text;

namespace task2Csharp
{
    public class Program
    {
        static void minutesToSecond(int minutes)
        {
            Console.WriteLine(minutes*60);
        }
        static int increaseByOne(int num)
        {
            return num++;
        }
        static int firstElementOfArray(int[] arr)
        {
            return arr[0];
        }
        static void triangleArea(double h  , double b)
        {
            double area = 0.5 * (h*b);
            Console.WriteLine($"The area of triangle is : {area}");
        }
        static int[] evenElementInEven(int[] arr)
        {
            List<int> newarr = new List<int> { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2 ==0 && i % 2 == 0)
                {
                    newarr[i] = arr[i];
                }
            }
            return newarr.ToArray();
        }
        static string[] evenIndexOddLength(string[] arr)
        {
            List<string> newarr = new List<string> { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length % 2 != 0 && i % 2 == 0)
                {
                    newarr[i] = arr[i];
                }
            }
            return newarr.ToArray();
        }
        static int[] powerElementIndex(int[] arr)
        {
            List<int> newarr = new List<int> { };
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = (int)Math.Pow(arr[i], i);
            }
            return newarr.ToArray();
        }
        static double multiplication2(double a , double b)
        {
            return a * b;
        }
        static double multi(int a, int b)
        {
            double flag = 1;
            for(int i = a; i <= b; i++)
            {
                flag *= i;
            }
            return flag;
        }

        static double avgArray(int[] arr)
        {
            double avg = 0.0;
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            return avg;
        }

        static string[] stringfun(string[]arr)
        {
            List<string> newarr = new List<string> { };
            for (int i = 0; i < arr.Length; i++)
            {
                foreach (char j in arr[i])
                {
                    if (Char.IsDigit(j))
                    {
                        newarr[i] = arr[i];
                    }
                }
            }
            return newarr.ToArray();
        }

        /*
            
        */

        static void reverseall(string arr)
        {
            string[] words = arr.Split(' ');
  
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length %2 != 0)
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    for (int f =0;f<charArray.Length;f++)
                        Console.Write(charArray[f]);

                    Console.Write(" ");
                }
                else
                {
                  Console.Write(words[i] +" ");
                }

            }
            
        }
        public static bool IsPandigital(long number)
        {
            string numStr = number.ToString();
            return "0123456789".All(digit => numStr.Contains(digit));
        }

        static void addNumber(int a , int b)
        {
            Console.WriteLine($"The addition of twonumbers is : {a+b}");
        }

        public static string RemoveLeadingAndTrailingZeros(string n)
        {
            n = n.TrimStart('0');
            if (n.StartsWith("."))
            {
                n = "0" + n;
            }
            int decimalIndex = n.IndexOf('.');
            if (decimalIndex != -1)
            {
                n = n.TrimEnd('0'); 
                if (n.EndsWith("."))
                {
                    n = n.Substring(0, n.Length - 1); 
                }
            }
            return n;
        }
        public static int secondLargestNumber(int []arr)
        {
            Array.Sort(arr);
            return arr[arr.Length - 2];
        }

        static bool isRepdigit(int num)
        {
            bool flag = true;
            if (num == 0)
            { 
                return true; 
            }
            if (num < 0)
            {
                return false;
            }
            for (int i = 1; i < num; i++)
            {
                if (i * 11 == num)
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        static void reversestring(string arr)
        {
            string[] words = arr.Split(' ');

            for (int i = words.Length; i >=0 ; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        static string boomArray(int[] arr)
        {
            int num = 7;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]== num)
                {
                    return "Boom!";
                    
                }
            }
            return "there is no 7 in the array";
        }

        public static string InsertWhitespace(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                result.Append(currentChar);
                if (char.IsLower(currentChar) && i < input.Length - 1 && char.IsUpper(input[i + 1]))
                {
                    result.Append(' ');
                }
            }
            return result.ToString();
        }
        public static int countTrue(bool[]arr) 
        {
            int c = 0;
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] == true)
                    c++;
            }
            return c;
        }

        public static string TolowerToUpper(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                char cuurenchar = chars[i];
                if (cuurenchar>= 65 && cuurenchar <= 90)
                {
                     chars[i] = (char)(cuurenchar + 32);
                }
                else if(cuurenchar >= 97 && cuurenchar <= 122)
                {
                    chars[i] = (char)(cuurenchar - 32);
                }
                else
                {
                    chars[i] = cuurenchar;
                }
            }
            return new string(chars);
        }

        public static bool lastItemMacth(string[]arr)
        {
            string str = "";
            for(int i = 0; i < arr.Length -1 ; i++)
            {
                str += arr[i];
            }
            if (str == arr[arr.Length - 1])
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static int findNAN(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (double.IsNaN(arr[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public static string[] RemoveDuplicates(string[] array)
        {
            HashSet<string> seen = new HashSet<string>();
            List<string> result = new List<string>();

            foreach (string item in array)
            {
                if (!seen.Contains(item))
                {
                    seen.Add(item);
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

        public static string RemoveLastVowel(string sentence)
        {
            string[] words = sentence.Split(' ');
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int lastIndex = -1;
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    if (vowels.Contains(word[j]))
                    {
                        lastIndex = j;
                        break;
                    }
                }
                if (lastIndex != -1)
                {
                    words[i] = word.Remove(lastIndex, 1);
                }
            }
            return string.Join(" ", words);
        }

        public static void cubeInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(cubenum(arr[i]) +" ");
            }
        }

        public static int cubenum(int num)
        {
            return num * num * num;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4 };
            cubeInt(arr);
        }
    }
}
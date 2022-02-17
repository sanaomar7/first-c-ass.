using System;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Operations

    {

        // PRANCH 2 
        public static int ReverseNumber(int number)
        {
            int reverseNum = 0, digit;
            while (number != 0)
            {
                digit = number % 10;
                reverseNum = (reverseNum * 10) + digit;
                number = number / 10;
            }


            return reverseNum;

        }


        // BRANCH 3 
        public static int BigestDigit(int number)
        {
            int digit1, digit2 = 0;
            while (number != 0)
            {
                digit1 = number % 10;
                if (digit2 < digit1)
                {
                    digit2 = digit1;
                }
                number = number / 10;
            }


            return digit2;

        }


        //BRANCH 4
        public static int FirstNum(string stringValue)
        {
            string string2 = string.Empty;
            int val = 0;
            Console.WriteLine($"String with number: {stringValue}");
            var matches = Regex.Matches(stringValue, @"\d+");
            foreach (var match in matches)
            {
                string2 += match;
            }
            val = int.Parse(string2);
            return val;

        }


        //BRANCH 1 
        public static int MaximumInput(int numberE)
        {
            var max = -1000000000;


            for (int i = 1; i <= numberE; i++)
            {
                Console.WriteLine("enter number " + i);
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("the maximum number from entered element = ");
            return max;

        }
    }
    }
         
    
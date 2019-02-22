using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int outVal;
            double outValDouble;
            bool isPal = false;

            while (true)
            {
                Console.WriteLine("Enter something to check if it is a palindrome: ");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out outVal))
                {
                    isPal = IsPalindrome(outVal);
                }
                else if (double.TryParse(userInput, out outValDouble))
                {
                    isPal = IsPalindrome(outValDouble);
                }
                else
                {
                    isPal = IsPalindrome(userInput);
                }

                if (isPal)
                    Console.WriteLine("{0} is a palindrome", userInput);
                else
                    Console.WriteLine("{0} is not a palindrome", userInput);
                Console.WriteLine("-----------------------");

            }

            //Console.ReadKey();
        }

        private static bool IsPalindrome(string userInput)
        {
            int i = 0;
            int j = userInput.Length - 1;

            while (i < j)
            {
                if (userInput[i].Equals("")) //skip space
                    i++;
                if (userInput[j].Equals("")) //skip space
                    j--;

                if (userInput.ToLower()[i] != userInput.ToLower()[j]) //convert to lower case
                {
                    return false;
                }
                   
                i++;
                j--;
            }
            
            return true;
        }

        private static bool IsPalindrome(int userInput)
        {
            //first solution (might not work with numbers ending with 0)
            int n = userInput;
            int lastdig,sum=0;

            while (n > 0)
            {
                lastdig = n % 10;
                sum = sum * 10 + lastdig;
                n = n / 10;
            }
            if (userInput == sum) {
                
                return true;
            }
            else
            {
                
                return false;
            }

            //second solution is converting int to string
        }

        private static bool IsPalindrome(double userInput)
        {
            //Omit the dot in the double and send it to IsPalindrome method again
            int dCheck = Convert.ToInt32(Math.Truncate(userInput));
            return false;
        }
    }
}

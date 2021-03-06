using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string to be reverted
            Console.Write("Enter text to revert: ");
            string inputString = Console.ReadLine();
            
            
            //if string is empty say "i want text"
            while (inputString == " ")
            {
                Console.WriteLine("Please enter text: ");
                inputString = Console.ReadLine();
            }
            // reverse the input string    
            string reversedString = ReverseString(inputString);
           
            //print the reversed string
            Console.WriteLine(reversedString);
            

            // second method
           
            char[] inputArray = inputString.ToCharArray(); // convert string to char array
            Array.Reverse(inputArray); // reverse the char array
            string output = new string(inputArray); // convert to string
            
            Console.WriteLine(inputArray); // print reversed string
          
        }
        /// <summary>
        /// Reversing text
        /// </summary>
        /// <param name="text">text we want to be reverssed</param>
        /// <returns>reversed text</returns>
        private static string ReverseString(string text)
        {
            StringBuilder reversedString = new StringBuilder();

            for (int i = text.Length - 1; i >= 0 ; i--)
            {
                reversedString.Append(text[i]);
            }
            return reversedString.ToString();
        }
    }
}

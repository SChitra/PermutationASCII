using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneStringIsPermutationofOther
{
    class Program
    {
        //Given two strings, write a method to decide if one is a permutation of the other? 

        public static Boolean IsPermutation(string s1,string s2)
        {
            //Check lenght of the string to see if they are not same then they cannot be permutation
            if (s1.Length != s2.Length)
                return false;
            //Declare an array of possible characters in the ASCII character set
            int[] characterCount = new int[128];
            int charIndex;
            /***Count the characters in each string and add the counts 
            from the first string to the array  ***/
            foreach (char myChar in s1.ToCharArray())
            {
                charIndex = (int)myChar;
                characterCount[charIndex]++;
             }
            //Subtract the counts from the second string from the count array.
            foreach (char myChar in s2.ToCharArray())
            {
                charIndex = (int)myChar;
                characterCount[charIndex]--;
            }
            for (int i = 0; i < 128; i++)
            {
                if (characterCount[i] != 0)
                    return false;
             }
            return true;

        }

        static void Main(string[] args)
        {
            string s1 = "dad";
            string s2 = "add";
            var result = IsPermutation(s1, s2);
            if(result == true)
                Console.WriteLine("String 1 is permutation of String 2 ");
            else
                Console.WriteLine("String 1 is not permutation of String 2");
        }
    }
}

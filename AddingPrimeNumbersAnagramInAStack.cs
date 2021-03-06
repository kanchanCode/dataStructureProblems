//-----------------------------------------------------------------------
// <copyright file="AddingPrimeNumbersAnagramInAStack.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// this class is used for storing the prime anagrams in to stack
    /// </summary>
    public class AddingPrimeNumbersAnagramInAStack
    {
        /// <summary>
        /// Prime  number anagram in a stack.
        /// </summary>
        public void PrimeNumbersAnagramInAStack()
        {
            ////creating the object of a utility class
            Utility utility = new Utility();
            ////creating the object of a stack
            Stack stack = new Stack();
            ////calling the ListOfPrimeNumbers method from the utility class from there we will get the prime numbers in to an array list
            ArrayList primenumbers = utility.ListOfPrimeNumbers();
            ////this for loop is used for taking one by one element from the array list
            for (int i = 0; i < primenumbers.Count; i++)
            {
                ////converting number int to string
                string number1 = primenumbers[i] + string.Empty;
                ////converting string number in to character array
                char[] numberInArray1 = number1.ToCharArray();
                Array.Sort(numberInArray1);
                ////converting character array in to string
                string original1 = new string(numberInArray1);
                for (int j = i + 1; j < primenumbers.Count; j++)
                {
                    ////converting number int to string
                    string number2 = primenumbers[j] + string.Empty;
                    ////converting string number in to character array
                    char[] numberInArray2 = number2.ToCharArray();
                    Array.Sort(numberInArray2);
                    ////converting character array in to string
                    string original2 = new string(numberInArray2);
                    if (original1.Equals(original2))
                    {
                        ////adding elements in to a stack
                        stack.Push(number1);
                        stack.Push(number2);
                    }
                }
            }

            Console.WriteLine("anagram prime numbers that are in 0 to 1000 are ");
            ////this for each loop is used for printing the values in a stack
            foreach (string numbers in stack)
            {
                Console.Write(numbers + "\t");
            }
        }
    }
}

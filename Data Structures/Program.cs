using System;
using System.Collections.Generic;

namespace Data_Structures
{
    class Program
    {
        static bool ValidateInput(string str)
        {
            string invalidChars = "1234567890-=[]\\;',./`~!@#$%^&*()_+{}|:\"<>?";
            foreach (char chr in str)
            {
                if (invalidChars.Contains(chr.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReverseString(string str)
        {
            Stack<string> stack = new Stack<string>();
            string returnString = "";
            foreach (char chr in str)
            {
                stack.Push(chr.ToString());
            }
            for (int i = 0; i < str.Length; i++)
            {
                returnString += stack.Pop();
            }
            return returnString;
        }
        static void Main(string[] args)
        {
            string input = "";
            string printString = "";

            Console.WriteLine("Welcome to my string reversal program!");

            Console.Write("Please enter a word or phrase: ");

            bool validInput = false;
            do
            {
                input = Console.ReadLine();
                if (ValidateInput(input))
                {
                    validInput = true;
                }
                else
                {
                    Console.Write("Please enter a valid string with only letters: ");
                }
            } while (!validInput);

            string[] words = input.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (i != words.Length - 1)
                {
                    printString += $"{ReverseString(word)} ";
                }
                else
                {
                    printString += ReverseString(word);
                }
            }

            Console.WriteLine(printString);
        }
    }
}

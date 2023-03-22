using System;

namespace strings_cook_jakob
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks user to put a character and assigns input to a variable
            Console.WriteLine("Please input a character!");
            char myChar = Char.IsLetter(myChar);

            // checks if the character user entered is a letter
            bool isLetter = Char.IsLetter(myChar);

            // prints the results to console
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}.");

            // asks user a question and saves response to a variable, sentance
            Console.WriteLine("Why do you like video games?");
            string sentence = Console.ReadLine();

            // asks user a word saves response to a variable called word
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();

            // checks if the word is in the sentence
            bool isIn = sentence.Contains(word);

            // prints if the word is in the sentence
            Console.WriteLine($"{word} exists in {sentence}, {isIn}!")
        }
    }
}

using Lab7RandomCharacters.Models;
using Lab7RandomCharacters.Services;
using System.CodeDom.Compiler;


namespace Lab7RandomCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List to save all the characters created.
            List<Character> characterList = new List<Character>();

            // Creates a CharacterGenerator instance to generate random characters.
            CharacterGenerator generate = new CharacterGenerator();

            Console.WriteLine("\tWelcome to character generator!");
            Console.WriteLine("How many characters would you like to create?");
            Console.Write("Heroes:  ");

            int input; // Variable to hold the users input

            // AI suggested TryParse() to prevent invalid input from crashing the program.
            // I adjusted the validation logic to accept only positive integers.
            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
            {
                Console.Write("Enter a positive number: ");
                input = int.Parse(Console.ReadLine());
            }

            // Loop iterates for as many times as the input value holds.
            // A new character is created and calls the GenerateCharacter method.
            // Every character is added to the list.
            for (int i = 0; i < input; i++)
            {
                Character character = generate.GenerateCharacter();
                characterList.Add(character);
            }

            // Each element in characterList is printed with a empty line inbetween.
            foreach (Character hero in characterList)
            {
                Console.WriteLine($"\n{hero}");
            }
        }
    }
}

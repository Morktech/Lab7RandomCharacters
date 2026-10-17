using Lab7RandomCharacters.Models;
using Lab7RandomCharacters.Services;
using System.CodeDom.Compiler;


namespace Lab7RandomCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> characterList = new List<Character>();

            CharacterGenerator generate = new CharacterGenerator();

            Console.WriteLine("\tWelcome to character generator!");
            Console.WriteLine("How many characters would you like to create?");
            Console.Write("Generate characters:  ");

            int input;

            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
            {
                Console.Write("Enter a positive number: ");
                input = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < input; i++)
            {
                Character character = generate.GenerateCharacter();
                characterList.Add(character);
            }

            //foreach (Character hero in characterList)
            //{

            //    Console.WriteLine($"\n{hero}");
            //}
        }
    }
}

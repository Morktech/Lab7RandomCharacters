using Lab7RandomCharacters.Models;
using Lab7RandomCharacters.Services;


namespace Lab7RandomCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterGenerator generator = new CharacterGenerator();

            Character character = generator.GenerateCharacter();

            Console.WriteLine(character);

        }
    }
}

using Lab7RandomCharacters.Services;

namespace Lab7RandomCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterGenerator newChar = new CharacterGenerator();

            Console.WriteLine(newChar.GenerateName());
            Console.WriteLine(newChar.GenerateStrength());
            Console.WriteLine(newChar.GenerateSpeed());
            Console.WriteLine(newChar.GenerateHealth());


        }
    }
}

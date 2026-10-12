using Lab7RandomCharacters.Services;

namespace Lab7RandomCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterGenerator newChar = new CharacterGenerator();

            Console.WriteLine(newChar.GenerateName());
          
        }
    }
}

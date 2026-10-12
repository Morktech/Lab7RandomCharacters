using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7RandomCharacters.Services
{
    internal class CharacterGenerator
    {
        
        private readonly Random _random = new Random();

        string[] names
            = { "Kaelen", "Draven", "WiseOldMan", "Isolde" , "Borin", "Jad", "Elvarg", "Oziach", "Gandalf", "Lich" };


        public string GenerateName()
        {
            int randomIndex = _random.Next(names.Length);

            return names[randomIndex];
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7RandomCharacters.Services
{
    internal class CharacterGenerator
    {
        
        private readonly Random _random = new Random();

        string[] names
            = { "Kaelen", "Draven", "WiseOldMan", "Isolde" , "Borin", "Andros Mai", "Ferox", "Oziach", "Derse Venator", "Phabelle Bile," };


        public string GenerateName()
        {
            int randomIndex = _random.Next(names.Length);
            return names[randomIndex];
        }

        public int GenerateStrength() => _random.Next(10, 101);
      
        public int GenerateSpeed() =>  _random.Next(1, 100);
       
        public int GenerateHealth() => _random.Next(50, 120);
      
    }
}

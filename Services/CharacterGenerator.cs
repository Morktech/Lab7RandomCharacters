
using Lab7RandomCharacters.Models;

namespace Lab7RandomCharacters.Services
{
    internal class CharacterGenerator
    {

        private readonly Random _random = new Random();

        string[] names =
                {"Kaelen",
                "Draven",
                "WiseOldMan",
                "Isolde" ,
                "Borin",
                "Andros Mai",
                "Ferox",
                "Oziach",
                "Derse Venator",
                "Phabelle Bile," };

        string[] specialAbilities =
               {"Heal Allies",
                "Ranged Volley",
                "Magic Missile",
                "Teleport",
                "Vanish",
                "Thunderwave",
                "Menacing Attack",
                "Moonbeam",
                "Eldritch Blast",
                "Hunter's Mark",
                "Smite",
                "Lightning",
                "Fireball"};
        public string GenerateName()
        {
            int randomIndex = _random.Next(names.Length);
            return names[randomIndex];
        }
        public string GenerateSpecialAbility()
        {
            int randomIndex = _random.Next(specialAbilities.Length);
            return specialAbilities[randomIndex];
        }

        public int GenerateStrength() => _random.Next(10, 101);

        public int GenerateSpeed() => _random.Next(1, 100);

        public int GenerateHealth() => _random.Next(50, 120);

        public Character GenerateCharacter()
        {
            Character character = new Character(
                GenerateName(),
                GenerateStrength(),
                GenerateSpeed(),
                GenerateHealth(),
                GenerateSpecialAbility());

            return character;
        }


    }
}

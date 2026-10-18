
using Lab7RandomCharacters.Models;

namespace Lab7RandomCharacters.Services
{
    /// <summary>
    /// Generates random character names, special abilities, and numeric attributes, and constructs Character instances.
    /// </summary>
    /// <remarks>Uses a private Random instance to select a name and ability from predefined arrays and to
    /// generate attributes. Strength is 10–100, speed is 1–99, and health is 50–119. Use GenerateCharacter to obtain a
    /// Character initialized with the generated values.</remarks>
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

        // Method:
        // _random generates a random index within the arrays length.
        // Returns the name at the random index.
        public string GenerateName()
        {
            int randomIndex = _random.Next(names.Length);
            return names[randomIndex];
        }
        // Method:
        // _random generates a random index within the arrays length.
        // Returns the special ability at the random index.
        public string GenerateSpecialAbility()
        {
            int randomIndex = _random.Next(specialAbilities.Length);
            return specialAbilities[randomIndex];
        }
        
        // Method: Generates a random strength value: min = 10, max = 100.
        public int GenerateStrength() => _random.Next(10, 101); 

        // Method: Generates a random speed value: min = 1, max = 99
        public int GenerateSpeed() => _random.Next(1, 100); 

        // Method: Generates a random health pool value: min = 50, max = 119
        public int GenerateHealth() => _random.Next(50, 120);

        /// <summary>
        /// Creates a Character instance with a generated name, strength, speed, health, and special ability.
        /// </summary>
        /// <remarks>Values are obtained by calling GenerateName, GenerateStrength, GenerateSpeed,
        /// GenerateHealth, and GenerateSpecialAbility.</remarks>
        /// <returns>A Character initialized with generated name, strength, speed, health, and special ability.</returns>
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

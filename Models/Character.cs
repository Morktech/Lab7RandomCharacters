
namespace Lab7RandomCharacters.Models
{
    // AI provided guidance on separating responsibilities between classes.
    // I organized the generator logic in its own service class.
    internal class Character
    {
        public string Name { get; set; } = "";
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public string SpecialAbility { get; set; } = "";

        public Character(string name, int strength, int speed, int health, string specialAbility)
        {
            Name = name;
            Strength = strength;
            Speed = speed;
            Health = health;
            SpecialAbility = specialAbility;
        }

        // AI explained how ToString() works, 
        // why i could use it without having a virtual method (Object.ToString()).
        // I customized the output to display my character's properties.
        public override string ToString()
        {
            return  $"\t{Name}" +
                    $"\n ----------------------" +
                    $"\n|  -Character stats-"  +
                    $"\n| HP     : {Health}" +
                    $"\n| STR lvl: {Strength}" +
                    $"\n| SPD lvl: {Speed}" +
                    $"\n| Ability: {SpecialAbility}";
        }
    }
}

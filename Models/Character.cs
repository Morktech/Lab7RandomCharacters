using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7RandomCharacters.Models
{
    internal class Character
    {
        // Five properties for a character
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

        public override string ToString()
        {
            return  $"\t{Name}" +
                    $"\n"+
                    $"\n--- Character Stats ---" +
                    $"\nCon lvl: {Health} " +
                    $"\nStr lvl: {Strength} " +
                    $"\nAgi lvl: {Speed} " +
                    $"\nSPECIAL: {SpecialAbility} ";
        }
    }
}

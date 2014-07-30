using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day3StarWars.Models
{
    public class BountyHunter : Character
    {
        public override string Fighting()
        {
            return "Bang!";
        }

        public string WeaponType;

        public BountyHunter(string name, string species, string gender, string weaponType)
        {
            Name = name;
            Species = species;
            Gender = gender;
            WeaponType = weaponType;
            CharacterType = Character.Type.BountyHunter;
        }
    }
}
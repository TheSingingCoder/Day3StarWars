using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day3StarWars.Models
{
    public class Jedi : Character
    {

        //Override Method
        public override string Fighting(){
            return "Crash!";
        }
        //New Variable
        public string SaberColor;

        public Jedi(string name, string species, string gender, string saberColor)
        {
            Name = name;
            Species = species;
            Gender = gender;
            SaberColor = saberColor;
            CharacterType = Character.Type.Jedi;
        }
    }
}
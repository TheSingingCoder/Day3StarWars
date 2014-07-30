using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day3StarWars.Models
{
    public abstract class Character
    {
        public string Name;
        public string Species;
        public string Gender;
        public Type CharacterType;
        public enum Type {Jedi, BountyHunter};
        public abstract string Fighting();
    }
}
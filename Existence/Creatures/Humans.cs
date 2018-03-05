using System;
using CreatureProperties;
using Creatures;

namespace Creatures.Humans
{
    public class Humans : IHuman, ICreature
    {
        public Humans( string race, uint? age, bool alive, Genders sex)
        {
            Race = race;
            Age = age;
            Alive = alive;
            Sex = sex;
        }

        public string Race { get; set; }
        public uint? Age { get; set; }
        public bool Alive { get; set; }
        public Genders Sex { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public uint? IQ { get; set; }
        public uint Weigth { get; set; }
        public uint Height { get; set; }
    }
}

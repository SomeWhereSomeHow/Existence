using System;
using CreatureProperties;

namespace Creatures
{
    public interface ICreature
    {
        String Race { get; set; }

        uint? Age { get; set; }

        bool Alive { get; set; }

        Genders Sex { get; set; }

        String Description { get; set; }

        uint Weigth { get; set; }

        uint Height { get; set; }

    }
}

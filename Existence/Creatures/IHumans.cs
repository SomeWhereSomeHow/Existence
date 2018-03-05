using System;
using CreatureProperties;
using Creatures;

namespace Creatures.Humans {
    public interface IHuman
    {
        String FirstName { get; set; }

        String LastName { get; set; }

        String NickName { get; set; }

        uint? IQ { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Board
    {
        List<Creature> _creatures = new List<Creature>();

        public void Append(Creature creature)
        {
            _creatures.Add(creature);
        }
    }
}

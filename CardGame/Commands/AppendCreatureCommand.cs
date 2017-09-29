using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Commands
{
    public class AppendCreatureCommand : ICommand
    {
        private Creature _creature;

        public AppendCreatureCommand(Creature creature)
        {
            _creature = creature;
        }

        public void Execute(Board board)
        {
            board.Append(_creature);
        }
    }
}

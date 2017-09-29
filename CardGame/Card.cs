using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public abstract class Card
    {
        public abstract List<ICommand> Play();
    }
}

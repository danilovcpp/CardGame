using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Game
    {
        private Board _board = new Board();

        public void Play(Card card)
        {
            var commands = card.Play();

            foreach (var command in commands)
            {
                command.Execute(_board);
            }
        }
    }
}

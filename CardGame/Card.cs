using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
	public class Card
	{
		public int Cost { get; private set; }
		public int Rarity { get; private set; }
		public ICollection<ICommand> Commands { get; private set; }
	}
}

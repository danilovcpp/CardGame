using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
	interface IPlayable
	{
		ICollection<ICommand> Play();
	}
}

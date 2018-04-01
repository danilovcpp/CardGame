using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
	public interface ICommand
	{
		void Execute(Board board);
	}
}

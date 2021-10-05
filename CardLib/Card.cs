using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
	public class Card : ICloneable
	{
		public readonly Rank rank;
		public readonly Suit suit;

		public Card(Suit newSuit, Rank newRank)
		{
			suit = newSuit;
			rank = newRank;
		}

		private Card() { }

		public override string ToString() => "The " + rank + " of " + suit + "s";

		/// <summary>
		/// 浅度复制
		/// </summary>
		/// <returns></returns>
		public object Clone() => MemberwiseClone();
	}
}

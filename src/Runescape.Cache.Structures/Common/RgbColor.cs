using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	//TODO: Move this into a common library
	/// <summary>
	/// RGB color structure.
	/// </summary>
	[WireDataContract]
	public sealed class RgbColor
	{
		[WireMember(1)]
		public byte Red { get; }

		[WireMember(2)]
		public byte Green { get; }

		[WireMember(3)]
		public byte Blue { get; }

		/// <summary>
		/// Protected serializer ctor
		/// </summary>
		protected RgbColor()
		{
			
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	//TODO: What is this used for?
	/// <summary>
	/// The <see cref="RgbColor"/>2 attribute.
	/// </summary>
	public sealed class RgbColor2MapTileAttribute : MapTileAttribute
	{
		/// <summary>
		/// Color2 attribute.
		/// </summary>
		[WireMember(1)]
		public RgbColor Color { get; }

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected RgbColor2MapTileAttribute()
		{

		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	/// <summary>
	/// The <see cref="RgbColor"/> attribute.
	/// </summary>
	public sealed class RGBColorMapTileAttribute : MapTileAttribute
	{
		/// <summary>
		/// Color attribute.
		/// </summary>
		[WireMember(1)]
		public RgbColor Color { get; }

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected RGBColorMapTileAttribute()
		{

		}
	}
}

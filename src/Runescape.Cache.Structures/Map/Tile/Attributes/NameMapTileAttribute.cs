using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	/// <summary>
	/// The name attribute.
	/// </summary>
	public sealed class NameMapTileAttribute : MapTileAttribute
	{
		//TODO: We need to support nullterminator for 10
		/// <summary>
		/// Map tile name attribute.
		/// </summary>
		[WireMember(1)]
		public string Name { get; }

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected NameMapTileAttribute()
		{

		}
	}
}

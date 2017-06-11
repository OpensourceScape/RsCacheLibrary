using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	/// <summary>
	/// Map tile.
	/// A map tile is an entity that is composed of a collection of attributes.
	/// </summary>
	[WireDataContract]
	public sealed class MapTile
	{
		/// <summary>
		/// Deserialized map tile attributes.
		/// </summary>
		[WireMember(1)]
		private MapTileAttribute[] _Attributes { get; }

		/// <summary>
		/// Attributes that the <see cref="MapTile"/> is composed of.
		/// </summary>
		public IEnumerable<MapTileAttribute> Attributes { get; }

		/// <summary>
		/// Protected serializer ctor
		/// </summary>
		protected MapTile()
		{
			
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	[WireDataContract]
	public sealed class MapTileCollection
	{
		//The cache length-prefixes the collection
		/// <summary>
		/// Deserialized map tiles.
		/// </summary>
		[WireMember(1)]
		[SendSize(SendSizeAttribute.SizeType.UShort)]
		private MapTile[] _MapTiles { get; }

		/// <summary>
		/// Collection of loaded map tiles.
		/// </summary>
		public IEnumerable<MapTile> MapTiles { get; }
	}
}

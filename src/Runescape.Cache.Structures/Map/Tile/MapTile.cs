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
		[WireMember(1)]
		private MapTileAttribute[] _Attributes { get; }

		public IEnumerable<MapTileAttribute> Attributes { get; }
	}
}

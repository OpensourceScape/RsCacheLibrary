using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache
{
	[WireDataContract]
	public sealed class RegionInformation
	{
		/// <summary>
		/// Location hash for the region.
		/// </summary>
		[WireMember(1)]
		public ushort RegionHash { get; }

		//TODO: What is this?
		/// <summary>
		/// The tile-map index this region uses.
		/// </summary>
		[WireMember(2)]
		public ushort RegionLandscapeIndex { get; }

		//TODO: What is this?
		/// <summary>
		/// The object-map index this region uses.
		/// </summary>
		[WireMember(3)]
		public ushort RegionObjectMapIndex { get; }

		//TODO: What is this?
		/// <summary>
		/// ?
		/// </summary>
		[WireMember(4)]
		public byte RegionPreload { get; }

		/// <summary>
		/// Protected serializer ctor
		/// </summary>
		protected RegionInformation()
		{
			
		}
	}
}

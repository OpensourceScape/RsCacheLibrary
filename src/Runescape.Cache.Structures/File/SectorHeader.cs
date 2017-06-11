using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using Runescape.Cache.Structures.Common;

namespace Runescape.Cache.Structures
{
	/// <summary>
	/// Index entry contained within index files.
	/// </summary>
	[WireDataContract]
	public sealed class SectorHeader
	{
		/// <summary>
		/// Represents the size of the sector.
		/// </summary>
		[WireMember(1)]
		public UInt24 SectorSize { get; }

		/// <summary>
		/// Represents the starting point of the sector.
		/// </summary>
		[WireMember(2)]
		public UInt24 SectorStartPosition { get; }

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected SectorHeader()
		{
			
		}
	}
}

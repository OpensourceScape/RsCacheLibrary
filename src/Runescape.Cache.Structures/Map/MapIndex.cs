using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache
{
	/// <summary>
	/// Collection of Region information.
	/// Found in map_index in the Runescape cache.
	/// </summary>
	[WireDataContract]
	public sealed class MapIndex : IEnumerable<RegionInformation>
	{
		/// <summary>
		/// Deserialized region information.
		/// </summary>
		[WireMember(1)]
		public RegionInformation[] _Regions { get; }

		/// <summary>
		/// Collection of the map index' region information.
		/// </summary>
		public IEnumerable<RegionInformation> Regions => _Regions;

		/// <summary>
		/// Protected ctor for serialization.
		/// </summary>
		protected MapIndex()
		{
			
		}

		/// <inheritdoc />
		public IEnumerator<RegionInformation> GetEnumerator()
		{
			return Regions.GetEnumerator();
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	/// <summary>
	/// Attribute that indicates that occulusion should be disabled.
	/// </summary>
	[WireDataContract]
	public class DisableOcclusionMapTileAttribute : MapTileAttribute
	{
		//We don't need to read or write anything.

		//TODO: We need to disable occlusion somehow

		protected DisableOcclusionMapTileAttribute()
		{
			
		}
	}
}

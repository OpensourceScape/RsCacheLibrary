using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	[WireDataContract]
	public sealed class DefaultMapTileAttribute : MapTileAttribute
	{
		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected DefaultMapTileAttribute()
		{
			
		}
	}
}

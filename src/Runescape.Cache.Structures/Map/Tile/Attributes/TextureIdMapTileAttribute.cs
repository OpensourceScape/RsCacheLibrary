using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	/// <summary>
	/// The texture ID attribute.
	/// </summary>
	public sealed class TextureIdMapTileAttribute : MapTileAttribute
	{
		//Jagex uses an unsigned byte
		/// <summary>
		/// Id of the texture referenced.
		/// </summary>
		[WireMember(1)]
		public byte TextureId { get; }

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected TextureIdMapTileAttribute()
		{

		}
	}
}

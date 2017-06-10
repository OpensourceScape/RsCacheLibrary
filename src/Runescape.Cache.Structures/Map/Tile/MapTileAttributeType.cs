using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	//Jagex uses a byte sized value to indicate the map tile attribute type
	[WireDataContract]
	public enum MapTileAttributeType : byte
	{
		/// <summary>
		/// Indicates the end of the attribute list.
		/// </summary>
		Default = 0,

		/// <summary>
		/// Indicates that a 3 byte RGB Color value is included.
		/// </summary>
		RGBColor = 1,

		/// <summary>
		/// Indicates that a texture ID is included.
		/// </summary>
		TextureID = 2,

		//TODO: What is this?
		/// <summary>
		/// ?
		/// </summary>
		aBoolean227 = 3, 

		//TODO: What is this?
		/// <summary>
		/// ?
		/// </summary>
		Occlusion = 5,

		/// <summary>
		/// Indicates that a name is included.
		/// </summary>
		Name = 6,

		/// <summary>
		/// Indicates that a second RGB color is present.
		/// </summary>
		RgbColor2 = 7
	}
}

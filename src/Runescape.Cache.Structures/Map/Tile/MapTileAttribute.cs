using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace Runescape.Cache.Structures
{
	//Uses a byte to indicate attribute subtype
	/// <summary>
	/// Base type for all maptile attributes.
	/// </summary>
	[DefaultChild(typeof(DefaultMapTileAttribute))] //if we encounter an attribute we don't know then we use the default (can be used for logging)
	[WireDataContractBaseType((int)MapTileAttributeType.Default, typeof(DefaultChildAttribute))] //TODO: Maybe don't use default to mark the end?
	[WireDataContract(WireDataContractAttribute.KeyType.Byte, InformationHandlingFlags.DontConsumeRead)]
	public abstract class MapTileAttribute : IMapTileAttributeIdentifiable
	{
		/// <inheritdoc />
		[WireMember(1)]
		public MapTileAttributeType AttributeTypeId { get; }

		//We don't include anything else in here because they don't share anything in common

		/// <summary>
		/// Protected serializer ctor
		/// </summary>
		protected MapTileAttribute()
		{
			
		}
	}
}

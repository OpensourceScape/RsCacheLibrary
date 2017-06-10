using System;
using System.Collections.Generic;
using System.Text;

namespace Runescape.Cache.Structures
{
	/// <summary>
	/// An attribute that is type identifable.
	/// </summary>
	public interface IMapTileAttributeIdentifiable
	{
		/// <summary>
		/// Indicates the attribute type.
		/// </summary>
		MapTileAttributeType AttributeTypeId { get; }
	}
}

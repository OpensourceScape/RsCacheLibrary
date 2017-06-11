using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace Runescape.Cache.Structures.Common
{
	//Based on: https://stackoverflow.com/questions/12549197/are-there-any-int24-implementations-in-c
	/// <summary>
	/// An unsigned 24bit integer.
	/// </summary>
	[WireDataContract]
	public class UInt24
	{
		/// <summary>
		/// Internal byte representation.
		/// </summary>
		[KnownSize(3)]
		[WireMember(1)]
		private byte[] intBytes { get; }

		/// <summary>
		/// <see cref="uint"/> converted value.
		/// </summary>
		public uint Value => (uint)(intBytes[0] | (intBytes[1] << 8) | (intBytes[2] << 16));

		public UInt24(UInt32 value)
		{
			//Should be 3 bytes long
			intBytes = new byte[3];

			intBytes[0] = (byte)(value & 0xFF);
			intBytes[1] = (byte)(value >> 8);
			intBytes[2] = (byte)(value >> 16);
		}

		public UInt24(byte[] bytes)
		{
			if (bytes == null) throw new ArgumentNullException(nameof(bytes));
			if (bytes.Length < 3) throw new ArgumentException($"Provided argument {nameof(bytes)} must be of at least size 3. Is size {bytes.Length}.", nameof(bytes));

			intBytes = bytes.Length == 3 ? bytes.ToArray() : bytes.Take(3).ToArray();
		}

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected UInt24()
		{
			
		}
	}
}

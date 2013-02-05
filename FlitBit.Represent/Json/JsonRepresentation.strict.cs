﻿#region COPYRIGHT© 2009-2013 Phillip Clark. All rights reserved.
// For licensing information see License.txt (MIT style licensing).
#endregion

using Newtonsoft.Json;

namespace FlitBit.Represent.Json
{
	/// <summary>
	/// Transforms an items into a JSON representation, erroring on missing members.
	/// </summary>
	/// <typeparam name="T">item type T</typeparam>
	public class JsonRepresentationStrict<T> : JsonRepresentation<T>
		where T : class
	{
		/// <summary>
		/// Creates a new instance.
		/// </summary>
		public JsonRepresentationStrict() : base(StaticJsonSettings.Strict) { }
	}
}
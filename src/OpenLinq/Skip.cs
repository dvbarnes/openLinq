using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TSource> Skip<TSource> (this IEnumerable<TSource> source, int count)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (count <= 0) {
				return source;
			}
			return SkipWhile (source, (c,idx)=>idx < count);
		}
	}
}


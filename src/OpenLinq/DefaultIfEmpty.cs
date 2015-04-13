using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TSource> DefaultIfEmpty<TSource> (this IEnumerable<TSource> source, TSource defaultValue){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (source.Any ()) {
				return source;
			}
			return Enumerable.Repeat (defaultValue, 1);
		}
		public static IEnumerable<TSource> DefaultIfEmpty<TSource> (this IEnumerable<TSource> source)
		{
			return DefaultIfEmpty (source, default(TSource));
		}
	}
}


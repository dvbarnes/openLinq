using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static bool Contains<TSource> (this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (comparer == null) {
				throw new ArgumentNullException ("comparer");
			}
			return source.Any (x => comparer.Equals(x, value));
		}
		public static bool Contains<TSource> (this IEnumerable<TSource> source, TSource value){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			return source.Any (x => x.Equals(value));
		}
	}
}



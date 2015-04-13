using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TSource> SkipWhile<TSource> (this IEnumerable<TSource> source, Func<TSource, int, bool> predicate){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (predicate == null) {
				throw new ArgumentNullException ("predicate");
			}
			return SkipWhileImp (source, predicate);
		}
		public static IEnumerable<TSource> SkipWhileImp<TSource> (this IEnumerable<TSource> source, Func<TSource, int, bool> predicate){
			int idx = 0;
			foreach(TSource s in source){
				if (predicate (s, idx++)) {
					yield return s;
				}
			}
		}
		public static IEnumerable<TSource> SkipWhile<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (predicate == null) {
				throw new ArgumentNullException ("predicate");
			}
			return source.Where (x => predicate (x));
		}


	}
}


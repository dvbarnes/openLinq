using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TSource> Where<TSource> (this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (predicate == null) {
				throw new ArgumentNullException ("predicate");
			}
			return WhereImp (source, predicate);
		}

		private static IEnumerable<TSource>WhereImp<TSource>(IEnumerable<TSource> source, Func<TSource, int , bool> predicate){
			int index = 0;
			foreach (var item in source) {
				if(predicate(item, index++)){
					yield return item;
				}
			}
		}

		public static IEnumerable<TSource> Where<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate){
			return Where (source, (x, y) => predicate (x));
		}
	}
}


using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TSource> Distinct<TSource> (this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			return DistinctImp (source, comparer ?? EqualityComparer<TSource>.Default);
		}
		public static IEnumerable<TSource> Distinct<TSource> (this IEnumerable<TSource> source)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			return DistinctImp (source, EqualityComparer<TSource>.Default);

		}
		private static IEnumerable<TSource> DistinctImp<TSource> (IEnumerable<TSource> source, IEqualityComparer<TSource> comparer){
			IDictionary<TSource, TSource> set = new Dictionary<TSource,TSource> (comparer);
			foreach (TSource item in source) {
				if (!set.ContainsKey (item)) {
					yield return item;
				}
				set.Add (item,item);
			}
		}

	}
}


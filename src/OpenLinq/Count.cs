using System;
using System.Collections.Generic;
using System.Collections;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static int Count<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			var s = source as ICollection<TSource>;
			if (s != null) {
				return s.Count;
			}
			int count = 0;
			checked{
				foreach(TSource item in source){
					if (predicate (item)) {
						count++;
					}
				}
			}
			return count;
		}

		private static bool TryFastCount<TSource>(IEnumerable<TSource> source, out int count)
		{
			//we are going to try our hardest to check if it's an ICollection and if it's not return false
			var s = source as ICollection<TSource>;
			if (s != null) {
				count = s.Count;
				return true;
			}
			var s2 = source as ICollection;
			if (s2 != null) {
				count = s2.Count;
				return true;
			}
			count = 0;
			return false;
		}

		public static int Count<TSource> (this IEnumerable<TSource> source)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}

			int count = 0;
			if (TryFastCount (source, out count)) {
				return count;
			}
			checked{
				using (IEnumerator<TSource> s = source.GetEnumerator ()) {
					while (s.MoveNext ()) {
						count++;
					}
				}
			}
			return count;
		}
	}
}


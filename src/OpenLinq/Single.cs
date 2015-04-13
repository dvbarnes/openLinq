using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static TSource Single<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			return Single(source.Where(x=>predicate(x)));
		}

		public static TSource Single<TSource> (this IEnumerable<TSource> source)
		{
			using (IEnumerator<TSource> ittr = source.GetEnumerator ()) {
				if (!ittr.MoveNext ()) {
					throw new InvalidOperationException ("sequence is empty");
				}
				TSource ret = ittr.Current;
				if (ittr.MoveNext ()) {
					throw new InvalidOperationException ("Sequence contains more than one element.");
				}
				return ret;
			}
		}
	}
}


using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static TSource ElementAt<TSource> (this IEnumerable<TSource> source, int index)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			TSource ret;
			if(!TryElementAt(source, index, out ret)){
				throw new ArgumentOutOfRangeException("index");
			}
			return ret;

		}
		private static bool TryElementAt<TSource>(IEnumerable<TSource> source, int index, out TSource result)
		{
			int count = 0;
			result = default(TSource);
			if (TryFastCount (source, out count) && index > count) {
				return false;
			}

			var list = source as IList<TSource>;
			if (list != null) {
				result = list [index];
				return true;
			}

			using (var itr = source.GetEnumerator ()) {
				for (int i = -1; i < index; i++) {
					if (!itr.MoveNext ()) {
						return false;
					}
				}
				result = itr.Current;
				return true;
			}
		}
	}
}


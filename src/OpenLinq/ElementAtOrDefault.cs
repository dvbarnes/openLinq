using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static TSource ElementAtOrDefault<TSource> (this IEnumerable<TSource> source, int index)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			TSource element;
			TryElementAt (source, index, out element);
			return element;

		}
	}
}


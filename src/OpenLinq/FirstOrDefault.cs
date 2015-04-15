using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			using (var ittr = source.GetEnumerator())
			{
				if (ittr.MoveNext())
				{
					return ittr.Current;
				}
			}
			return default(TSource);
		}

		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			foreach (var el in source)
			{
				if (predicate(el))
				{
					return el;
				}
			}
			return default(TSource);
		}
	}
}

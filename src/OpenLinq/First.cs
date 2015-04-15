using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static TSource First<TSource>(this IEnumerable<TSource> source)
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
				throw new InvalidOperationException("sequence was empty");
			}
		}

		public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			foreach (var el in source)
			{
				if (predicate(el))
				{
					return el;
				}
			}
			throw new InvalidOperationException("No items matched the predicate");
		}
	}
}

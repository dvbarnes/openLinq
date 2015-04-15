using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			if (first == null)
			{
				throw new ArgumentNullException("first");
			}
			if (second == null)
			{
				throw new ArgumentNullException("second");
			}
			return ExceptImp(first, second, EqualityComparer<TSource>.Default);
		}

		public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second,
			IEqualityComparer<TSource> comparer)
		{
			if (first == null)
			{
				throw new ArgumentNullException("first");
			}
			if (second == null)
			{
				throw new ArgumentNullException("second");
			}
			return ExceptImp(first, second, comparer);
		}

		private static IEnumerable<TSource> ExceptImp<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second,
			IEqualityComparer<TSource> comparer)
		{
			HashSet<TSource> exclude = new HashSet<TSource>(second, comparer);
			foreach (var source in first)
			{
				if (exclude.Add(source))
				{
					yield return source;
				}
			}
		}
	}
}

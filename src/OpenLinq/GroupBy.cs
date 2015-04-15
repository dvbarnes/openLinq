using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenLinq
{
	public static partial class Enumerable
	{

		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector)
		{
			throw new NotImplementedException();
		}
		public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
		{
			throw new NotImplementedException();
		}
		public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
			this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			throw new NotImplementedException();
		}
		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			throw new NotImplementedException();
		}
		public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector,
			IEqualityComparer<TKey> comparer)
		{
			throw new NotImplementedException();
		}
		public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector,
			Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
		{
			throw new NotImplementedException();
		}
		public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
			this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector,
			IEqualityComparer<TKey> comparer)
		{
			throw new NotImplementedException();
		}
		public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector,
			Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			throw new NotImplementedException();
		}
	}
}

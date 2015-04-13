using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TSource> Distinct<TSource> (this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{

		}
		public static IEnumerable<TSource> Distinct<TSource> (this IEnumerable<TSource> source)
		{

		}
	}
}


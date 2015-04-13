using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static int Count<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{

		}

		public static int Count<TSource> (this IEnumerable<TSource> source)
		{
			
		}
	}
}


using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static bool Contains<TSource> (this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer){

		}
		public static bool Contains<TSource> (this IEnumerable<TSource> source, TSource value){

		}
	}
}



﻿using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TResult> Select<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, int, TResult> selector){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			return source.SelectMany(x=>Enumerable.Repeat(selector(x)));
		}
		public static IEnumerable<TResult> Select<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			return source.SelectMany(x=>Enumerable.Repeat(selector(x)));
		}
	}
}


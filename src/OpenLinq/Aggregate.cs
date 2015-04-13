using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static TResult Aggregate<TSource, TAccumulate, TResult> (this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (func == null) {
				throw new ArgumentNullException ("func");
			}
			if (resultSelector == null) {
				throw new ArgumentNullException ("resultSelector");
			}
			return AggregateImp (source, seed, func, resultSelector);
		}

		private static TResult AggregateImp<TSource, TAccumulate, TResult> (IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector){
			TAccumulate result = seed;
			foreach (var item in source) {
				result = func(result, item);
			}
			return resultSelector (result);
		}

		public static TAccumulate Aggregate<TSource, TAccumulate> (this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func){
			return Aggregate (source, seed, func, x => x);
		}

		public static TSource Aggregate<TSource> (this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (func == null) {
				throw new ArgumentNullException ("func");
			}
			return AggregateImp (source, func);
		}

		private static TSource AggregateImp<TSource> (this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func){
			using (var item = source.GetEnumerator ()) {
				if (!item.MoveNext()) {
					throw new InvalidOperationException ("Source was empty");
				}
				TSource current = item.Current;
				while (item.MoveNext ()) {
					current = func (current, item.Current);
				}
				return current;
			}
		}
	}
}


using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static decimal? Sum (this IEnumerable<decimal?> source){
			return Sum (source.Where (x => x.HasValue));
		}
		public static decimal Sum (this IEnumerable<decimal> source){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			decimal total = 0;
			checked{
				foreach (var item in source) {
					total += item;
				}
			}
			return total;
		}
		public static float? Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, float?> selector){
			return Sum(source.Select(x=>selector(x)).Where(x=>x.HasValue));
		}
		public static float Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, float> selector){
			return Sum (source.Select (x => selector (x)));
		}
		public static float? Sum (this IEnumerable<float?> source){
			return Sum (source.Where (x => x.HasValue));
		}
		public static float Sum (this IEnumerable<float> source){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			float total = 0;
			checked{
				foreach (var item in source) {
					total += item;
				}
			}
			return total;
		}
		public static double? Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, double?> selector){
			return Sum(source.Select(x=>selector(x)).Where(x=>x.HasValue));
		}
		public static double Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, double> selector){
			return Sum (source.Select (x => selector (x)));
		}
		public static double? Sum (this IEnumerable<double?> source){
			return Sum (source.Where (x => x.HasValue));
		}
		public static double Sum (this IEnumerable<double> source){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			double total = 0;
			checked{
				foreach (var item in source) {
					total += item;
				}
			}
			return total;
		}

		public static long? Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, long?> selector){
			return Sum(source.Select(x=>selector(x)).Where(x=>x.HasValue));
		}
		public static long Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, long> selector){
			return Sum (source.Select (x => selector (x)));
		}

		public static long? Sum (this IEnumerable<long?> source){
			return Sum (source.Where (x => x.HasValue));
		}
		public static long Sum (this IEnumerable<long> source){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			long total = 0;
			checked{
				foreach (var item in source) {
					total += item;
				}
			}
			return total;
		}
		public static int? Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, int?> selector){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			int total = 0;
			int? result = null;
			checked{
				foreach (var item in source.Select(x=>selector(x)).Where(x=>x.HasValue)) {
					total += item.Value;
					result = total;
				}
			}
			return result;
		}
		public static int Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, int> selector){
			return Sum (source.Select (x => selector (x)));
		}
		public static int? Sum (this IEnumerable<int?> source){
			return Sum (source.Where (x => x.HasValue));
		}
		public static int Sum (this IEnumerable<int> source){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			int total = 0;
			checked{
				foreach (var item in source) {
					total += item;
				}
			}
			return total;
		}
	}
}


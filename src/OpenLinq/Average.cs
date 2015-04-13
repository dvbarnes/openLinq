using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static decimal? Average<TSource> (this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}

		}
		public static decimal Average<TSource> (this IEnumerable<TSource> source, Func<TSource, decimal> selector)
		{
			
		}
		public static float? Average<TSource> (this IEnumerable<TSource> source, Func<TSource, float?> selector)
		{
		
		}
		public static float Average<TSource> (this IEnumerable<TSource> source, Func<TSource, float> selector)
		{
		
		}
		public static double? Average<TSource> (this IEnumerable<TSource> source, Func<TSource, double?> selector)
		{

		}
		public static double Average<TSource> (this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
		
		}
		public static double? Average<TSource> (this IEnumerable<TSource> source, Func<TSource, long?> selector)
		{
		
		}
		public static double Average<TSource> (this IEnumerable<TSource> source, Func<TSource, long> selector)
		{
		
		}
		public static double? Average<TSource> (this IEnumerable<TSource> source, Func<TSource, int?> selector)
		{
		
		}
		public static double Average<TSource> (this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
		
		}

		public static float? Average (this IEnumerable<float?> source)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}

			float total = 0;
			int count = 0;
			checked{
				foreach (float? item in source.Where(x=>x!=null)) {
					total += item.Value;
					count++;
				}
			}
			return count == 0 ? (float?) null: (float)(total/ (double)count);
		}

		public static decimal? Average (this IEnumerable<decimal?> source){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}

			decimal total = 0;
			int count = 0;
			checked{
				foreach (decimal? item in source.Where(x=>x!=null)) {
					total += item.Value;
					count++;
				}
			}
			return count == 0 ? (decimal?) null: (decimal)(total/ (decimal)count);
		}
		public static double? Average (this IEnumerable<double?> source)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}

			double total = 0;
			int count = 0;
			checked{
				foreach (decimal? item in source.Where(x=>x!=null)) {
					total += item.Value;
					count++;
				}
			}
			return count == 0 ? (double?) null: (double)(total/ (double)count);
		}

		public static double? Average (this IEnumerable<long?> source)
		{
			
		}
		public static double? Average (this IEnumerable<int?> source){

		}
		public static decimal Average (this IEnumerable<decimal> source){
		}

		public static float Average (this IEnumerable<float> source){

		}
		public static double Average (this IEnumerable<double> source){

		}
		public static double Average (this IEnumerable<long> source)
		{

		}
		public static double Average (this IEnumerable<int> source){

		}
	}

}


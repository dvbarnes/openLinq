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
			int count = 0;
			decimal result =0;
			foreach (TSource item in source) {
				decimal? current = selector(item);
				if(current.HasValue){
					result += current.Value;
					count++;
				}
			}
			return result == 0 ? (decimal?) null : (decimal)(result/(decimal) count);
		}
		public static decimal Average<TSource> (this IEnumerable<TSource> source, Func<TSource, decimal> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			int count = 0;
			decimal result =0;
			foreach (TSource item in source) {
				decimal? current = selector(item);
				if(current.HasValue){
					result += current.Value;
					count++;
				}
			}
			if (count == 0) {
				throw new InvalidOperationException ("List contains no elements");
			}
			return result/(decimal) count;
		}

		public static float? Average<TSource> (this IEnumerable<TSource> source, Func<TSource, float?> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			int count = 0;
			float result =0;
			foreach (TSource item in source) {
				float? current = selector(item);
				if(current.HasValue){
					result += current.Value;
					count++;
				}
			}
			return count == 0 ? (float?) null : (float)(result/(double) count);
		}

		public static float Average<TSource> (this IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			int count = 0;
			float result =0;
			foreach (TSource item in source) {
				float? current = selector(item);
				if(current.HasValue){
					result += current.Value;
					count++;
				}
			}
			if (count == 0) {
				throw new InvalidOperationException ("List contains no elements");
			}
			return (float)(result/(double) count);
		}

		public static double? Average<TSource> (this IEnumerable<TSource> source, Func<TSource, double?> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			int count = 0;
			double result =0;
			foreach (TSource item in source) {
				double? current = selector(item);
				if(current.HasValue){
					result += current.Value;
					count++;
				}
			}
			return count == 0 ? (double?) null : result/(double) count;
		}
		public static double Average<TSource> (this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			int count = 0;
			double result =0;
			foreach (TSource item in source) {
				double? current = selector(item);
				if(current.HasValue){
					result += current.Value;
					count++;
				}
			}
			if (count == 0) {
				throw new InvalidOperationException ("List contains no elements");
			}
			return result/(double) count;
		}
		public static double? Average<TSource> (this IEnumerable<TSource> source, Func<TSource, long?> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			int count = 0;
			long result =0;
			foreach (TSource item in source) {
				long? current = selector(item);
				if(current.HasValue){
					result += current.Value;
					count++;
				}
			}
			return count==0 ? (double?)(null) : result/(double) count;
		}
		public static double Average<TSource> (this IEnumerable<TSource> source, Func<TSource, long> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			int count = 0;
			long result =0;
			foreach (TSource item in source) {
				long current = selector(item);
				result += current;
				count++;

			}
			if (count == 0) {
				throw new InvalidOperationException ("List contains no elements");
			}
			return result/(double) count;
		}
		public static double? Average<TSource> (this IEnumerable<TSource> source, Func<TSource, int?> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			int count = 0;
			double result =0;
			foreach (TSource item in source) {
				double? current = selector(item);
				if(current.HasValue){
					result += current.Value;
					count++;
				}
			}
			return count==0 ? (double?)(null) : result/(double) count;
		}
		public static double Average<TSource> (this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			int count = 0;
			double result =0;
			foreach (TSource item in source) {
				int current = selector(item);
				result += current;
				count++;

			}
			if (count == 0) {
				throw new InvalidOperationException ("List contains no elements");
			}
			return result/(double) count;
		}

		public static float? Average (this IEnumerable<float?> source)
		{
			return source.Average (x => x);
		}

		public static decimal? Average (this IEnumerable<decimal?> source){
			return source.Average (x => x);
		}
		public static double? Average (this IEnumerable<double?> source)
		{
			return source.Average (x => x);
		}

		public static double? Average (this IEnumerable<long?> source)
		{
			return source.Average (x => x);
		}
		public static double? Average (this IEnumerable<int?> source
		){
			return source.Average (x => x);
		}
		public static decimal Average (this IEnumerable<decimal> source)
		{
			return source.Average (x => x);
		}

		public static float Average (this IEnumerable<float> source)
		{
			return source.Average (x => x);
		}
		public static double Average (this IEnumerable<double> source)
		{
			return source.Average (x => x);
		}
		public static double Average (this IEnumerable<long> source)
		{
			return source.Average (x => x);
		}
		public static double Average (this IEnumerable<int> source)
		{
			return source.Average (x => x);
		}
	}

}


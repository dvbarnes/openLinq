using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult> (this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (collectionSelector == null) {
				throw new ArgumentNullException ("collectionSelector");
			}
			if (resultSelector == null) {
				throw new ArgumentNullException ("resultSelector");
			}
			return SelectManyImp (source, collectionSelector, resultSelector);
		}

		public static IEnumerable<TResult> SelectManyImp<TSource, TCollection, TResult> (this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			var index = 0;
			foreach (var item in source) {
				foreach(var resultItem in collectionSelector(item, index++ )){
					yield return resultSelector(item, resultItem);
				}

			}
		}

		public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult> (this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (collectionSelector == null) {
				throw new ArgumentNullException ("collectionSelector");
			}
			if (resultSelector == null) {
				throw new ArgumentNullException ("resultSelector");
			}
			return SelectManyImp (source, collectionSelector, resultSelector);
		}

		public static IEnumerable<TResult> SelectManyImp<TSource, TCollection, TResult> (this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			foreach (var item in source) {
				foreach(var resultItem in collectionSelector(item)){
					yield return resultSelector(item, resultItem);
				}

			}
		}


		public static IEnumerable<TResult> SelectMany<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			return SelectManyImp (source, selector);
		}

		private static IEnumerable<TResult> SelectManyImp<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector){
			int index = 0;
			foreach (var item in source) {
				foreach(var resultItem in selector(item, index++)){
					yield return resultItem;
				}

			}
		}

		public static IEnumerable<TResult> SelectMany<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (selector == null) {
				throw new ArgumentNullException ("selector");
			}
			return SelectManyImp (source, selector);
		}
	
		private static IEnumerable<TResult> SelectManyImp<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector){
			foreach (var item in source) {
				foreach(var resultItem in selector(item)){
					yield return resultItem;
				}

			}
		}
	}
}


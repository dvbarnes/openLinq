using System;
using System.Collections.Generic;
using System.Collections;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TResult> OfType<TResult> (this IEnumerable source){
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			foreach (var item in source) {
				if (item is TResult) {
					yield return (TResult)item;
				}
			}
		}

	}
}


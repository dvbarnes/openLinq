using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static bool Any<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (predicate == null) {
				throw new ArgumentNullException ("predicate");
			}
			return AnyImp (source, predicate);
		}
		private static bool AnyImp<T>(IEnumerable<T> source, Func<T, bool> predicate){
			foreach (var item in source) {
				if (predicate (item)) {
					return true;
				} else {
					break;
				}
			}
			return false;
		}
	}
}


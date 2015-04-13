using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static bool All<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			if (predicate == null) {
				throw new ArgumentNullException ("predicate");
			}
			return AllImp (source, predicate);
		}

		private static bool AllImp<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			foreach (var item in source) {
				if(!predicate(item)){
					return false;
				}
			}
			return true;
		}
	}
}


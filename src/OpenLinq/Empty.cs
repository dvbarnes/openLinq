using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		private static class EmptyEnumerable<T>
		{
			internal static readonly T[] Instance = new T[0];       
		}

		public static IEnumerable<TResult> Empty<TResult> (){
			return EmptyEnumerable<TResult>.Instance;
		}

	}
}


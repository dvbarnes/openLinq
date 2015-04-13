using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<T> AsEnumerable<T>(IEnumerable<T> source){
			return source;
		}
	}
}


using System;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TResult> Repeat<TResult> (TResult element, int count){
			if (count < 0) {
				throw new ArgumentOutOfRangeException ("count");
			}
			return RepeatImp(element, count);
		}
		private static IEnumerable<TResult> RepeatImp<TResult> (TResult element, int count)
		{
			for(int i=0;i<count;i++){
				yield return element;
			}
		}
	}
}


﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenLinq
{
	public static partial class Enumerable
	{
		public static IEnumerable<TResult> Cast<TResult> (this IEnumerable source)
		{
			if (source == null) {
				throw new ArgumentNullException ("source");
			}
			foreach (var item in source) {
				yield return (TResult)item;
			}
		}

	}
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OpenLinq.Tests
{


	[TestFixture]
	public class AsEnumerableTests
	{
		[Test]
		public void AsEnumerable_NullAllowed()
		{
			IEnumerable<int> result = Enumerable.AsEnumerable<int>(null);
			Assert.Null(result);
		}

		[Test]
		public void AsEnumerable_DoesNotEnumerate()
		{
			var g = new ThrowingEnumerable();
			var result = Enumerable.AsEnumerable(g);
		}
		[Test]
		public void AsEnumerable_NormalSequence()
		{
			var g = Enumerable.Repeat("hello", 3);
			var result = Enumerable.AsEnumerable(g);
			Assert.AreSame(g, result);
		}

	}
}

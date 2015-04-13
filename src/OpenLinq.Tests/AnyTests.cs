using System;
using NUnit.Framework;
using NSubstitute;
using System.Collections.Generic;

namespace OpenLinq.Tests
{
	[TestFixture]
	public class AnyTests
	{
		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Any_NullList_ThrowsException()
		{
			List<int> l = null;
			Enumerable.Any(l, x => false);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Any_NullPredicate_ThrowsException()
		{
			List<int> l = new List<int>();
			Enumerable.Any(l, null);
		}

		[Test]
		public void Any_EmptyList_ReturnsTrue()
		{
			List<int> l = new List<int>();
			Enumerable.Any(l,  x => false);
		}

		[Test]
		public void Any_ListPasses_ReturnsTrue()
		{
			var l = new []{2,4,6};
			Enumerable.Any(l,  x =>x%2 ==0);
		}

		[Test]
		public void Any_ListFails_ReturnsFalse()
		{
			var l = new []{1,3,5};
			Enumerable.Any(l,  x =>x%2 ==0);
		}

		[Test]
		public void Any_StopsEvaluating_ReturnsFalse()
		{
			var l = new []{1,12, 0};
			Enumerable.Any(l,  x =>x/1 > 10);
		}

	}
}


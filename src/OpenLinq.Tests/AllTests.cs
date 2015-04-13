using System;
using NUnit.Framework;
using NSubstitute;
using System.Collections.Generic;

namespace OpenLinq.Tests
{
	[TestFixture]
	public class AllTests
	{
		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void All_NullList_ThrowsException()
		{
			List<int> l = null;
			Enumerable.All(l, x => false);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void All_NullPredicate_ThrowsException()
		{
			List<int> l = new List<int>();
			Enumerable.All(l, null);
		}

		[Test]
		public void All_EmptyList_ReturnsTrue()
		{
			List<int> l = new List<int>();
			Enumerable.All(l,  x => false);
		}

		[Test]
		public void All_ListPasses_ReturnsTrue()
		{
			var l = new []{2,4,6};
			Enumerable.All(l,  x =>x%2 ==0);
		}

		[Test]
		public void All_ListFails_ReturnsFalse()
		{
			var l = new []{2,5,6};
			Enumerable.All(l,  x =>x%2 ==0);
		}

	}
}


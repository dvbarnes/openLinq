using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace OpenLinq.Tests
{
	[TestFixture]
	public class AggregateTests
	{
		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Aggregate_NullSource_ThrowsArgumentException(){
			Enumerable.Aggregate<int,int,int> (null, 3, (x,y) => x, x => x);
		}
	
		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Aggregate_NullAccumulator_ThrowsArgumentException(){
			Enumerable.Aggregate<int,int,int> (new List<int>(), 3, null, x => x);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Aggregate_NullResultSelector_ThrowsArgumentException(){
			Enumerable.Aggregate<int,int,int> (null, 3, (x,y) => x, null);

		}

		[Test]
		public void Aggregate_UnseededAggregate_ReturnsCorrectString()
		{
			var str = new List<string>{"a","b","c"};
			Assert.AreEqual("abc", str.Aggregate ((x, y) => x + y) );
		}

		[Test]
		public void Aggregate_SeededAggregate_ReturnsCorrectString()
		{
			var str = new List<string>{"a","b","c"};
			Assert.AreEqual("a-abc", str.Aggregate ("a-", (x, y) => x + y) );
		}

		[Test]
		public void Aggregate_SeededAggregateWithResultSelect_ReturnsCorrectString()
		{
			var str = new List<string>{"a","b","c"};
			Assert.AreEqual("a-a", str.Aggregate ("a-", (x, y) => x + y,x=>x.Substring(0,3)) );
		}

		[Test]
		public void Aggregate_OneItem_ReturnsCorrectString()
		{
			var str = new List<string>{"a"};
			Assert.AreEqual("a", str.Aggregate ((x,y)=>x+y) );
		}

	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OpenLinq.Tests
{
	[TestFixture]
	public class CastTests
	{
		[Test]
		public void Cast_ItemsAllTheSame_ReturnsList()
		{
			var list = Enumerable.Repeat("hello", 3);
			var newList = Enumerable.Cast<string>(list);
			Assert.AreSame(list, newList);
		}
		
		[Test]
		[ExpectedException(typeof(InvalidCastException))]
		public void Cast_ItemsNotAllTheSame_ThrowsException()
		{
			object[] list = new object[] {"hello", 1, "world"};
			var result = Enumerable.Cast<string>(list);

		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Cast_NullList_ThrowsException()
		{
			Enumerable.Cast<string>(null);
		}

	}
}

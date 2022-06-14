using NUnit.Framework;
using System;

namespace Module_1.Tests
{
    [TestFixture]
    internal class ArrayMinTest
    {
		private ArrayMin arrayMin;

		[SetUp]
		public void ArrayMinTestSetUp()
		{
			arrayMin = new ArrayMin();
		}

		private static readonly object[] ArrayForTask1 =
		{
			new object[] { new int[] { 40, 50, 60, 10, 20, 40, 70, 80 }, 3 },
		};

		[Test(Description = "Вывести массив с самыми маленькими значениями в заданном количестве")]		
		[TestCaseSource(nameof(ArrayForTask1))]
		public void SmallestElementsOfTheArrayTest(int[] array, int countSmallElements)
		{
			var actual = arrayMin.SmallestElementsOfTheArray(array, countSmallElements);
			Assert.That(actual.Length, Is.EqualTo(countSmallElements));

			Array.Sort(array);

            for (int i = 0; i < actual.Length; i++)
            {
				Assert.That(actual[i], Is.EqualTo(array[i]));
            }
		}
	}
}

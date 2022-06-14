using NUnit.Framework;
using System;
using System.Linq;

namespace Module_1.Tests
{
    [TestFixture]
    internal class ArrayMaxTest
    {
        private ArrayMax arrayMax;

        [SetUp]
        public void ArrayMaxTestSetUp()
        {
            arrayMax = new ArrayMax();
        }

        private static readonly object[] ArrayForTask1 = new object[]
        {
            new int[] { -1000, -100, -10, -1, -1 }
        };

        [Test(Description = "Нахождение самого большого числа в массиве")]
        [TestCaseSource(nameof(ArrayForTask1))]
        public void MaximumNumberInTheArrayTest(int[] array)
        {
            var actual = arrayMax.MaximumNumberInTheArray(array);
            var expected = -1;
            Assert.That(actual,Is.EqualTo(expected));
        }

        private static readonly object[] ArrayForTask2 = new object[]
        {
            new int[] { 4, 1, 5, 8, 9 },
            new int[] { 5, 7, 10, 9, 5 },
            new int[] { 3, 5, 6, 4, 4 }
        };

        [Test(Description = "Нахождение самого большого числа в массиве")]
        [TestCaseSource(nameof(ArrayForTask2))]
        public void MinimumNumberInTheArrayTest(int[] array)
        {
            var actual = arrayMax.MinimumNumberInTheArray(array);
            Array.Sort(array);
            var expected = array[0];
            Assert.That(actual, Is.EqualTo(expected));
        }

        private static readonly object[] ArrayForTask3 =
        {
            new int[] { 9999 },
            new int[] { 9, 4, 1, 8, 7, 9, 4, 1, 8, 7, 8, 7, 18, 3, 13, 6, 5 },
            new int[] { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue }
        };

        [Test(Description = "Найти среднее значение в массиве")]
        [TestCaseSource(nameof(ArrayForTask3))]
        public void AverageValueInTheArrayTest(int[] array)
        {
            var actual = arrayMax.AverageValueInTheArray(array);
            var expected = array.Average();
            Assert.That(actual, Is.EqualTo(expected));
        }

        private static readonly object[][] ArrayForTask4 =
        {
            new int[][]
            {
                new int [] {11, 2, 3, 4, 5, 6, 7, 8, 9, 0},
                new int [] {12, 2, 3, 4, 5, 6, 7, 8, 9, 0},
                new int [] {13, 2, 3, 4, 5, 6, 7, 8, 9, 0},
                new int [] {14, 2, 3, 4, 5, 6, 7, 8, 9, 0},
                new int [] {15, 2, 3, 4, 5, 6, 7, 8, 9, 0},
                new int [] {16, 2, 3, 4, 5, 6, 7, 8, 9, 0},
                new int [] {17, 2, 3, 4, 5, 6, 7, 8, 9, 0},
                new int [] {18, 2, 3, 4, 5, 6, 7, 8, 9, 0},
                new int [] {19, 2, 3, 4, 5, 6, 7, 8, 9, 0},
                new int [] {10, 2, 3, 4, 5, 6, 7, 8, 9, 0}
            }
        };

        [Test(Description = "Найти самого выгодного клиента")]
        [TestCaseSource(nameof(ArrayForTask4))]
        public void ProfitableClientTest(int[][] arrays)
        {
            var actual = arrayMax.ProfitableClient(arrays);
            var expected = 8;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

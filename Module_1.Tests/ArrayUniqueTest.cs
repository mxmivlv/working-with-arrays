using NUnit.Framework;
using System.Collections.Generic;

namespace Module_1.Tests
{
    [TestFixture]
    internal class ArrayUniqueTest
    {
        private ArrayUnique arrayUnique;

        [SetUp]
        public void ArrayUniqueSortedTestSetUp()
        {
            arrayUnique = new ArrayUnique();
        }

        [Test(Description = "Найти все уникальные символы в слове")]
        [TestCase("АААФФФФФФФЖЫЫЫЫБЫРВАААААЛГГГХЫХЫБЛИА")]
        public void UniqueLettersTest(string word)
        {
            var actual = arrayUnique.UniqueLetters(word);
            var expected = new List<char>() { 'А', 'Ф', 'Ж', 'Ы', 'Б', 'Р', 'В', 'Л', 'Г', 'Х', 'И' };

            Assert.That(actual, Is.EqualTo(expected));
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.That(actual[i], Is.EqualTo(expected[i]));
            }
        }

        private static readonly object[] ArrayForTask2 =
        {
            new int[][]
            {
                new int []  {12391203, 3828382, 334934939, 1234566},
                new int []  { 45345345, 5341312, 55345345},
                new int []  {334934939, 1234122},
            }
        };

        [Test(Description = "Найти уникальное число в зубчатом массиве. Если число повторяется, возвращает его. Если нет, то -1")]
        [TestCaseSource(nameof(ArrayForTask2))]
        public void UniqueNumbersFromTheArrayTest(int[][] report)
        {
            var actual = arrayUnique.UniqueNumbersFromTheArray(report);
            Assert.That(actual,Is.EqualTo(334934939).Or.EqualTo(-1));
        }
    }
}

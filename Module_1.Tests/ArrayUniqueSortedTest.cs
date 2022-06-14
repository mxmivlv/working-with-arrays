using NUnit.Framework;
using System.Collections.Generic;

namespace Module_1.Tests
{
    internal class ArrayUniqueSortedTest
    {
        private ArrayUniqueSorted arrayUniqueSorted;

        [SetUp]
        public void ArrayUniqueSortedTestSetUp()
        {
            arrayUniqueSorted = new ArrayUniqueSorted();
        }

        private static readonly object[] ArrayForTask1 =
        {
            new long[]
            {
                79000000000L,
                79000000000L,
                79000000001L,
                79000000002L,
                79000000002L,
                79000000003L,
                79000000003L,
                79000000003L,
                79000000003L,
                79000000004L
            }
        };

        [Test(Description = "Создать список номеров и сколько раз они повторяются")]
        [TestCaseSource(nameof(ArrayForTask1))]
        public void NumberAndNumberOfApplicationsTest(long[] numbers)
        {
            var actual = arrayUniqueSorted.NumberAndNumberOfApplications(numbers);
            var expected = new Dictionary<long, long>()
            {
                { 79000000000L, 2},
                { 79000000001L, 1},
                { 79000000002L, 2},
                { 79000000003L, 4},
                { 79000000004L, 1}
            };

            Assert.That(actual.Count, Is.EqualTo(expected.Count));

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.That(actual.Values, Is.EqualTo(expected.Values));
                Assert.That(actual.Keys, Is.EqualTo(expected.Keys));
            }
        }


        [Test(Description = "Вывести словарь с названием валюты и ее среднем значением")]
        [TestCase("BTC:42\r\nBTC:600\r\nBTC:900\r\nDOGE:123456\r\nDOGE:69420\r\nETH:220\r\nETH:666\r\nXMR:14\r\nXMR:88")]
        public void CurrencyAndItAaverageValueTest(string file)
        {
            var actual = arrayUniqueSorted.CurrencyAndItAaverageValue(file);

            var expected = new Dictionary<string, double>()
            {
                { "BTC", 514},
                { "DOGE", 96438},
                { "ETH", 443},
                { "XMR", 51}
            };

            Assert.That(actual.Count, Is.EqualTo(expected.Count));

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.That(actual.Values, Is.EqualTo(expected.Values));
                Assert.That(actual.Keys, Is.EqualTo(expected.Keys));
            }
        }
    }
}

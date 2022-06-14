using System.Collections.Generic;

namespace Module_1
{
    public sealed class ArrayMax
    {
		// Task #1
		// Нахождение максимального числа
		public int MaximumNumberInTheArray(int[] array)
		{
			int maximumNumber = array[0];

			for (int i = 1; i < array.Length; i++)
			{
				if (maximumNumber < array[i])
					maximumNumber = array[i];
			}
			return maximumNumber;
		}

		// Task #2
		// Нахождение минимального числа
		public int MinimumNumberInTheArray(int[] array)
		{
			int minimumNumber = array[0];

			for (int i = 1; i < array.Length; i++)
			{
				if (minimumNumber > array[i])
					minimumNumber = array[i];
			}
			return minimumNumber;
		}

		// Task #3
		// Нахождение среднего значения массива
		public double AverageValueInTheArray(int[] array)
		{
			long count = array.Length;
			double tempNumbers = array[0];

			for (int i = 1; i < array.Length; i++)
			{
				tempNumbers += array[i];
            }
			return tempNumbers / count;
		}

		// Task #4
		// Нахождение самого выгодного заказчика
		public int ProfitableClient(int[][] array)
		{
			// Индекс заказчика для возврата
			int indexCustomer = 0;
			// Доходы от заказчиков
			int incomeCustomer = 0;
			// Коллекция в которой собраны все доходы по заказчикам
			List<int> collectionIncomeCustomer = new List<int>();

			for (int i = 0; i < array.Length; i++)
			{
				for (int q = 0; q < array[i].Length; q++)
				{
					incomeCustomer += array[i][q];
				}
				collectionIncomeCustomer.Add(incomeCustomer);
				incomeCustomer = 0;
			}

			// Самое маленькое число
			int tempNumberMin = int.MinValue;

			for (int i = 0; i < collectionIncomeCustomer.Count; i++)
			{
				// Сравниваем и ищем самое большое число
				if (tempNumberMin < collectionIncomeCustomer[i])
				{
					tempNumberMin = collectionIncomeCustomer[i];
					indexCustomer = i;
				}
			}
			return indexCustomer;
		}
	}
}

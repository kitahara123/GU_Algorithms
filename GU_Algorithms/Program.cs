using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Paderov Evgeny
/// </summary>
namespace GU_Algorithms
{

	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 10, 23, 2, 31, 3, 5, 3, 2, 7, 8, 8, 123, 345, 3324, 12, 23, 5, 23, 3, 43, 4, 2, 346, 7, 56, 3, 4, 22, 57 };
			int[] arr1 = arr.ToArray();
			int[] arr2 = arr.ToArray();
			Console.WriteLine("Пузырьковая сортировка: " + BubbleSort(arr));
			Console.WriteLine("Улучшенная пузырьковая сортировка: " + BubbleSortImproved(arr1));
			Console.WriteLine("Сортировка вставками: " + InsertSort(arr2));

			foreach (int i in arr1)
				Console.Write(i + " ");

			Console.WriteLine();
			Console.WriteLine("Элемент найден на индексе: " + BinarySearch(23, arr));

			Console.ReadKey();
		}

		static int BubbleSort(int[] arr)
		{

			int counter = 0;
			for (int i = 0; i < arr.Length; i++)
				for (int j = 0; j < arr.Length - 1; j++)
				{
					counter++;
					if (arr[j] > arr[j + 1])
					{
						var t = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = t;
					}
				}
			return counter;
		}

		// 1. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и не оптимизированной программы. 
		//Написать функции сортировки, которые возвращают количество операций.
		static int BubbleSortImproved(int[] arr)
		{
			int counter = 0;
			int flag = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				flag = 0;
				for (int j = 0; j < arr.Length - 1; j++)
				{
					counter++;
					if (arr[j] > arr[j + 1])
					{
						flag = 1;
						var t = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = t;
					}
				}
				if (flag == 0) return counter;
			}
			return counter;
		}

		// 3. Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный массив. Функция возвращает индекс найденного элемента или -1, если элемент не найден.
		static int BinarySearch(int num, int[] arr)
		{
			int L = 0, R = arr.Length - 1;
			while (L <= R)
			{
				int m = (L + R) / 2;

				if (arr[m] < num)
					L = m + 1;
				else
					R = m - 1;
				if (arr[m] == num) return m;
			}
			return -1;

		}

		static int InsertSort(int[] a)
		{
			int counter = 0;
			for (int i = 0; i < a.Length; i++)
			{
				int t = a[i];
				int j = i;
				while (j > 0 && a[j - 1] > t)
				{
					counter++;
					var temp = a[j];
					a[j] = a[j - 1];
					a[j - 1] = temp;
					j--;
				}
			}
			return counter;
		}



	}



}


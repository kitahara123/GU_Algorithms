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
		// 2. Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.
		// Я не смог разобраться как перевернуть матрицу так же как в методичке
		static char[] a = new char[] { 'a', 'l', 'l', 'y', 'o', 'u', 'b', 'a', 's', 't', 'a', 'r', 'd', 's' };
		static char[] b = new char[] { 'g', 'e', 't', 'f', 'i', 'r', 'e', 'd', 'u', 'p' };

		//static char[] a = new char[] { 'g', 'e', 'e', 'k', 'b', 'r', 'a', 'i', 'n', 's' };
		//static char[] b = new char[] { 'g', 'e', 'e', 'k', 'm', 'i', 'n', 'd', 's' };
		static int[,] ab = new int[a.Length, b.Length];

		static void Main(string[] args)
		{
			Console.WriteLine(lcs_length(0, 0));

			Console.WriteLine();

			Console.Write("  ");
			foreach (char i in a)
				Console.Write(i + " ");

			Console.WriteLine();

			for (int i = 0; i < ab.GetLength(1); i++)
			{
				Console.Write(b[i] + " ");
				for (int j = 0; j < ab.GetLength(0); j++)
				{
					Console.Write(ab[j, i] + " ");

				}
				Console.WriteLine();
			}

			Console.ReadKey();
		}

		static int lcs_length(int i, int j)
		{
			int res = 0;
			if (a.Length <= i || b.Length <= j)
			{
				return 0;
			}
			else if (a[i] == b[j])
			{
				res = 1 + lcs_length(i + 1, j + 1);
			}
			else
			{
				res = max(lcs_length(i + 1, j), lcs_length(i, j + 1));
			}

			ab[i, j] = res;
			return res;
		}
		static int max(int a, int b)
		{
			return a > b ? a : b;
		}
	}



}


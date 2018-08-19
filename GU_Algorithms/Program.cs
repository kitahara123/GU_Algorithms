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
			#region 1. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах.
			int m = 70;
			double h = 1.75;

			CalculateMassIndex(m, h);
			#endregion

			#region 2. Найти максимальное из четырех чисел. Массивы не использовать.
			int a = 10, b = 20, c = 23, d = 5;

			FindMaxNumber(a, b, c, d);
			#endregion

			#region 3. Написать программу обмена значениями двух целочисленных переменных:
			SwapNumbers(10, 16);

			#endregion

			#region 5. С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.
			Random rand = new Random();
			int month = rand.Next(1, 13);

			Console.WriteLine(GetSeason(month));
			#endregion

			#region 6. Ввести возраст человека (от 1 до 150 лет) и вывести его вместе с последующим словом «год», «года» или «лет».
			int age = rand.Next(1, 151);

			Declension(age);
			#endregion

			#region 7. С клавиатуры вводятся числовые координаты двух полей шахматной доски (x1,y1,x2,y2). Требуется определить, относятся поля к одному цвету или нет.
			int x1 = 3, y1 = 4, x2 = 7, y2 = 6;

			IsSameColor(x1, y1, x2, y2);

			#endregion

			#region 10. Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления определить, имеются ли в записи числа N нечетные цифры. Если имеются, то вывести True, если нет — вывести False.
			int number = 1258869048;

			Console.WriteLine(FindUneven(number));
			Console.ReadKey();
			#endregion

			#region 11. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее арифметическое всех положительных четных чисел, оканчивающихся на 8.

			int[] arr = new int[] { 124, 123, 128, 1678, 247, 175, 34, 628, 28, 156, 0, 288, 745, 11};

			EightBalance(arr);
			#endregion

			#region 12. Написать функцию нахождения максимального из трех чисел.

			FindMaxNumber(123, 121, 6875);
			#endregion

			Console.ReadKey();
		}
		
		//1. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах.
		private static void CalculateMassIndex(int m, double h)
		{
			Console.WriteLine(m / (h * h));
			Console.ReadKey();
		}

		//2. Найти максимальное из четырех чисел. Массивы не использовать.
		private static void FindMaxNumber(int a, int b, int c, int d)
		{
			int res1 = a > b ? a : b;
			int res2 = c > d ? c : d;
			Console.WriteLine(res1 > res2 ? res1 : res2);
			Console.ReadKey();
		}

		//3. Написать программу обмена значениями двух целочисленных переменных:
		private static void SwapNumbers(int v1, int v2)
		{
			Console.WriteLine($"var1 = {v1} var2 = {v2}");
			v1 = v2 + v1;
			v2 = v1 - v2;
			v1 = v1 - v2;
			Console.WriteLine($"var1 = {v1} var2 = {v2}");
			Console.ReadKey();
		}

		//5. С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.
		private static string GetSeason(int month)
		{
			Console.WriteLine($"month = {month}");

			if (month > 12 || month < 1) return "Not A Month";
			switch (month)
			{
				case 12:
				case 1:
				case 2:
					return "Winter";
				case 3:
				case 4:
				case 5:
					return "Spring";
				case 6:
				case 7:
				case 8:
					return "Summer";
				default:
					return "Autumn";
			}

		}

		//6. Ввести возраст человека (от 1 до 150 лет) и вывести его вместе с последующим словом «год», «года» или «лет».
		private static void Declension(int age)
		{
			string y = "Лет";
			int t10 = age % 10;
			int t100 = age % 100;

			if (t10 == 1) y = "Год";
			if (t10 > 1 && t10 <= 4) y = "Года";
			if (t100 >= 11 && t100 <= 14) y = "Лет";

			Console.WriteLine(age + " " + y);
			Console.ReadKey();
		}

		//7. С клавиатуры вводятся числовые координаты двух полей шахматной доски(x1, y1, x2, y2). Требуется определить, относятся поля к одному цвету или нет.
		private static void IsSameColor(int x1, int y1, int x2, int y2)
		{
			bool res = false;
			int sum1 = x1 + y1;
			int sum2 = x2 + y2;

			if (sum1 % 2 == 0 && sum2 % 2 == 0) res = true;
			if (sum1 % 2 > 0 && sum2 % 2 > 0) res = true;

			Console.WriteLine(res);
			Console.ReadKey();
		}

		//10. Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления определить, имеются ли в записи числа N нечетные цифры. Если имеются, то вывести True, если нет — вывести False.
		private static bool FindUneven(int number)
		{
			while (number > 0)
			{
				Console.WriteLine(number);
				if ((number % 10) % 2 > 0) return true;
				number /= 10;
			}
			return false;
		}

		//11. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее арифметическое всех положительных четных чисел, оканчивающихся на 8.
		private static void EightBalance(int[] arr)
		{
			int x = arr[0];
			int i = 1;
			int sum = 0;
			int col = 1;
			while (x != 0 && i < arr.Length)
			{
				if (x % 10 == 8)
				{
					Console.Write(x + " ");
					sum += x;
					col++;
				}
				x = arr[i];
				i++;
			}

			Console.WriteLine("\n" + sum / col);
			Console.ReadKey();
		}

		//12. Написать функцию нахождения максимального из трех чисел.
		private static void FindMaxNumber(int a, int b, int c)
		{
			int res = a > b ? a : b;
			if (res < c) res = c;
			Console.WriteLine(res);
			Console.ReadKey();
		}



	}
}

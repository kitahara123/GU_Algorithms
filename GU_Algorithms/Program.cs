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

			int arg = Convert.ToInt32(Console.ReadLine());
			int arg1 = Convert.ToInt32(Console.ReadLine());
			#region 1. Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.
			ToBinary(arg);
			#endregion

			#region 2. Реализовать функцию возведения числа a в степень b: a. без рекурсии;	b. рекурсивно;
			Console.WriteLine(Pwr(arg, arg1));
			Console.WriteLine(PwrReq(arg, arg1));
			#endregion

			#region 3. Первая команда увеличивает число на экране на 1, вторая увеличивает это число в 2 раза. Сколько существует программ, которые число 3 преобразуют в число 20?
			Console.WriteLine(Calc(3, 20));
			#endregion

			Console.ReadKey();
		}



		// 1. Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.
		private static void ToBinary(int num)
		{
			if (num == 0) return;
			int r = num % 2;
			ToBinary(num / 2);
			Console.Write(r);
		}

		// 2. Реализовать функцию возведения числа a в степень b: a. без рекурсии
		private static long Pwr(int a, int b)
		{
			if (a == 0) return 0;
			if (b == 0 || a == 1) return 1;

			long t = a;
			while (b > 1)
			{
				t = t * a;
				b--;
			}
			return t;
		}

		// 2. Реализовать функцию возведения числа a в степень b: b. рекурсивно;
		private static long PwrReq(int a, int b)
		{
			if (a == 0) return 0;
			if (b == 0 || a == 1) return 1;
			if (b == 1) return a;

			if (b > 2) return a * PwrReq(a, b - 1);
			else return a * a;

		}

		/* 3. Первая команда увеличивает число на экране на 1, вторая увеличивает это число в 2 раза. Сколько существует программ, которые число 3 преобразуют в число 20?
		 * Рекурсивно: 
		 
		*/
		private static int Calc(int val, int target)
		{
			int res = 0;
			if (val == target) res = 1;

			if (val * 2 <= target)
				res += Calc(val * 2, target);
			if (val + 1 <= target)
				res += Calc(val + 1, target);

			return res;
		}




	}
}

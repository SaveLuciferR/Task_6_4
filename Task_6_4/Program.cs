using System;

namespace Task_6_4
{
	class Program 
	{
		static void Main(string[]agrs)
		{
			try
			{
				int[][] arr;
				Console.WriteLine("Введите размер массива");
				Console.Write("n = ");
				int n = Convert.ToInt32(Console.ReadLine());

				if (n < 1)
				{
					throw new Exception();
				}

				arr = new int[n][];

				for (int i = 0; i < n; i++)
				{
					arr[i] = new int[n];
				}

				int[] res = new int[n];

				Console.WriteLine("Заполните массив");

				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						Console.Write("{0}, {1}: ", i, j);
						arr[i][j] = Convert.ToInt32(Console.ReadLine());
					}
				}


				for (int i = 0; i < n; i++)
				{
					res[i] = 0;

					for (int j = 0; j < n; j++)
					{
						if (arr[j][i] % 2 == 0 && arr[j][i] > 0)
						{
							res[i] += arr[j][i];
						}
					}
				}

				Console.WriteLine("\nИзначальный массив");

				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						Console.Write("{0}\t", arr[i][j]);
					}
					Console.WriteLine();
				}

				Console.WriteLine("\nРезультат");

				for (int i = 0; i < n; i++)
				{
					Console.Write("{0}\t", res[i]);
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Введите корректные значния");
			}
			catch
			{
				Console.WriteLine("Размер массива должен быть натуральным числом");
			}
		}	
	}
}
using System.Diagnostics;

namespace LaboratoryWork_2_2
{
	internal class Program
	{
		private static void Main()
		{
			Stopwatch sw = new();
			sw.Restart();
			IsSimple(1000, 5000);
			sw.Stop();
			long x = sw.ElapsedMilliseconds;
			Console.WriteLine(x);
		}

		private static void IsSimple(int firstnumber, int secondnumber)
		{
			List<int> list = new();
			for (int i = firstnumber; i < secondnumber; i++)
			{
				list.Add(i);
				for (int j = 2; j < i / 2; j++)
				{
					if (i % j == 0)
					{
						list.Remove(i);
						break;
					}
				}

			}
			list.ForEach(x => Console.WriteLine(x));
		}
	}
}
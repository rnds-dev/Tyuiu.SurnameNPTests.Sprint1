using Tyuiu.SurnameNPTests.Sprint1.Task2.V10.Lib;

namespace Tyuiu.SurnameNPTests.Sprint1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();

			Console.WriteLine(ds.ConvertMetreToInchs(0));
			Console.ReadKey();
		}
	}
}
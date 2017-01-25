using System;

namespace RefactorVolumeOfPiramid
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double lenght, width, height = 0;

			Console.Write("Length: ");

			lenght = double.Parse(Console.ReadLine());

			Console.Write("Width: ");

			width = double.Parse(Console.ReadLine());

			Console.Write("Height: ");

			height = double.Parse(Console.ReadLine());

			height = (lenght * width * height) / 3;

			Console.WriteLine("Pyramid Volume: {0:F2}", height);
		}
	}
}

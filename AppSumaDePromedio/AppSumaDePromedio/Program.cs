using System;

namespace AppSumaDePromedio
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double num1, num2, num3, num4, suma, promedio;
			Console.WriteLine ("Programa que calcula suma");
			Console.WriteLine ("Digite numero1:");
			num1=double.Parse(Console.ReadLine());
			Console.WriteLine ("Digite numero2:");
			num2=double.Parse(Console.ReadLine());
			Console.WriteLine ("Digite numero3:");
			num3=double.Parse(Console.ReadLine());
			Console.WriteLine ("Digite numero4:");
			num4=double.Parse(Console.ReadLine());
			suma = num1 + num2 + num3 + num4;
			promedio = suma / 4;
			Console.WriteLine ("La suma es :"+suma+   "El promedio es: "  +promedio);
			Console.ReadKey ();


		}
	}
}

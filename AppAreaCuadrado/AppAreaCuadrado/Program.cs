using System;

namespace AppAreaCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			float lado, perimetro, area;
			Console.WriteLine ("Programa que calcula el perimetro de un Cuadrado");
			Console.WriteLine ("Digite lado:");
			lado = float.Parse (Console.ReadLine ());
			area = lado * lado;
			Console.WriteLine("El area de un cuadrado:"+area);
			perimetro = 4 * lado;
			Console.WriteLine("El perimetro es:"+perimetro);
			Console.ReadKey ();
		}
	}
}

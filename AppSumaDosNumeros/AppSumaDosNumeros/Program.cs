using System;

namespace AppSumaDosNumeros
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//declarar variables
			int numero1, numero2, suma;
			string lineal;
			Console.WriteLine ("Programa que calculala la suma de dos numeros!");
			Console.WriteLine ( "Digite Numero 1:");
			lineal = Console.ReadLine ();
			numero1 = int.Parse (lineal);
			Console.WriteLine ( "Digite Numero 2:");
			lineal = Console.ReadLine ();
			numero2 = int.Parse (lineal);
			suma = numero1 + numero2;
			Console.WriteLine ( "La suma es:"+suma);
			Console.ReadKey ();

		}
	}
}

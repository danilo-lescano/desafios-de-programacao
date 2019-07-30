using System;

class URI_1018 {
	static void Main(string[] args) {
		int n = int.Parse(Console.ReadLine());
		int aux;
		Console.WriteLine(n);

		aux = n/100;
		Console.WriteLine("{0} nota(s) de R$ 100,00", aux);

		n = n%100;
		aux = n/50;
		Console.WriteLine("{0} nota(s) de R$ 50,00", aux);

		n = n%50;
		aux = n/20;
		Console.WriteLine("{0} nota(s) de R$ 20,00", aux);

		n = n%20;
		aux = n/10;
		Console.WriteLine("{0} nota(s) de R$ 10,00", aux);

		n = n%10;
		aux = n/5;
		Console.WriteLine("{0} nota(s) de R$ 5,00", aux);

		n = n%5;
		aux = n/2;
		Console.WriteLine("{0} nota(s) de R$ 2,00", aux);

		n = n%2;
		aux = n;
		Console.WriteLine("{0} nota(s) de R$ 1,00", aux);
	}
}
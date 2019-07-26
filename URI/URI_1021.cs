using System;

class URI_1021 {
	static void Main(string[] args) {
		string[] str = Console.ReadLine().Split('.');
		double n = double.Parse(str[0]);
		double n2 = double.Parse(str[1]);
		int aux;

		Console.WriteLine("NOTAS:");
		aux = (int)(n/100);
		Console.WriteLine("{0} nota(s) de R$ 100.00", aux);
		aux = (int)((n%100)/50);
		Console.WriteLine("{0} nota(s) de R$ 50.00", aux);
		aux = (int)(((n%100)%50)/20);
		Console.WriteLine("{0} nota(s) de R$ 20.00", aux);
		aux = (int)((((n%100)%50)%20)/10);
		Console.WriteLine("{0} nota(s) de R$ 10.00", aux);
		aux = (int)(((((n%100)%50)%20)%10)/5);
		Console.WriteLine("{0} nota(s) de R$ 5.00", aux);
		aux = (int)((((((n%100)%50)%20)%10)%5)/2);
		Console.WriteLine("{0} nota(s) de R$ 2.00", aux);

		Console.WriteLine("MOEDAS:");
		aux = (int)((((((n%100)%50)%20)%10)%5)%2);
		Console.WriteLine("{0} moeda(s) de R$ 1.00", aux);
		n = n2;
		aux = (int)((n%100)/50);
		Console.WriteLine("{0} moeda(s) de R$ 0.50", aux);
		aux = (int)(((n%100)%50)/25);
		Console.WriteLine("{0} moeda(s) de R$ 0.25", aux);
		aux = (int)((((n%100)%50)%25)/10);
		Console.WriteLine("{0} moeda(s) de R$ 0.10", aux);
		aux = (int)(((((n%100)%50)%25)%10)/5);
		Console.WriteLine("{0} moeda(s) de R$ 0.05", aux);
		aux = (int)(((((n%100)%50)%25)%10)%5);
		Console.WriteLine("{0} moeda(s) de R$ 0.01", aux);
	}
}
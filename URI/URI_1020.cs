using System;

class URI_1020 {
	static void Main(string[] args) {
		int x = int.Parse(Console.ReadLine());
		int ano = x/365;
		int mes = (x%365)/30;
		int dia = (x%365)%30;
		
		Console.WriteLine("{0} ano(s)", ano);
		Console.WriteLine("{0} mes(es)", mes);
		Console.WriteLine("{0} dia(s)", dia);
	}
}
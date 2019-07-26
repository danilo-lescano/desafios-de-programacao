using System;

class URI_1019 {
	static void Main(string[] args) {
		int x = int.Parse(Console.ReadLine());
		int segundos = x%60;
		x -= x%60;
		int minutos = (x/60)%60;
		x -= (x/60)%60;
		int horas = (x/3600);
		
		Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
	}
}
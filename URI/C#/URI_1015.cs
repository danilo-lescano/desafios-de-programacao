using System;

class URI_1015 {
	static void Main(string[] args) {
		string[] str = Console.ReadLine().Split(' ');
		double x1 = double.Parse(str[0]);
		double y1 = double.Parse(str[1]);
		str = Console.ReadLine().Split(' ');
		double x2 = double.Parse(str[0]);
		double y2 = double.Parse(str[1]);
		
		Console.WriteLine("{0:F4}", Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) );
	}
}
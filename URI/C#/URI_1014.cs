using System; 

class URI_1014 {
	static void Main(string[] args) {
		int km = int.Parse(Console.ReadLine());
		double l = double.Parse(Console.ReadLine());

		Console.WriteLine("{0:F3} km/l", km/l);
	}
}
using System; 

class URI_2780 {
	static void Main(string[] args) {
		int x = int.Parse(Console.ReadLine());
		Console.WriteLine(x <= 800 ? 1 : x <= 1400 ? 2 : 3);
	}
}
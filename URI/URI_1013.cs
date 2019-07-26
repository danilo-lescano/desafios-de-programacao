using System; 

class URI_1013 {
	static void Main(string[] args) {
		string[] str = Console.ReadLine().Split(' ');
		int a = int.Parse(str[0]);
		int b = int.Parse(str[1]);
		int c = int.Parse(str[2]);

		if(a > b && a > c)
			Console.WriteLine(a + " eh o maior");
		else if(b > c)
			Console.WriteLine(b + " eh o maior");
		else
			Console.WriteLine(c + " eh o maior");
	}
}
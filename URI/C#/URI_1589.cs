using System;

class URI_1589 {
	static void Main(string[] args) {
		int n = int.Parse(Console.ReadLine());
		int r;
		while(n > 0){
			string[] str = Console.ReadLine().Split(' ');
			r = int.Parse(str[0]) + int.Parse(str[1]);
			Console.WriteLine(r);
			n--;
		}
	}
}
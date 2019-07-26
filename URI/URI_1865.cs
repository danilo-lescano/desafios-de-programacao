using System;

class URI_1865 {
	static void Main(string[] args) {
		int n = int.Parse(Console.ReadLine());
		for(int i = 0; i < n; i++){
			string[] str = Console.ReadLine().Split(' ');
			if(str[0].ToUpper().Equals("THOR"))
				Console.WriteLine("Y");
			else
				Console.WriteLine("N");
		}
	}
}
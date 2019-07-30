using System; 

class URI_1097 {
	static void Main(string[] args) {
		for(int i = 1; i <= 9; i+=2)
			for(int j = i+6; j > i + 3; j--)
				Console.WriteLine("I={0} J={0}", i, j);
	}
}
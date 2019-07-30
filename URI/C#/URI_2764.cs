using System; 

class URI_2764 {
	static void Main(string[] args) {
		string[] str = Console.ReadLine().Split('/');
		string d = str[0];
		string m = str[1];
		string a = str[2];

		Console.WriteLine(m + "/" + d + "/" + a);
		Console.WriteLine(a + "/" + m + "/" + d);
		Console.WriteLine(d + "-" + m + "-" + a);
	}
}
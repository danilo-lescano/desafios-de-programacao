using System;

class URI_1026{
	static void Main(string[] args){
		string[] str;
		string str_aux;
		uint a, b;
        while(!string.IsNullOrEmpty(str_aux = Console.ReadLine())){
			str = str_aux.Split(' ');
			a = uint.Parse(str[0]);
			b = uint.Parse(str[1]);
			Console.WriteLine(a ^ b);
		}
	}
}
using System;

class URI_1024{
	static void Main(string[] args){
		int n = int.Parse(Console.ReadLine());

		int minmin = (int)('a');
		int minmax = (int)('z');
		int maxmin = (int)('A');
		int maxmax = (int)('Z');

		for(int i = 0; i < n; i++){
			string str = Console.ReadLine();
			string str_aux = "";

			for(int j = 0; j < str.Length; j++){
				if(
					((int)str[j] >= minmin && (int)str[j] <= minmax) ||
					((int)str[j] >= maxmin && (int)str[j] <= maxmax)
				)
					str_aux += (char)(str[j] + 3);
				else
					str_aux += str[j];
			}

			str = str_aux;
			str_aux = "";
			for(int j = str.Length - 1; j >= 0; j--)
				str_aux += str[j];

			str = str_aux;
			str_aux = "";
			for(int j = 0; j < str.Length; j++){
				if(j < str.Length/2)
					str_aux += str[j];
				else
					str_aux += (char)(str[j] - 1);
			}

			Console.WriteLine(str_aux);
		}
	}
}
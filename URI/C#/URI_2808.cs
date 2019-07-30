using System;

class URI_2808 {
	static void Main(string[] args) {
		string[] str = Console.ReadLine().Split(' ');
		int x1, y1;
		int x2, y2;

		if(str[0][0] == 'a') x1 = 0;
		else if(str[0][0] == 'b') x1 = 1;
		else if(str[0][0] == 'c') x1 = 2;
		else if(str[0][0] == 'd') x1 = 3;
		else if(str[0][0] == 'e') x1 = 4;
		else if(str[0][0] == 'f') x1 = 5;
		else if(str[0][0] == 'g') x1 = 6;
		else x1 = 7;
		y1 = int.Parse(str[0][1].ToString());

		if(str[1][0] == 'a') x2 = 0;
		else if(str[1][0] == 'b') x2 = 1;
		else if(str[1][0] == 'c') x2 = 2;
		else if(str[1][0] == 'd') x2 = 3;
		else if(str[1][0] == 'e') x2 = 4;
		else if(str[1][0] == 'f') x2 = 5;
		else if(str[1][0] == 'g') x2 = 6;
		else x2 = 7;
		y2 = int.Parse(str[1][1].ToString());

		if(((x1 - x2 == -1 || x1 - x2 == 1) && (y1 - y2 == -2 || y1 - y2 == 2)) || ((x1 - x2 == -2 || x1 - x2 == 2) && (y1 - y2 == -1 || y1 - y2 == 1)))
			Console.WriteLine("VALIDO");
		else
			Console.WriteLine("INVALIDO");
	}
}
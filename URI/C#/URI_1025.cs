using System;

class URI_1025{
	static void Main(string[] args){
		string[] str = Console.ReadLine().Split(' ');
		int n = int.Parse(str[0]);
		int q = int.Parse(str[1]);

		int[] arr = new int[10000];
		int cont = 1;

		while(q > 0 && n > 0){
			for(int i = 0; i < 10000; i++) arr[i] = 0;

			for(int i = 0; i < n; i++){
				arr[int.Parse(Console.ReadLine())]++;
			}

			Console.WriteLine("CASE# {0}:", cont++);
			for(int i = 0; i < q; i++){
				int aux = int.Parse(Console.ReadLine());
				int aux2 = 0;
				if(arr[aux] == 0)
					Console.WriteLine("{0} not found", aux);
				else{
					for(int j = 0; j < aux; j++)
						aux2 += arr[j];
					Console.WriteLine("{0} found at {1}", aux, aux2+1);
				}
			}

			str = Console.ReadLine().Split(' ');
			n = int.Parse(str[0]);
			q = int.Parse(str[1]);
		}
	}
}
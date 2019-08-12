using System;

class URI_1027{
	static void Main(string[] args){
		string[] str;
		string str_aux;
		int n;
		int[,] arr;
        while(!string.IsNullOrEmpty(str_aux = Console.ReadLine())){
			int aux = Int32.MaxValue;
			n = int.Parse(str_aux);
			arr = new int[n,2];

			for(int i = 0; i < n; i++){
				str = Console.ReadLine().Split(' ');
				arr[i,0] = int.Parse(str[0]);
				arr[i,1] = int.Parse(str[1]);
				if(arr[i,0] < aux)
					aux = arr[i,0];
			}

			arr = order(arr, n);
			Console.WriteLine();
			for(int i = 0; i < n; i++)
				Console.WriteLine(arr[i, 0] + "\t" + arr[i, 1]);
		}
	}
	static int[,] order(int[,] arr, int n){
		int temp1;
		int temp2;

		for(int j = 0; j <= n - 2; j++){
            for(int i = 0; i <= n - 2; i++){
               if(arr[i, 1] > arr[i + 1, 1] || (arr[i, 1] == arr[i + 1, 1] && arr[i, 0] > arr[i + 1, 0])){
					temp1 = arr[i + 1, 0];
					temp2 = arr[i + 1, 1];
					arr[i + 1, 0] = arr[i, 0];
					arr[i + 1, 1] = arr[i, 1];
					arr[i, 0] = temp1;
					arr[i, 1] = temp2;
               	}
            }
		}
		return arr;
	}

	/*public class Node{
		public Node[] dir;
		public Node[] esq;
		public int x, y;

		public void add(int x, int y){
			if(y + 2 == this.y){

			}
		}
	}*/
}
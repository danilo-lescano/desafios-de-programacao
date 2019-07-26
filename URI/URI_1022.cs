using System;

class URI_1022 {
	static void Main(string[] args) {
		int n = int.Parse(Console.ReadLine());

		for(int i = 0; i < n; i++){
			string[] str = Console.ReadLine().Split(' ');
			int n1 = int.Parse(str[0]);
			int d1 = int.Parse(str[2]);
			int n2 = int.Parse(str[4]);
			int d2 = int.Parse(str[6]);
			int D, N;

			if(str[3][0] == '+'){
				N = n1*d2 + n2*d1;
				D = d1*d2;
			}
			else if(str[3][0] == '-'){
				N = n1*d2 - n2*d1;
				D = d1*d2;
			}
			else if(str[3][0] == '*'){
				N = n1 * n2;
				D = d1 * d2;
			}
			else{
				N = n1 * d2;
				D = d1 * n2;
			}

			int simples_D = D, simples_N = N, aux = 2;

			while(Math.Abs(simples_D) >= Math.Abs(aux) && Math.Abs(simples_N) >= Math.Abs(aux)){
				if(simples_N % aux == 0 && simples_D % aux == 0){
					simples_N /= aux;
					simples_D /= aux;
				}
				else
					aux++;
			}

			Console.WriteLine("{0}/{1} = {2}/{3}", N, D, simples_N, simples_D);
		}
	}
}
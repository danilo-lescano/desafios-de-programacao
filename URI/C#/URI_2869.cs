using System; 

class URI_2869 {
	static void Main(string[] args) {
		int nTotal = int.Parse(Console.ReadLine());
		long[] vals = new long[100];
		long mod = 1000000007;
		int[] valCont = new int[100];

		for(int i = 0; i < 100; i++){
			vals[i] = mod;
			valCont[i] = Int32.MaxValue;
		}

		for(int a = 0; a < 100; a++)
		for(int b = 0; b <  10 && b <= a; b++)
		for(int c = 0; c <   4 && c <= b; c++)
		for(int d = 0; d <   3 && d <= c; d++)
		for(int e = 0; e <   2 && e <= d; e++)
		for(int f = 0; f <   2 && f <= e; f++){
			long total = 1;
			int combinations = (a + 1) * (b + 1) * (c + 1) * (d + 1) * (e + 1) * (f + 1);
			int cont = 0;

			if(combinations <= 100 && combinations >= 1){
				for(int x = 0; x < a; x++){
					cont += (int)((total * (long) 2)/mod);
					total = (total * (long) 2)%mod;
				}
				for(int x = 0; x < b; x++){
					cont += (int)((total * (long) 3)/mod);
					total = (total * (long) 3)%mod;
				}
				for(int x = 0; x < c; x++){
					cont += (int)((total * (long) 5)/mod);
					total = (total * (long) 5)%mod;
				}
				for(int x = 0; x < d; x++){
					cont += (int)((total * (long) 7)/mod);
					total = (total * (long) 7)%mod;
				}
				for(int x = 0; x < e; x++){
					cont += (int)((total * (long)11)/mod);
					total = (total * (long)11)%mod;
				}
				for(int x = 0; x < f; x++){
					cont += (int)((total * (long)13)/mod);
					total = (total * (long)13)%mod;
				}

				if(total > 0)
					if(total < vals[combinations - 1] && cont <= valCont[combinations - 1]){
						vals[combinations - 1] = total;
						valCont[combinations - 1] = cont;
					}
			}
		}

		for(int a = 0; a < nTotal; a++){
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine(vals[num-1] % mod);
		}
	}
}
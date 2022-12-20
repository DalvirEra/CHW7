Console.WriteLine("Введите m и n:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
Random x = new Random();
for (int i = 0; i<m;i++){
    for(int ii = 0;ii<n; ii++){
        array[i,ii] = Math.Round(x.Next(0,10) + (x.NextDouble()),2);
        Console.Write(array[i,ii]+ " ");
    }
    Console.WriteLine();
}

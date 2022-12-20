//заполнение массива, рекомендую числа 100 и 4
Console.WriteLine("Введите m и n:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив: ");
int[,] array = new int[m,n];
Random x = new Random();
for (int i = 0; i<m;i++){
    for(int ii = 0;ii<n; ii++){
        array[i,ii] = x.Next(100,899);
        Console.Write(array[i,ii]+ " ");
    }
    Console.WriteLine();
}


Console.WriteLine();
double[] middle = new double[n];
for (int ii = 0; ii<n;ii++){
    double sum = 0;
    double num = 0;
    for(int i = 0;i<m; i++){
        if (array[i,ii]%10 == array[i,ii]/100){
            sum += array[i,ii];
            num += 1;
        }
    }
    if (num != 0) middle[ii] = Math.Round(sum/num,3);
    else middle[ii] = sum;
    Console.Write(middle[ii] + " | ");
}
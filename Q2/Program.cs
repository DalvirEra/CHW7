Console.WriteLine("Введите m и n:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив: ");
double[,] array = new double[m,n];
Random x = new Random();
for (int i = 0; i<m;i++){
    for(int ii = 0;ii<n; ii++){
        array[i,ii] = x.Next(0,10);
        Console.Write(array[i,ii]+ " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите m и n:");
int z = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (z<m && y<n){
    Console.WriteLine(array[z,y]);
}
else{
    Console.WriteLine("такого числа в массиве нет");
}

// вывести разницу между макс и мин элементом в рандомном массиве
// из L положительных элементов с разрядностью чисел N, начиная с 1
Console.WriteLine("Введите длину массива L");
int lehgth = Convert.ToInt32(Console.ReadLine());
int[] arr00 = new int[lehgth];

Console.WriteLine("Введите разрядность положительных элементов в массиве D (количество цифр элемента)");
double digit = Convert.ToInt32(Console.ReadLine());
double D0 = Math.Pow(10, digit);
int D = Convert.ToInt32(D0);

for (int i = 0; i < arr00.Length; i++)
  {
    arr00[i] = new Random().Next(1, D);
  }

int max = arr00[0];
int min = arr00[0];
 for (int j = 0; j < arr00.Length; j++)
  {
    if(arr00[j] > max) max = arr00[j];
    else if(arr00[j] < min) min = arr00[j];
  }

Console.WriteLine(String.Join((", "), (arr00)));
Console.WriteLine();
Console.WriteLine("Разница между макс и мин элементом в массиве равна " + (max - min));

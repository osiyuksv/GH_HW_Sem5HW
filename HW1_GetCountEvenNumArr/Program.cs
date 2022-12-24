// вывести количество чётных элементов
// в рандомном массиве из трёхзначных чисел
Console.WriteLine("Введите длину массива");
int lehgth = Convert.ToInt32(Console.ReadLine());
int[] arr000 = new int[lehgth];
int count = 0;

for (int i = 0; i < arr000.Length; i++)
  {
    arr000[i] = new Random().Next(100, 1000);
  }

 for (int j = 0; j < arr000.Length; j++)
  {
    if(arr000[j] % 2 == 0) count ++;
  }

Console.WriteLine(String.Join((", "), (arr000)));
Console.WriteLine();
Console.WriteLine("Число чётных элементов в массиве равно " + count);


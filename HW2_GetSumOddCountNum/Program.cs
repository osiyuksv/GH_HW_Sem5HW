// вывести количество сумму элементов на нечётных позициях
// в рандомном массиве из чисел в диапазоне [-99, 99]
Console.WriteLine("Введите длину массива");
int lehgth = Convert.ToInt32(Console.ReadLine());
int[] arr00 = new int[lehgth];
int SumOddCount = 0;

for (int i = 0; i < arr00.Length; i++)
  {
    arr00[i] = new Random().Next(100, 1000);
  }

 for (int j = 0; j < arr00.Length; j++)
  {
    if(j % 2 == 1) SumOddCount = SumOddCount + arr00[j];
  }

Console.WriteLine(String.Join((", "), (arr00)));
Console.WriteLine();
Console.WriteLine("Сумма элементов на нечётных позициях в массиве равна " + SumOddCount);


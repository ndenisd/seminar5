// task 34

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000); // [100, 999]
}


int ReleaseArray(int[] array)
{
int countEven = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
countEven++;
}
return countEven;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {ReleaseArray(array)}");

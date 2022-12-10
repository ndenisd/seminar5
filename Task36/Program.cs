// task 36

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
int x = new Random().Next(100, 1000); // [100, 999]
while (array.Contains(x))
x = new Random().Next(100, 1000); // [100, 999]
array[i] = x;
}
}


int ReleaseArray(int[] array)
{
int sumUnEven = 0;
for (int i = 1; i < array.Length; i+=2)
sumUnEven += array[i];
return sumUnEven;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {ReleaseArray(array)}");
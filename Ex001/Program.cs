//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[]array = new int[4];
Random random = new Random();

for (int i=0; i<array.Length; i++)
    array[i]=random.Next(100);

Console.WriteLine("[{0}]", string.Join(",", array));

for (int i=0; i<array.Length; i++)
    array[i]=array[i]*(-1);

Console.WriteLine("[{0}]", string.Join(",", array));
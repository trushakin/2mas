// Урок 5. Двумерные Массивы

// Задача 1: Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[5,7];


{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(1,10);
            }
        }
}
      System.Console.WriteLine();

{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write(array[i,j] + " ");
            }
                System.Console.WriteLine();
        }
        System.Console.WriteLine();
}

System.Console.WriteLine("Введите позицию строки");
int pos1 =  Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите позицию столбца");
int pos2 =  Convert.ToInt32(Console.ReadLine());

if( pos1>=0 && pos1<array.GetLength(0) && pos2>=0 && pos2<array.GetLength(1))
    {
        int pos3 =array[pos1,pos2];
        System.Console.WriteLine("=> "+ pos3);
    }
else 
    {
        Console.WriteLine("Элемент с указанными позициями отсутствует в массиве.");
    }

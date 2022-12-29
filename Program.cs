/*
Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
*/

using System;

namespace task60
{
    class Program
    {
        static void Main(string[] args)
        {
            int deep1 = InputInt("Введите размерность 1: ");
            int deep2 = InputInt("Введите размерность 2: ");
            int deep3 = InputInt("Введите размерность 3: ");
            int countNums = 89;
            
            if (deep1 * deep2 * deep3 > countNums)
            {
               Console.Write("Массив слишком большой");
                return;
            }
            
            int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);
            
            for (int i = 0; i < resultNums.GetLength(0); i++)
            {
                for (int j = 0; j < resultNums.GetLength(1); j++)
                {
                    for (int k = 0; k < resultNums.GetLength(2); k++)
                    {
                        Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            
            
            int[,,] Create3DMassive(int size1, int size2, int size3)
            {
                int[,,] array = new int[size1, size2, size3];
                int[] values = new int[countNums];
                int num
                = 10;
                for (int i = 0; i < values.Length; i++)
                values[i] = num
                ++;
                
                for (int i = 0; i < values.Length; i++)
                {
                    int randomInd = new Random().Next(0, values.Length);
                    int temp = values[i];
                    values[i] = values[randomInd];
                    values[randomInd] = temp;
                }
                
                int valueIndex = 0;
                
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            array[i, j, k] = values[valueIndex++];
                        }
                    }
                }
                return array;
            }
            
            
            int InputInt(string output)
            {
                Console.Write(output);
                return int.Parse(Console.ReadLine());
            }
        }
    }
}
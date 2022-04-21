using System;

namespace ArrayGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrManager manager = new ArrManager();
            int[,] arr2D = manager.Create(10, 10, 0, 99);

            int[] arr1D = manager.Create(10, 0, 99);

            int[,] arrswaped = manager.Swap(arr2D, manager.GetMax(arr2D), manager.GetMin(arr2D), manager.GetMaxIndex1(arr2D), manager.GetMaxIndex2(arr2D), manager.GetMinIndex1(arr2D), manager.GetMinIndex1(arr2D));
            manager.PrintArr(arr2D);
            manager.PrintArr(arr1D);
            manager.PrintArr(arrswaped);

        }

    }
    public class ArrManager
    {
      

      
    
        #region Arr1D
        /// <summary>
        /// Print Any 1D Array
        /// </summary>
        /// <param name="arr">1D array</param>
        public void PrintArr(int[] arr)
        {
            Console.WriteLine("Start of 1D Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}    ");
            }

            Console.WriteLine();
            Console.WriteLine("End of 1D Array");
        }
        /// <summary>
        /// Generate  1D Array with given parameters 
        /// </summary>
        /// <param name="lenght">Array Lenght</param>
        /// <param name="min">min value of random gen</param>
        /// <param name="max">max value of random gen</param>
        /// <returns>generated Array</returns>
        public int[] Create(int lenght, int min, int max)
        {
            int[] arr = new int[lenght];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(min, max);
            }
            return arr;
        }

        /// <summary>
        /// Get Maximum value of any 1D Array
        /// </summary>
        /// <param name="arr">1D Array</param>
        /// <returns>max value</returns>
        public int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        /// <summary>
        /// Get Minimum value of any 1D Array
        /// </summary>
        /// <param name="arr">1D Array</param>
        /// <returns>min value</returns>
        public int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        /// <summary>
        /// Get Maximum Index of any 1D Array
        /// </summary>
        /// <param name="arr">1D Array</param>
        /// <returns>Max Index</returns>
        public int GetMaxIndex(int[] arr)
        {
            int maxidx = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxidx])
                    maxidx = i;
            }
            return maxidx;
        }
        /// <summary>
        /// Get Minimum Index of any 1D Array
        /// </summary>
        /// <param name="arr">1D Array</param>
        /// <returns>Min Index </returns>
        public int GetMinIndex(int[] arr)
        {
            int minidx = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[minidx])
                    minidx = i;
            }
            return minidx;
        }
        /// <summary>
        /// Swap Min and Max Values of any 1D Array
        /// </summary>
        /// <param name="arr">1D Array</param>
        /// <param name="max">Max value of Array </param>
        /// <param name="min">Min value of Array</param>
        /// <param name="maxidx">max index of Array</param>
        /// <param name="minidx">min index of Array</param>
        /// <returns>Swaped Array</returns>
        public int[] Swap(int[] arr, int max, int min, int maxidx, int minidx)
        {
            arr[maxidx] = min;
            arr[minidx] = max;
            return arr;
        }
        #endregion
        #region Arr2D

        /// <summary>
        /// Print Any 2D Array
        /// </summary>
        /// <param name="arr2D">2D array</param>
        public void PrintArr(int[,] arr2D)
        {
            Console.WriteLine("Start of 2D Array");
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    Console.Write($"{arr2D[i, j] }   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("End of 2D Array");
        }
        /// <summary>
        /// Generate 2D Array with given parameters
        /// </summary>
        /// <param name="height">Array Height</param>
        /// <param name="width">Array Width</param>
        /// <param name="min">min value of random gen</param>
        /// <param name="max">max value of random gen</param>
        /// <returns>generated 2D Array</returns>
        public int[,] Create(int height, int width, int min, int max)
        {
            int[,] arr2D = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr2D[(int)i, j] = new Random().Next(min, max);
                }
            }
            return arr2D;
        }

        /// <summary>
        /// Get Maximum value of any 2D Array
        /// </summary>
        /// <param name="arr2D">2D Array</param>
        /// <returns>Maximum value of 2DArray</returns>
        public int GetMax(int[,] arr2D)
        {
            int max2D = arr2D[0, 0];
            for (int i = 0; i < arr2D.GetLength(0); i++)

            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    if (arr2D[i, j] > max2D)
                        max2D = arr2D[i, j];

                }
            }
            return max2D;
        }
        /// <summary>
        /// Get Minimum Value of any 2D Array
        /// </summary>
        /// <param name="arr2D">2D Array</param>
        /// <returns>Minimum value of 2D Array</returns>
        public int GetMin(int[,] arr2D)
        {
            int min2D = arr2D[0, 0];
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    if (arr2D[i, j] < min2D)
                        min2D = arr2D[i, j];
                }
            }
            return min2D;
        }
        /// <summary>
        /// Get First Maximum Index of any 2D Array 
        /// </summary>
        /// <param name="arr2D">2D Array</param>
        /// <returns>First Maximum index of any 2D Array</returns>
        public int GetMaxIndex1(int[,] arr2D)
        {
            int maxind1 = 0;
            int maxind2 = 0;
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    if (arr2D[i, j] > arr2D[maxind1, maxind2])
                    {
                        maxind1 = i;
                        maxind2 = j;
                    }
                }
            }
            return maxind1;
        }
        /// <summary>
        /// Get Second Maximum Index of any 2D Array 
        /// </summary>
        /// <param name="arr2D">2D Array</param>
        /// <returns>Second Maximum index of any 2D Array</returns>
        public int GetMaxIndex2(int[,] arr2D)
        {
            int maxind1 = 0;
            int maxind2 = 0;
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    if (arr2D[i, j] > arr2D[maxind1, maxind2])
                    {
                        maxind1 = i;
                        maxind2 = j;
                    }
                }
            }
            return maxind2;
        }
        /// <summary>
        /// Get First Minimum Index of any 2D Array 
        /// </summary>
        /// <param name="arr2D">2D Array</param>
        /// <returns>First Minimum index of any 2D Array</returns>
        public int GetMinIndex1(int[,] arr2D)
        {
            int minind1 = 0;
            int minind2 = 0;
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    if (arr2D[i, j] < arr2D[minind1, minind2])
                    {
                        minind1 = i;
                        minind2 = j;
                    }
                }
            }
            return minind1;
        }
        /// <summary>
        /// Get Second Minimum Index of any 2D Array 
        /// </summary>
        /// <param name="arr2D">2D Array</param>
        /// <returns>Second Minimum index of any 2D Array</returns>
        public int GetMinIndex2(int[,] arr2D)
        {
            int minind1 = 0;
            int minind2 = 0;
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    if (arr2D[i, j] < arr2D[minind1, minind2])
                    {
                        minind1 = i;
                        minind2 = j;
                    }
                }
            }
            return minind2;
        }
        /// <summary>
        /// Swap Any 2D Array max and min values
        /// </summary>
        /// <param name="arr2D">2D Array</param>
        /// <param name="max2D">Max value</param>
        /// <param name="min2D">Min value</param>
        /// <param name="maxind1">Max First Index</param>
        /// <param name="maxind2">Max Second Index</param>
        /// <param name="minind1">Min First index</param>
        /// <param name="minind2">Min Second Index</param>
        /// <returns>Swaped 2D Array</returns>
        public int[,] Swap(int[,] arr2D, int max2D, int min2D, int maxind1, int maxind2, int minind1, int minind2)
        {
            arr2D[minind1, minind2] = max2D;
            arr2D[maxind1, maxind2] = min2D;

            return arr2D;
        }
        #endregion
        //  Console.WriteLine("1D matrix");
        //    Console.WriteLine("Please enter lenght of 1D Array");
        //   int lenght = 0;
        //   lenght = Convert.ToInt32(Console.ReadLine());
        //   int[] arr = ArrCreate(lenght, 10, 999);
        //   PrintArr(arr);
        //   int max = GetMax(arr);
        //   Console.WriteLine($"\nmax is {max}");
        //   int min = GetMin(arr);
        //   Console.WriteLine($"\nmin is {min}");
        //   int maxidx = GetMaxIndex(arr);
        //   Console.WriteLine($"\nmaxindex is {maxidx}");
        //   int minidx = GetMinIndex(arr);
        //   Console.WriteLine($"\nminindex is {minidx}");
        //  int[] arrswaped = Swap(arr, max, min, maxidx, minidx);
        //  PrintArr(arrswaped);
        // Console.WriteLine("2D matrix");
        // int[,] arr2D = ArrCreate(5, 5, 10, 99);
        //  PrintArr(arr2D);
        //   int max2D = GetMax(arr2D);
        //   Console.WriteLine($"\nmax2D is {max2D}");
        //   int maxind1 = GetMaxIndex1(arr2D);
        //   Console.WriteLine($"\nmax2Dindex1 is {maxind1}");
        //   int maxind2 = GetMaxIndex2(arr2D);
        //   Console.WriteLine($"\nmax2Dindex2 is {maxind2}");
        //   int min2D = GetMin(arr2D);
        //   Console.WriteLine($"\nmin2D is {min2D}");
        //   int minind1 = GetMinIndex1(arr2D);
        //   Console.WriteLine($"\nmin2Dindex1 is {minind1}");
        //   int minind2 = GetMinIndex2(arr2D);
        //   Console.WriteLine($"\nmin2Dindex2 is {minind2}");
        //   int[,] arr2DSwaped = Swap(arr2D, max2D, min2D, maxind1, maxind2, minind1, minind2);
        //   PrintArr(arr2DSwaped);

    }

}
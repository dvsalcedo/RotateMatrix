using System;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } , { 7, 8, 9 } };
            //int[,] matrix = new int[,] { { 1, 2, 3 , 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write( matrix[i,j] );
                }
                Console.WriteLine("");

            }
            matrix = rotateMatrix(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        static int[,] rotateMatrix(int[,] matrix){
            int length = matrix.GetLength(0);
            int start = 0;
            int final = length-1;
            int tempTop;
            for (int layer = 0; layer < length/2; layer++) {
                start = start + layer;
                final = final - layer;

                for (int i = start; i < final; i++){
                    tempTop = matrix[start, i];
                    //Left to Top
                    matrix[start, i] = matrix[final - i , start ]; ;

                    //Bottom to Left
                    matrix[final - i, start] = matrix[final, final - i];

                    //Right to bottom
                    matrix[final, final - i] = matrix[i, final];

                    //Top to Right
                    matrix[i,final] = tempTop;
                                                        
                }

            }

            return matrix;
        }
    }
}

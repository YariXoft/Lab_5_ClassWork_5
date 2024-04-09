using System;

namespace MatrixNamespace
{
    public class Matrix
    {
        private int[,] data;

        // Конструктор порожньої матриці
        public Matrix(int rows, int cols)
        {
            data = new int[rows, cols];
        }

        // індексатор: доступ к елементам матриці
        public int this[int i, int j]
        {
            get { return data[i, j]; }
            set { data[i, j] = value; }
        }

        // Перевантаження оператора + для додавання матриць
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(m1.data.GetLength(0), m1.data.GetLength(1));

            for (int i = 0; i < result.data.GetLength(0); i++)
            {
                for (int j = 0; j < result.data.GetLength(1); j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return result;
        }

        // Перевантаження оператора - для віднімання матриць
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(m1.data.GetLength(0), m1.data.GetLength(1));

            for (int i = 0; i < result.data.GetLength(0); i++)
            {
                for (int j = 0; j < result.data.GetLength(1); j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return result;
        }
    }
}

using System;
using RobitnykNamespace;
using MatrixNamespace;

class Program
{
    static void Main(string[] args)
    {
        //1 Завдання
        Console.WriteLine($"==============1==============\n");

        // Створення двох працівників
        Robitnyk rob1 = new Robitnyk("Василь", 3000);
        Robitnyk rob2 = new Robitnyk("Петро", 3500);

        // Перевірка перевантажених операторів
        Console.WriteLine($"Зарплата {rob1.Name}: {rob1.Zarplata}");
        Console.WriteLine($"Зарплата {rob2.Name}: {rob2.Zarplata}\n");

        rob1 += 500; // першому працівнику премію: + 500
        rob2 -= 200; // другому працівнику  штраф: - 200

        Console.WriteLine($"Зарплата {rob1.Name} пiсля збiльшення: {rob1.Zarplata}");
        Console.WriteLine($"Зарплата {rob2.Name} пiсля зменшення: {rob2.Zarplata}\n");

        Console.WriteLine($"Зарплати рiвнi? {(rob1 == rob2)}");
      //Console.WriteLine($"Зарплата {rob1.Name} меньша за зарплату {rob2.Name}? {(rob1 < rob2 ? "ТАК" : "НІ")}");
        Console.WriteLine($"Зарплата {rob1.Name}\bя меньша за зарплату {rob2.Name}\bа?" +//\b стер зліва одну букві та заменив
            $"{(rob1 < rob2 ? " Так, меньша" : " Нi, не меньша")}");
        //тестую тернарний оператор та перенос строки

        Console.WriteLine($"Зарплата {rob1.Name}\bя бiльша за зарплату {rob2.Name}\bа? {(rob1 > rob2)}");
        Console.WriteLine($"Зарплати рiзнi? {(rob1 != rob2)}\n");

        //2 Завдання
        Console.WriteLine($"==============2==============\n");

        Matrix matrix1 = new Matrix(2, 2);
        Matrix matrix2 = new Matrix(2, 2);

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix1[i, j] = i + j;//ініціалізуємо: 0 1 1 2
                matrix2[i, j] = i - j;// 0 -1 1 0
            }
        }

        Console.WriteLine("Матриця 1:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Матриця 2:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Сума матриць
        Matrix sum = matrix1 + matrix2;
        Console.WriteLine("\nСума матриць:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(sum[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Рiзниця матриць
        Matrix diff = matrix1 - matrix2;
        Console.WriteLine("Рiзниця матриць:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(diff[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

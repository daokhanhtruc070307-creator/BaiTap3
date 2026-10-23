using System;

namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
                tong += arr[i];
            }

            // Tìm max, min
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine($"\nTong cua mang la: {tong}");
            Console.WriteLine($"So nguyen lon nhat la: {max}");
            Console.WriteLine($"So nguyen nho nhat la: {min}");

            Console.ReadKey(true);
        }
    }
}
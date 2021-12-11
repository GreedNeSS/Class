using System;

namespace Class
{
    class Program
    {

        static void Main(string[] args)
        {
            Cube cube = new Cube();
            Console.WriteLine("Cube volume: " + cube.ShowVolume());
            Console.WriteLine("Cube wight: " + cube.Width);
            Console.WriteLine("Cube hight: " + cube.Height);
            Console.WriteLine("Cube lengthwise: " + cube.Lengthwise);

            cube.ExpandSize(10, 10, 10);

            Console.WriteLine("Extended cube volume: " + cube.ShowVolume());

            // Использование метода с out аргументами
            int side1, side2, side3;
            cube.ExpandAndGetSize(10,out side1,out side2,out side3);
            Console.WriteLine("Размер сторон квадрата: " + side1+ ", " + side2 + ", " + side3);

            int sum = Utils.Sum(2, 5,out int result);
            Console.WriteLine("result = " + result);
            Console.WriteLine("sum = " + sum);

            //use array param
            int sumArray = Utils.SumArray(1, 2, 3, 4, 5);
            Console.WriteLine("Суммируем массив элементов 1,2,3,4,5: " + sumArray);

            Utils.ShowResultSum("Результат суммирования: ", 1, 2, 3, 4, 5);

            // Перегрузка методов и использование второго конструктора
            Cube cube1 = new(20, 20, 20);
            Console.WriteLine("Before sides size: " + cube1.Width +
                ", " + cube1.Height + ", " + cube1.Lengthwise);
            cube1.ExpandSize(10, 5);
            Console.WriteLine("After sides size: " + cube1.Width +
                ", " + cube1.Height + ", " + cube1.Lengthwise);

            Console.ReadLine();
        }
    }
}
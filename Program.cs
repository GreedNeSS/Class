using System;

namespace Class
{
    class Program
    {

        static void Main(string[] args)
        {
            Cube cube = new Cube
            {
                Width = 10,
                Height = 10,
                Lengthwise = 10
            };
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

            Console.ReadLine();
        }
    }
}
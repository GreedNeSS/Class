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

            Console.ReadLine();
        }
    }
}
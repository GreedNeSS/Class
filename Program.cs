using System;

namespace Class
{
    class Program
    {

        static void Main(string[] args)
        {
            Cube cube = new Cube();
            cube.Width = 10;
            cube.Height = 10;
            cube.Lengthwise = 10;
            Console.WriteLine("Cube volume: " + cube.ShowVolume());
            Console.WriteLine("Cube wight: " + cube.Width);
            Console.WriteLine("Cube hight: " + cube.Height);
            Console.WriteLine("Cube lengthwise: " + cube.Lengthwise);

            cube.ExpandSize(10, 10, 10);

            Console.WriteLine("Extended cube volume: " + cube.ShowVolume());

            Console.ReadLine();
        }               
    }                   

    class Cube
    {
        int x;
        int y;
        int z;

        public int Width
        {
            get { return x; }
            set { x = value; }
        }

        public int Height
        {
            get { return y; }
            set { y = value; }
        }

        public int Lengthwise
        {
            get { return z; }
            set { z = value; }
        }

        public int ShowVolume()
        {
            return x * y * z;
        }

        public void ExpandSize(int a, int b, int c)
        {
            /*
              x += a;
              y += b;
              z += c;
            */

            Width += a;
            Height += b;
            Lengthwise += c;
        }
    }
}

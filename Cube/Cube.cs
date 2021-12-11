using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Cube
    {
        int x, y, z;
        // Конструктор по умолчанию
        public Cube(): this(10,10,10)
        {
        
        }
        // Конструктор с аргументами
        public Cube(int x, int y, int z)
        {
            // Более предпочтительный вариант
            Width = x;
            Height = y;
            Lengthwise = z;
            /*
             * Это менее предпочтительный вариант
            this.x = x;
            this.y = y;
            this.z = z;
            */
        }

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

        // перегрузка метода
        public void ExpandSize(int a, int b)
        {
              x += a;
              y += b;
        }

        public void ExpandAndGetSize(int inc, out int sideX, out int sideY, out int sideZ)
        {
            ExpandSize(inc, inc, inc);
            sideX = x;
            sideY = y;
            sideZ = z;
        }
    }
}

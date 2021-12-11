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

        public void ExpandAndGetSize(int inc, out int sideX, out int sideY, out int sideZ)
        {
            ExpandSize(inc, inc, inc);
            sideX = x;
            sideY = y;
            sideZ = z;
        }
    }
}

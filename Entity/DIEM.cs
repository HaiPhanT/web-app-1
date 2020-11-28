using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DIEM
    {
        public int X { get; set; }
        public int Y { get; set; }
        public DIEM()
        {
            this.X = 0;
            this.Y = 0;
        }

        public DIEM(int x0, int y0)
        {
            this.X = x0;
            this.Y = y0;
        }
    }
}

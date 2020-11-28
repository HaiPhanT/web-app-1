using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LT_DIEM
    {
        private string filePath = "F:\\diem.txt";

        public void Ghi(DIEM p)
        {
            StreamWriter file = new StreamWriter(filePath);
            file.Write($"{p.X},{p.Y}");

            file.Close();
        }
    }
}

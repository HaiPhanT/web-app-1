using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class LT_SACH
    {
        private string filePath = "F:\\dssach.txt";

        public List<SACH> DocDanhSach()
        {
            List<SACH> dsSach = new List<SACH>();
            StreamReader reader = new StreamReader(filePath);

            while(reader.EndOfStream == false)
            {
                string s = reader.ReadLine();
                var sach = new SACH(s);
                dsSach.Add(sach);
            }

            reader.Close();
            return dsSach;
        }

        public void LuuSach(SACH s)
        {
            var dsSach = DocDanhSach();
            dsSach.Add(s);
            LuuDanhSach(dsSach);
        }

        public void LuuDanhSach(List<SACH> dsSach)
        {
            StreamWriter writer = new StreamWriter(filePath);

            for (int i = 0; i < dsSach.Count; i++)
            {
                var s = dsSach[i];
                string line = $"{s.MaSach},{s.TenSach},{s.Gia},{s.TacGia},{s.NamXuatBan}";

                if (i == dsSach.Count - 1)
                {
                    writer.Write(line);
                }
                else
                {
                    writer.WriteLine(line);
                }
            }

            writer.Close();
        }
    }
}

using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class XL_DIEM
    {
        public bool Ghi(int x, int y)
        {
            DIEM p = new DIEM(x, y);
            var luuTruDIEM = new LT_DIEM();
            luuTruDIEM.Ghi(p);
            return true;
        }
    }
}

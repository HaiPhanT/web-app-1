using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BusinessServices
{
    public class XL_SACH
    {
        public List<SACH> LayDanhSach()
        {
            var ltSach = new LT_SACH();

            var kq = ltSach.DocDanhSach();

            return kq;
        }

        public void ThemSach(SACH s)
        {
            var ltSach = new LT_SACH();
            ltSach.LuuSach(s);
        }
    }
}

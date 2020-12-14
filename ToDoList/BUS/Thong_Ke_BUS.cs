using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BUS
{
    class Thong_Ke_BUS
    {
        public IEnumerable thong_ke_trang_thai(string user_id_exe,string trangthai, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return new DAO.Thong_Ke_DAO().thong_ke_trang_thai(user_id_exe,trangthai, ngaybatdau, ngayketthuc);
        }

        public IEnumerable thong_ke_tre_han(string user_id_exe,string nhanvien, string trangthai, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return new DAO.Thong_Ke_DAO().thong_ke_tre_han(user_id_exe,nhanvien, trangthai, ngaybatdau, ngayketthuc);
        }
            public IEnumerable load_danh_sach_nv()
        {
            return new DAO.Thong_Ke_DAO().load_danh_sach_nv();
        }
    }
}

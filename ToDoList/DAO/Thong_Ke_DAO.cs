using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DAO
{
    class Thong_Ke_DAO
    {
        DBTODOLISTEntities DB = new DBTODOLISTEntities();

        public IEnumerable thong_ke_trang_thai(string user_id_exe,string trangthai, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            var res = from t in DB.tasks
                      where t.state.ToLower() == trangthai.ToLower() /*&& t.fromdate >= ngaybatdau && t.todate <= ngayketthuc*/
                      select t;
            history h = new history();
            h.user_id = user_id_exe;
            h.action = "Thống kê theo trạng thái " + trangthai;
            h.create_date = DateTime.Now;
            DB.histories.Add(h);
            return res.ToList();

        }

        public IEnumerable load_danh_sach_nv()
        {
            var res = DB.users.Select(u => u.user_id + "-" + u.fullname);
            return res.ToList();

        }

        public IEnumerable thong_ke_tre_han(string user_id_exe,string nhanvien, string trangthai, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            string[] arr_userID;
            arr_userID = nhanvien.Split('-');
            string userId = arr_userID[0];
            var res = from t in DB.tasks
                      join u in DB.users
                      on t.user_id equals u.user_id
                      where t.state.ToLower() == trangthai.ToLower() && u.user_id == userId /*&& t.fromdate >= ngaybatdau && t.todate <= ngayketthuc*/
                      select t;
            history h = new history();
            h.user_id = user_id_exe;
            h.action = "Thống kê theo trạng thái " + trangthai + "của nhân viên " + nhanvien;
            h.create_date = DateTime.Now;
            DB.histories.Add(h);
            return res.ToList();

        }
    }
}

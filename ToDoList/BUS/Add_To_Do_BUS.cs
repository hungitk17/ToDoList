using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BUS
{
    class Add_To_Do_BUS
    {
        public IEnumerable load_user()
        {
            return new DAO.Add_To_Do_DAO().load_user();
        }

        public int check_exists_task_id(string task_id)
        {
            return new DAO.Add_To_Do_DAO().check_exists_task_id(task_id);
        }

        public int add_task(string task_id, string user_id, string tencongviec, string score, string status, DateTime ngaybatdau, DateTime ngayketthuc, List<string> nguoilamchung)
        {
            return new DAO.Add_To_Do_DAO().add_task(task_id, user_id, tencongviec, score, status, ngaybatdau, ngayketthuc, nguoilamchung);
        }

        public int edit_task(string task_id, string user_id, string tencongviec, string score, string status, DateTime ngaybatdau, DateTime ngayketthuc, List<string> nguoilamchung)
        {
            return new DAO.Add_To_Do_DAO().edit_task(task_id, user_id, tencongviec, score, status, ngaybatdau, ngayketthuc, nguoilamchung);
        }

        public int delete_task(string user_id_exe,string task_id)
        {
            return new DAO.Add_To_Do_DAO().delete_task(user_id_exe,task_id);
        }

        public int check_exists_task_in_order_table(string task_id)
        {
            return new DAO.Add_To_Do_DAO().check_exists_task_in_order_table(task_id);
        }
    }
}

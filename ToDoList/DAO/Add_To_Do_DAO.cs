using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DAO
{
    class Add_To_Do_DAO
    {
        DBTODOLISTEntities DB = new DBTODOLISTEntities();
        public IEnumerable load_user()
        {
            var result = DB.users.Select(p => p).ToList();
            return result;
        }

        public int check_exists_task_id(string task_id)
        {
            var result = DB.tasks.Find(task_id);
            if(result != null)
            {
                return 1; //ton tai
            }
            return 0; // khong ton tai
        }

        public int add_task(string task_id, string user_id, string tencongviec, string score, string status, DateTime ngaybatdau, DateTime ngayketthuc, List<string> nguoilamchung) 
        {
            task t = new task();
            joinning j = new joinning();
            t.user_id = user_id;
            t.task_id = task_id;
            t.title = tencongviec;
            t.scope = score;
            t.state = status;
            t.fromdate = ngaybatdau;
            t.todate = ngayketthuc;
            DB.tasks.Add(t);
            history h = new history();
            h.user_id = user_id;
            h.action = "Thêm công việc " + task_id + "-" + tencongviec ;
            h.create_date = DateTime.Now;
            DB.histories.Add(h);
            foreach (string item in nguoilamchung)
            {
                j.task_id = task_id;
                j.user_id = item;
                j.status = 1; // chua hieu de lam gi
                DB.joinnings.Add(j);
                DB.SaveChanges();
                j = new joinning();
            }
            DB.SaveChanges();
            return 1;
        }

        public int edit_task(string task_id, string user_id, string tencongviec, string score, string status, DateTime ngaybatdau, DateTime ngayketthuc, List<string> nguoilamchung)
        {
            task t = DB.tasks.Find(task_id);
            joinning j = new joinning();
            t.user_id = user_id;
            t.task_id = task_id;
            t.title = tencongviec;
            t.scope = score;
            t.state = status;
            t.fromdate = ngaybatdau;
            t.todate = ngayketthuc;
            history h = new history();
            h.user_id = user_id;
            h.action = "Sửa công việc " + task_id;
            h.create_date = DateTime.Now;
            DB.histories.Add(h);
            DB.SaveChanges();

            var joinings = DB.joinnings.Select(jo => jo).ToList();
            while(true)
            {
               var temp_jo = DB.joinnings.FirstOrDefault(joining => joining.task_id == task_id);
                if(temp_jo == null)
                {
                    break;
                }
                DB.joinnings.Remove(temp_jo);
                temp_jo = null;
                DB.SaveChanges();
            }

            foreach (string item in nguoilamchung)
            {
                j.task_id = task_id;
                j.user_id = item;
                j.status = 1; // chua hieu de lam gi
                DB.joinnings.Add(j);
                DB.SaveChanges();
                j = new joinning();
            }
            return 1;
        }

        public int delete_task(string user_id_exe,string task_id)
        {
            var task = DB.tasks.Find(task_id);
            DB.tasks.Remove(task);
            history h = new history();
            h.user_id = user_id_exe;
            h.action = "Xóa công việc " + task_id;
            h.create_date = DateTime.Now;
            DB.histories.Add(h);
            DB.SaveChanges();
            return 1;
        }
        public int check_exists_task_in_order_table(string task_id)
        {
            var comment = DB.comments.FirstOrDefault(c => c.task_id == task_id);
            var joining = DB.joinnings.FirstOrDefault(j => j.task_id == task_id);
            if (comment != null || joining != null)
            {
                return 1; // ton tai trong bang khac
            }
            return 0; // khong ton tai trong bang khac
        }
    }
}

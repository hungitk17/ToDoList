using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DTO;

namespace ToDoList.DAO
{
    class Role_Users_DAO
    {
        DBTODOLISTEntities DB = new DBTODOLISTEntities();
        //    public IEnumerable Get_All_TodoList()
        //    {
        //        //List<Role_Users_DTO> result = (from t in DB.tasks
        //        //              join u in DB.users
        //        //              on t.user_id equals u.user_id
        //        //              select new Role_Users_DTO
        //        //              {
        //        //                  tencongviec = t.title,
        //        //                  nguoitao = t.user_id,
        //        //                  tennguoitao = u.fullname,
        //        //                  ngaybatdau = t.fromdate,
        //        //                  ngayketthuc = t.todate,
        //        //                  nguoilamchung = "",
        //        //                  phamvi = t.scope,
        //        //                  trangthai = t.state
        //        //              }).ToList();
        //        var result = (from t in DB.tasks
        //                      join u in DB.users
        //                      on t.user_id equals u.user_id
        //                      select new
        //                      {
        //                          tencongviec = t.title,
        //                          nguoitao = t.user_id,
        //                          tennguoitao = u.fullname,
        //                          ngaybatdau = t.fromdate,
        //                          ngayketthuc = t.todate,
        //                          nguoilamchung = "",
        //                          phamvi = t.scope,
        //                          trangthai = t.state
        //                      }).ToList();
        //        //var temp =  from t in DB.tasks
        //        //            join j in DB.joinnings
        //        //            on t.task_id equals j.task_id
        //        //            join u in DB.users
        //        //            on j.user_id equals u.user_id
        //        //            select new
        //        //            {
        //        //                ten = u.fullname,
        //        //                user_id = t.user_id,
        //        //                task_id = t.task_id
        //        //            };

        //        //foreach (var item in result)
        //        //{
        //        //    foreach (var item2 in temp)
        //        //    {
        //        //        if (item.nguoitao == item2.task_id)
        //        //        {
        //        //            item.nguoilamchung += item2.ten + ", ";
        //        //        }
        //        //    }
        //        //}

        //        return result.ToList();
        //    }



        //}

        public List<Role_Users_DTO> Get_All_TodoList()
        {
            List<Role_Users_DTO> result = (from t in DB.tasks
                                           join u in DB.users
                                           on t.user_id equals u.user_id
                                           select new Role_Users_DTO
                                           {
                                               user_id = u.user_id,
                                               task_id = t.task_id,
                                               tencongviec = t.title,
                                               nguoitao = u.user_id,
                                               tennguoitao = u.user_id+"-"+u.fullname,
                                               ngaybatdau = t.fromdate,
                                               ngayketthuc = t.todate,
                                               nguoilamchung = "",
                                               phamvi = t.scope,
                                               trangthai = t.state
                                           }).ToList();
            var temp = (from t in DB.tasks
                       join j in DB.joinnings
                       on t.task_id equals j.task_id
                       join u in DB.users
                       on j.user_id equals u.user_id
                       select new
                       {
                           ten = u.fullname,
                           user_id = j.user_id,
                           task_id = t.task_id
                       }).ToList();

            foreach (var item in result)
            {
                foreach (var item2 in temp)
                {
                    if (item.task_id == item2.task_id)
                    {
                        if (item.nguoitao != item2.user_id)
                        {
                            item.nguoilamchung += item2.ten + "-";
                        }
                    }
                }
            }

            foreach (var item in result)
            {
                if(item.nguoilamchung != "")
                {
                    item.nguoilamchung = item.nguoilamchung.Substring(0, item.nguoilamchung.Length - 1);
                }
                if(item.nguoilamchung == "")
                {
                    item.nguoilamchung = "Trống!";
                }
            }

            return result;
        }

        //Search Task
        public List<Role_Users_DTO> Search(String s)
        {
            List<Role_Users_DTO> result = Get_All_TodoList().Where(t => t.task_id.Contains(s) || t.tencongviec.Contains(s) || t.tennguoitao.Contains(s) || t.phamvi.Contains(s) || t.trangthai.Contains(s) || t.nguoitao.Contains(s)).ToList();
            return result;
        }

        public int changeInfoUser(string user_id,string hoTen,string sdt, string email)
        {
            user ur = DB.users.Find(user_id);
            ur.fullname = hoTen;
            ur.phone = sdt;
            ur.email = email;
            DB.SaveChanges();
            history h = new history();
            h.user_id = user_id;
            h.action = "Thay đổi thông tin của nhân viên " + user_id + "-" + hoTen;
            h.create_date = DateTime.Now;
            DB.histories.Add(h);
            DB.SaveChanges();
            return 1;
        }

        public int changePassword(string user_id,string password)
        {
            user ur = DB.users.Find(user_id);
            ur.pass = password;
            history h = new history();
            h.user_id = user_id;
            h.action = "Thay đổi password của nhân viên " + user_id;
            h.create_date = DateTime.Now;
            DB.histories.Add(h);
            DB.SaveChanges();
            return 1;
        }

        public int checkOldPassword(string user_id,string password)
        {
            user ur = DB.users.Find(user_id);
            if(ur.pass == password)
            {
                return 1;
            }else
            {
                return 0;
            }
        }

        public IEnumerable load_user(string user_id)
        {
            //var res = db.doans.ToList();
            var res = from u in DB.users
                      join r in DB.roles
                      on u.role_id equals r.role_id
                      where u.user_id != user_id
                      select new {
                          user_id = u.user_id,
                          fullname = u.fullname,
                          phone = u.phone,
                          email = u.email,
                          name = r.name
                      };
            return res.ToList();
        }

        public IEnumerable searchUser(string user_id,string str)
        {
            var res = from u in DB.users
                      join r in DB.roles
                      on u.role_id equals r.role_id
                      where u.user_id != user_id
                      select new
                      {
                          user_id = u.user_id,
                          fullname = u.fullname,
                          phone = u.phone,
                          email = u.email,
                          name = r.name
                      };
            var result = res.Where(t => t.user_id.Contains(str) || t.fullname.Contains(str) || t.phone.Contains(str) || t.email.Contains(str) || t.name.Contains(str)).ToList();
            return result;
        }

        public string nameOfUser(string user_id)
        {
            var users = DB.users.Select(p => p).ToList();
            foreach (var item in users)
            {
                if (user_id == item.email || user_id == item.user_id)
                {
                    return item.fullname;
                }
            }
            //var res = DB.users.Find(user_id);
            //return res.fullname;
            return "";
        }


        public int check_email_exists(string email)
        {
            var res = DB.users.Select(p => p).ToList();
            foreach (var item in res)
            {
                if (email == item.email)
                {
                    return 1;
                }
            }
            return 0;
        }

        public int check_uesr_name(string userName)
        {
            var res = DB.users.Select(p => p).ToList();
            foreach (var item in res)
            {
                if (userName == item.user_id)
                {
                    return 1; // UserName da ton tai
                }
            }
            return 0;
        }

        public IEnumerable load_role()
        {
            var res = DB.roles.Select(r => r.role_id + "-" + r.name);
            return res.ToList();
        }

        public int add_user(string user_id_exe, string fullname, string email, string role, string sdt, string userName, string password)
        {
            string[] arr_role_id = role.Split('-');
            string role_id = arr_role_id[0];
            user u = new user();
            u.user_id = userName;
            u.pass = password;
            u.phone = sdt;
            u.email = email;
            u.role_id = role_id;
            u.fullname = fullname;
            DB.users.Add(u);
            history h = new history();
            h.user_id = user_id_exe;
            h.action = "Thêm nhân viên " + userName + "-" + fullname;
            h.create_date = DateTime.Now;
            DB.histories.Add(h);
            DB.SaveChanges();
            return 1;
        }

        public int edit_user(string user_id_exe,string fullname, string sdt, string userName, string pass)
        {
            user u = DB.users.Find(userName);
            u.pass = pass;
            u.phone = sdt;
            u.fullname = fullname;
            history h = new history();
            h.user_id = user_id_exe;
            h.action = "Sửa nhân viên " + userName + "-" + fullname;
            h.create_date = DateTime.Now;
            DB.histories.Add(h);
            DB.SaveChanges();
            return 1;
        }

        public int check_user_exit(string user_id)
        {
            var history = DB.histories.FirstOrDefault(h => h.user_id == user_id);
            var joining = DB.joinnings.FirstOrDefault(h => h.user_id == user_id);
            var comment = DB.comments.FirstOrDefault(h => h.user_id == user_id);
            if(history != null || joining != null || comment != null)
            {
                return 1; // ton tai trong ban khac
            }
            return 0;
        }

        public int delete_user(string user_id_exe,string user_id)
        {
            user res = DB.users.Find(user_id);
            if(res != null)
            {
                DB.users.Remove(res);
                history h = new history();
                h.user_id = user_id_exe;
                h.action = "Xóa nhân viên " + user_id;
                h.create_date = DateTime.Now;
                DB.histories.Add(h);
                DB.SaveChanges();
            }
            return 0;
        }
    }
}

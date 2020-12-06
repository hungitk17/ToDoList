using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DAO
{ 
    class LoginDAO
    {
        DBTODOLISTEntities DB = new DBTODOLISTEntities();
        public ArrayList check_login(String userName,String password)
        {
            ArrayList arr_info_user = new ArrayList();
            var result = DB.users.SingleOrDefault(x => (x.user_id == userName || x.email == userName) && x.pass == password);
            if(result != null)
            {
                arr_info_user.Add("success");
                arr_info_user.Add(result.fullname);
            }
            else
            {
                arr_info_user.Add("fail");
            }
            return arr_info_user;
        }

        public ArrayList get_Info_User(String userName)
        {
            ArrayList arr_info_user = new ArrayList();
            var result = DB.users.SingleOrDefault(x => x.user_id == userName || x.email == userName);

            arr_info_user.Add(result.fullname);
            arr_info_user.Add(result.phone);
            arr_info_user.Add(result.email);
            arr_info_user.Add(result.user_id);
            arr_info_user.Add(result.pass);
            if (result.role_id == "001")
            {
                arr_info_user.Add("Giám Đốc");
            }
            else
            {
                arr_info_user.Add("Nhân Viên");
            }

            return arr_info_user;
        }
    }
}

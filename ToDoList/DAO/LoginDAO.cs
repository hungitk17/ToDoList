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
            var result = DB.users.SingleOrDefault(x => x.user_id == userName && x.pass == password);
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
    }
}

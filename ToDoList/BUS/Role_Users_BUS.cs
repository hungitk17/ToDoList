using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DTO;

namespace ToDoList.BUS
{
    class Role_Users_BUS
    {
        //public IEnumerable Get_All_TodoList()
        //{
        //    return new DAO.Role_Users_DAO().Get_All_TodoList();
        //}

        public List<Role_Users_DTO> Get_All_TodoList()
        {
            return new DAO.Role_Users_DAO().Get_All_TodoList();
        }

        public List<Role_Users_DTO> Search(String s)
        {
            return new DAO.Role_Users_DAO().Search(s);
        }

        public int changeInfoUser(string user_id, string hoTen, string sdt, string email)
        {
            return new DAO.Role_Users_DAO().changeInfoUser(user_id,hoTen,sdt,email);
        }

        public int changePassword(string user_id, string password)
        {
            return new DAO.Role_Users_DAO().changePassword(user_id, password);
        }

        public int checkOldPassword(string user_id, string password)
        {
            return new DAO.Role_Users_DAO().checkOldPassword(user_id, password);
        }

        public IEnumerable load_user(string user_id)
        {
            return new DAO.Role_Users_DAO().load_user(user_id);
        }

        public IEnumerable searchUser(string user_id, string str)
        {
            return new DAO.Role_Users_DAO().searchUser(user_id, str);
        }

        public string nameOfUser(string user_id)
        {
            return new DAO.Role_Users_DAO().nameOfUser(user_id);
        }

        public IEnumerable load_role()
        {
            return new DAO.Role_Users_DAO().load_role();
        }

        public int check_uesr_name(string userName)
        {
            return new DAO.Role_Users_DAO().check_uesr_name(userName);
        }

        public int check_email_exists(string email)
        {
            return new DAO.Role_Users_DAO().check_email_exists(email);
        }

        public int add_user(string user_id_exe,string fullname, string email, string role, string sdt, string userName, string password)
        {
            return new DAO.Role_Users_DAO().add_user(user_id_exe,fullname, email,role,sdt,userName,password);
        }

        public int check_user_exit(string user_id)
        {
            return new DAO.Role_Users_DAO().check_user_exit(user_id);
        }

        public int delete_user(string user_id_exe,string user_id)
        {
            return new DAO.Role_Users_DAO().delete_user(user_id_exe,user_id);
        }

        public int edit_user(string user_id_exe,string fullname, string sdt, string userName, string pass)
        {
            return new DAO.Role_Users_DAO().edit_user(user_id_exe,fullname, sdt, userName, pass);
        }
    }
}

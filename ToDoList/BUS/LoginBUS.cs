﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BUS
{
    class LoginBUS
    {
        public ArrayList check_login(String userName, String password)
        {
            return new DAO.LoginDAO().check_login(userName, password);
        }

        public ArrayList get_Info_User(String userName)
        {
            return new DAO.LoginDAO().get_Info_User(userName);
        }
    }
}

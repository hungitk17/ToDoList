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
    }
}

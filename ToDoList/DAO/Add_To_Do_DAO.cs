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
    }
}

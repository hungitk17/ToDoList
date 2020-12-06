using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BUS
{
    class History_BUS
    {
        public IEnumerable load_history()
        {
            return new DAO.History_DAO().load_history();
        }

        public IEnumerable search_history(string textSearch)
        {
            return new DAO.History_DAO().search_history(textSearch);
        }
    }
}

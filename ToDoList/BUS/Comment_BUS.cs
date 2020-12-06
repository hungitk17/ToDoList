using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BUS
{
    class Comment_BUS
    {
        public IEnumerable load_comment(string task_id)
        {
            return new DAO.Comment_DAO().load_comment(task_id);
        }

        public IEnumerable search_comment(string task_id,string textSearch)
        {
            return new DAO.Comment_DAO().search_comment(task_id, textSearch);
        }

        public int comment(string task_id, string user_id, string content, string comment_id)
        {
            return new DAO.Comment_DAO().comment(task_id, user_id, content, comment_id);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DAO
{
    class Comment_DAO
    {
        //orderby p.PostTypeId ascending
        DBTODOLISTEntities DB = new DBTODOLISTEntities();
        public IEnumerable load_comment(string task_id)
        {
            var result = from c in DB.comments
                         join u in DB.users
                         on c.user_id equals u.user_id
                         join t in DB.tasks
                         on u.user_id equals t.user_id
                         where t.task_id == task_id
                         orderby c.create_date ascending
                         select new
                         {
                             user_id = c.user_id,
                             fullname = u.fullname,
                             task_id = t.task_id,
                             title = t.title,
                             content = c.content,
                             create_date = c.create_date
                         };
            return result.ToList();
        }

        public IEnumerable search_comment(string task_id, string textSearch)
        {
            var result = from c in DB.comments
                         join u in DB.users
                         on c.user_id equals u.user_id
                         join t in DB.tasks
                         on u.user_id equals t.user_id
                         where t.task_id == task_id
                         orderby c.create_date ascending
                         select new
                         {
                             user_id = c.user_id,
                             fullname = u.fullname,
                             task_id = t.task_id,
                             title = t.title,
                             content = c.content,
                             create_date = c.create_date
                         };
            var res = result.Where(h => h.fullname.Contains(textSearch) || h.task_id.Contains(textSearch) || h.title.Contains(textSearch) || h.content.Contains(textSearch) || h.user_id.Contains(textSearch));
            return res.ToList();
        }

        public int comment(string task_id, string user_id, string content, string comment_id)
        {
            DateTime now = DateTime.Now; //.ToString("yyyy-MM-dd hh:mm:ss")
            comment c = new comment() { comment_id = comment_id, task_id = task_id, user_id = user_id, content = content, create_date = now };
            DB.comments.Add(c);
            DB.SaveChanges();
            return 1;
        }

        public int check_email_exists(string email)
        {
            var res = DB.users.Select(p => p).ToList();
            foreach(var item in res)
            {
                if(email == item.email)
                {
                    return 1;
                }
            }
            return 0;
        }

    }
}

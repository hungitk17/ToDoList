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
                         join t in DB.tasks
                         on c.task_id equals t.task_id
                         join u in DB.users
                         on c.user_id equals u.user_id
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

        public int comment(string task_id, string user_id, string content)
        {
            history h = new history();
            h.user_id = user_id;
            h.action = "Thêm bình luận trong task " + task_id;
            h.create_date = DateTime.Now;
            DB.histories.Add(h);
            DateTime now = DateTime.Now; //.ToString("yyyy-MM-dd hh:mm:ss")
            comment c = new comment() { task_id = task_id, user_id = user_id, content = content, create_date = now };
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
                    return 1; //ton tai
                }
            }
            return 0; //chua ton tai
        }

        public int delete_comment(string user_id_exe, string user_id, string task_id, string content, DateTime create_date)
        {
            comment res = DB.comments.Where(c => c.user_id == user_id && c.task_id == task_id && c.content == content /*&& c.create_date == create_date*/).FirstOrDefault();
            if(res != null)
            {
                DB.comments.Remove(res);
                history h = new history();
                h.user_id = user_id_exe;
                h.action = "Xóa bình luận trong task " + task_id;
                h.create_date = DateTime.Now;
                DB.histories.Add(h);
                DB.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
    }
}

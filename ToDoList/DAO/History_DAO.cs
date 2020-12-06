using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DAO
{
    class History_DAO
    {
        DBTODOLISTEntities DB = new DBTODOLISTEntities();
        public IEnumerable load_history()
        {
            var result = from h in DB.histories
                         join u in DB.users
                         on h.user_id equals u.user_id
                         select new {
                             user_id = h.user_id,
                             fullname = u.fullname,
                             create_date = h.create_date,
                             his_id = h.his_id,
                             action = h.action
                         };
            return result.ToList();
        }

        public IEnumerable search_history(string textSearch)
        {
            var result = from h in DB.histories
                         join u in DB.users
                         on h.user_id equals u.user_id
                         select new
                         {
                             user_id = h.user_id,
                             fullname = u.fullname,
                             create_date = h.create_date,
                             his_id = h.his_id,
                             action = h.action
                         };
            var res = result.Where(h => h.action.Contains(textSearch) || h.his_id.Contains(textSearch) || h.user_id.Contains(textSearch) || h.fullname.Contains(textSearch));
            return res.ToList();
        }
    }
}

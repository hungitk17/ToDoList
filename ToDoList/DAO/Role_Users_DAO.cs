using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DAO
{
    class Role_Users_DAO
    {
        DBTODOLISTEntities DB = new DBTODOLISTEntities();
        //public IEnumerable Get_All_TodoList()
        //{
        //    var result = (from t in DB.tasks
        //                  join u in DB.users
        //                  on t.user_id equals u.user_id
        //                 select new
        //                 {
        //                     tencongviec = t.title,
        //                     nguoitao = t.user_id,
        //                     tennguoitao = u.fullname,
        //                     ngaybatdau = t.fromdate,
        //                     ngayketthuc = t.todate,
        //                     nguoilamchung = "",
        //                     phamvi = t.scope,
        //                     trangthai = t.state
        //                 }).ToList();
        //    var temp = (from t in DB.tasks
        //               join j in DB.joinnings
        //               on t.task_id equals j.task_id
        //               join u in DB.users
        //               on j.user_id equals u.user_id
        //               select new
        //               {
        //                   ten = u.fullname,
        //                   user_id = t.user_id,
        //                   task_id = t.task_id
        //               }).ToList();

        //    foreach(var item in result)
        //    {
        //        foreach(var item2 in temp)
        //        {
        //            if(item.nguoitao == item2.task_id)
        //            {
        //                item.nguoilamchung += item2.ten + ",";
        //            }
        //        }
        //    }

        //    return result;
        //}



    }
}

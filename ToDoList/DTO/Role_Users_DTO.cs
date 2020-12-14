using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DTO
{
    class Role_Users_DTO
    {
        public String user_id;
        public String task_id;
        public String tencongviec;
        public String nguoitao;
        public String tennguoitao;
        public Nullable<DateTime> ngaybatdau;
        public Nullable<DateTime> ngayketthuc;
        public String nguoilamchung;
        public String phamvi;
        public String trangthai;


        public Role_Users_DTO()
        {

        }

        public Role_Users_DTO(String user_id, String task_id, String tencongviec, String nguoitao, String tennguoitao, Nullable<DateTime> ngaybatdau, Nullable<DateTime> ngayketthuc, String phamvi, String trangthai)
        {
            this.user_id = user_id;
            this.task_id = task_id;
            this.tencongviec = tencongviec;
            this.nguoitao = nguoitao;
            this.tennguoitao = tennguoitao;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.phamvi = phamvi;
            this.trangthai = trangthai;
        }

    }
}

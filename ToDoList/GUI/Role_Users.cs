using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.DTO;

namespace ToDoList.GUI
{
    public partial class Role_Users : Form
    {
        //private String tenUser;
        private String userName;
        public string role_id;
        public Role_Users(/*String tenUser,*/ String userName, string role_id)
        {
            //this.tenUser = tenUser;
            this.role_id = role_id;
            this.userName = userName;
            InitializeComponent();

            dataGridView1.Columns.Add("task_id", "Mã công việc");
            dataGridView1.Columns.Add("tencongviec", "Tên công việc");
            dataGridView1.Columns.Add("tennguoitao", "Tên người tạo");
            dataGridView1.Columns.Add("nguoilamchung", "Người làm chung");
            dataGridView1.Columns.Add("ngaybatdau", "Ngày bắt đầu");
            dataGridView1.Columns.Add("ngayketthuc", "Ngày kết thúc");
            dataGridView1.Columns.Add("phamvi", "Phạm Vi");
            dataGridView1.Columns.Add("trangthai", "Trạng thái");

            dataGridView1.Columns["ngaybatdau"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["ngayketthuc"].DefaultCellStyle.Format = "dd/MM/yyyy";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            dataGridView1.DataSource = null;

            load_data();

        }

        public void load_data()
        {
            //label2.Text = "Xin Chào " + tenUser +"!";
            var tenUserUpdate = new BUS.Role_Users_BUS().nameOfUser(this.userName);
            label2.Text = "Xin Chào " + tenUserUpdate + "!";
            var result = new BUS.Role_Users_BUS().Get_All_TodoList();
            List<object> data = new List<object>();
            foreach(var todo in result)
            {
                if(this.role_id == "002")
                {
                    if (todo.user_id == this.userName || todo.phamvi.ToLower() == "Public".ToLower())
                    {
                        data.Add(new
                        {
                            todo.task_id,
                            todo.tencongviec,
                            todo.tennguoitao,
                            todo.nguoilamchung,
                            todo.ngaybatdau,
                            todo.ngayketthuc,
                            todo.phamvi,
                            todo.trangthai
                        });
                    }
                }
                else
                {
                    data.Add(new
                    {
                        todo.task_id,
                        todo.tencongviec,
                        todo.tennguoitao,
                        todo.nguoilamchung,
                        todo.ngaybatdau,
                        todo.ngayketthuc,
                        todo.phamvi,
                        todo.trangthai
                    });
                }
            }
            //dataGridView1.Columns.Add("task_id", "Mã công việc");
            //dataGridView1.Columns.Add("tencongviec", "Tên công việc");
            //dataGridView1.Columns.Add("tennguoitao", "Tên người tạo");
            //dataGridView1.Columns.Add("nguoilamchung", "Người làm chung");
            //dataGridView1.Columns.Add("ngaybatdau", "Ngày bắt đầu");
            //dataGridView1.Columns.Add("ngayketthuc", "Ngày kết thúc");
            //dataGridView1.Columns.Add("phamvi", "Phạm Vi");
            //dataGridView1.Columns.Add("trangthai", "Trạng thái");

            //dataGridView1.Columns["ngaybatdau"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGridView1.Columns["ngayketthuc"].DefaultCellStyle.Format = "dd/MM/yyyy";

            //foreach (DataGridViewColumn column in dataGridView1.Columns)
            //{
            //    column.DataPropertyName = column.Name;
            //}

            dataGridView1.DataSource = data;
            
        }
 
        

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Add_To_Do atd = new Add_To_Do(this.userName);
            atd.ShowDialog();
            load_data();
            //this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Role_Users_DTO temp = sender as Role_Users_DTO;
            //Edit_To_Do etd = new Edit_To_Do();
            //etd.ShowDialog();
        }

        private void Role_Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Chua exit hoan toan
            //if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }

        private void Role_Users_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //Login login = new Login();
            //login.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            String str = txbSearch.Text;
            var result = new BUS.Role_Users_BUS().Search(str);
            List<object> data = new List<object>();
            foreach (var todo in result)
            {
                data.Add(new
                {
                    todo.task_id,
                    todo.tencongviec,
                    todo.tennguoitao,
                    todo.nguoilamchung,
                    todo.ngaybatdau,
                    todo.ngayketthuc,
                    todo.phamvi,
                    todo.trangthai
                });
            }

            dataGridView1.Columns.Add("task_id", "Mã công việc");
            dataGridView1.Columns.Add("tencongviec", "Tên công việc");
            dataGridView1.Columns.Add("tennguoitao", "Tên người tạo");
            dataGridView1.Columns.Add("nguoilamchung", "Người làm chung");
            dataGridView1.Columns.Add("ngaybatdau", "Ngày bắt đầu");
            dataGridView1.Columns.Add("ngayketthuc", "Ngày kết thúc");
            dataGridView1.Columns.Add("phamvi", "Phạm Vi");
            dataGridView1.Columns.Add("trangthai", "Trạng thái");

            dataGridView1.Columns["ngaybatdau"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["ngayketthuc"].DefaultCellStyle.Format = "dd/MM/yyyy";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            dataGridView1.DataSource = data;

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            //Info_User iu = new Info_User(userName);
            //iu.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //Info_User iu = new Info_User(userName);
            //iu.ShowDialog();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string[] nguoitao = dataGridView1.CurrentRow.Cells[2].Value.ToString().Split('-');
            if (this.role_id == "002")
            {
                if(nguoitao[0] == this.userName) //0-id 1-fullname
                {
                    string task_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string tencongviec = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string nguoilamchung = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    DateTime ngaybatdau = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
                    DateTime ngayketthuc = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
                    string phamvi = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    string trangthai = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                    Role_Users_DTO temp = sender as Role_Users_DTO;
                    Edit_To_Do etd = new Edit_To_Do(this.userName, task_id, tencongviec, nguoitao[1], nguoilamchung, ngaybatdau, ngayketthuc, phamvi, trangthai);
                    etd.ShowDialog();
                    load_data();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn chỉ có thể sửa công việc mà mình tạo! Trân trọng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string task_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string tencongviec = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string nguoilamchung = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                DateTime ngaybatdau = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
                DateTime ngayketthuc = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
                string phamvi = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                string trangthai = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                Role_Users_DTO temp = sender as Role_Users_DTO;
                Edit_To_Do etd = new Edit_To_Do(this.userName, task_id, tencongviec, nguoitao[1], nguoilamchung, ngaybatdau, ngayketthuc, phamvi, trangthai);
                etd.ShowDialog();
                load_data();
                //this.Close();
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            String task_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string[] nguoitao = dataGridView1.CurrentRow.Cells[2].Value.ToString().Split('-');
            if (this.role_id == "002")
            {
                if (nguoitao[0] == this.userName) //0-id 1-fullname
                {
                    if (new BUS.Add_To_Do_BUS().check_exists_task_in_order_table(task_id) == 1)
                    {
                        MessageBox.Show("Xóa thất bại! công việc này có dữ liệu nằm trong bảng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        new BUS.Add_To_Do_BUS().delete_task(this.userName, task_id);
                        MessageBox.Show("Xóa công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chỉ có thể xóa công việc mà mình tạo! Trân trọng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (new BUS.Add_To_Do_BUS().check_exists_task_in_order_table(task_id) == 1)
                {
                    MessageBox.Show("Xóa thất bại! công việc này có dữ liệu nằm trong bảng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    new BUS.Add_To_Do_BUS().delete_task(this.userName, task_id);
                    MessageBox.Show("Xóa công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                }
            }

        }

        private void BtnComment_Click(object sender, EventArgs e)
        {
            String task_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Comment c = new Comment(task_id, this.userName);
            c.ShowDialog();
        }
    }
}

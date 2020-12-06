using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.GUI
{
    public partial class Comment : Form
    {
        public string task_id = "";
        public string user_id = "";
        public int key_id_comment = 5;
        public Comment()
        {
            InitializeComponent();
            load_data();
        }

        public Comment(string task_id, string user_id)
        {
            this.task_id = task_id;
            this.user_id = user_id;
            InitializeComponent();
            load_data();
        }


        public void load_data()
        {
            dataGridViewCommentList.DataSource = null;
            dataGridViewCommentList.Columns.Add("task_id", "Mã cv");
            dataGridViewCommentList.Columns.Add("title", "Tên cv");
            dataGridViewCommentList.Columns.Add("user_id", "Mã nv");
            dataGridViewCommentList.Columns.Add("fullname", "Tên nv");
            dataGridViewCommentList.Columns.Add("content", "Nội dung");
            dataGridViewCommentList.Columns.Add("create_date", "Ngày tạo");

            dataGridViewCommentList.Columns["create_date"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";

            foreach (DataGridViewColumn column in dataGridViewCommentList.Columns)
            {
                column.DataPropertyName = column.Name;
            }
            dataGridViewCommentList.DataSource = new BUS.Comment_BUS().load_comment(this.task_id);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnResetData_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void BtnSearchComment_Click(object sender, EventArgs e)
        {
            dataGridViewCommentList.DataSource = null;
            dataGridViewCommentList.Columns.Add("task_id", "Mã cv");
            dataGridViewCommentList.Columns.Add("title", "Tên cv");
            dataGridViewCommentList.Columns.Add("user_id", "Mã nv");
            dataGridViewCommentList.Columns.Add("fullname", "Tên nv");
            dataGridViewCommentList.Columns.Add("content", "Nội dung");
            dataGridViewCommentList.Columns.Add("create_date", "Ngày tạo");

            dataGridViewCommentList.Columns["create_date"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";

            foreach (DataGridViewColumn column in dataGridViewCommentList.Columns)
            {
                column.DataPropertyName = column.Name;
            }
            dataGridViewCommentList.DataSource = new BUS.Comment_BUS().search_comment(this.task_id,txbSearchHistory.Text);
        }

        private void BtnComment_Click(object sender, EventArgs e)
        {
            new BUS.Comment_BUS().comment(this.task_id,this.user_id,txbComment.Text, "cm_" + this.key_id_comment);
            this.key_id_comment = this.key_id_comment + 1;
            load_data();
            MessageBox.Show("Gửi bình luận thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

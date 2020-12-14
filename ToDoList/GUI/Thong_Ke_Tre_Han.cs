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
    public partial class Thong_Ke_Tre_Han : Form
    {

        public string user_id_exe;
        public Thong_Ke_Tre_Han(string user_id_exe)
        {
            this.user_id_exe = user_id_exe;
            InitializeComponent();
            load_nv();
            //dataGridView1.Columns.Add("task_id", "Mã công việc");
            //dataGridView1.Columns.Add("title", "Tên công việc");
            ////dataGridView1.Columns.Add("user_id", "Mã nhân viên");
            //dataGridView1.Columns.Add("state", "Trạng thái");
            //dataGridView1.Columns.Add("fromdate", "Ngày bắt đầu");
            //dataGridView1.Columns.Add("todate", "Ngày kết thúc");

            //dataGridView1.Columns["fromdate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGridView1.Columns["todate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            //foreach (DataGridViewColumn column in dataGridView1.Columns)
            //{
            //    column.DataPropertyName = column.Name;
            //}

            //dataGridView1.DataSource = null;
        }

        public void load_nv()
        {
            comboBoxNhanVien.DataSource = new DAO.Thong_Ke_DAO().load_danh_sach_nv();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExe_Click(object sender, EventArgs e)
        {
            if (comboBoxState.Text != "" && comboBoxNhanVien.Text != "")
            {
                dataGridView1.DataSource = null;
                var dem = 0;
                DateTime temp = dateTimePicker1Edit.Value;
                var res = new BUS.Thong_Ke_BUS().thong_ke_tre_han(this.user_id_exe,comboBoxNhanVien.Text,comboBoxState.Text, dateTimePicker1Edit.Value, dateTimePicker1.Value);
                foreach (var item in res)
                {
                    dem++;
                }
                labelTotal.Text = dem.ToString();
                dem = 0;
                List<object> data = new List<object>();
                foreach (task todo in res)
                {
                    data.Add(new
                    {
                        todo.task_id,
                        todo.title,
                        todo.state,
                        todo.fromdate,
                        todo.todate,
                    });
                }

                dataGridView1.Columns.Add("task_id", "Mã công việc");
                dataGridView1.Columns.Add("title", "Tên công việc");
                //dataGridView1.Columns.Add("user_id", "Mã nhân viên");
                dataGridView1.Columns.Add("state", "Trạng thái");
                dataGridView1.Columns.Add("fromdate", "Ngày bắt đầu");
                dataGridView1.Columns.Add("todate", "Ngày kết thúc");

                dataGridView1.Columns["fromdate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns["todate"].DefaultCellStyle.Format = "dd/MM/yyyy";

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.DataPropertyName = column.Name;
                }

                dataGridView1.DataSource = null;

                dataGridView1.DataSource = data;

                MessageBox.Show("Thống kê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(comboBoxNhanVien.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}

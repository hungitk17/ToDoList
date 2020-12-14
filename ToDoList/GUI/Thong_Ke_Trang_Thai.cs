using System;
using System.Collections;
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
    public partial class Thong_Ke_Trang_Thai : Form
    {
        public string user_id_exe;
        public Thong_Ke_Trang_Thai(string user_id_exe)
        {
            this.user_id_exe = user_id_exe;
            InitializeComponent();
            //dataGridViewState.Columns.Add("task_id", "Mã công việc");
            //dataGridViewState.Columns.Add("title", "Tên công việc");
            ////dataGridViewState.Columns.Add("scope", "Phạm Vi");
            //dataGridViewState.Columns.Add("state", "Trạng thái");
            //dataGridViewState.Columns.Add("fromdate", "Ngày bắt đầu");
            //dataGridViewState.Columns.Add("todate", "Ngày kết thúc");

            //dataGridViewState.Columns["fromdate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGridViewState.Columns["todate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            //foreach (DataGridViewColumn column in dataGridViewState.Columns)
            //{
            //    column.DataPropertyName = column.Name;
            //}

            //dataGridViewState.DataSource = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExe_Click(object sender, EventArgs e)
        {
            if(comboBoxState.Text != "")
            {
                dataGridViewState.DataSource = null;
                var dem = 0;
                DateTime temp = thoigianbatdau.Value;
                var res = new BUS.Thong_Ke_BUS().thong_ke_trang_thai(this.user_id_exe,comboBoxState.Text, thoigianbatdau.Value, thoigianketthuc.Value);
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

                dataGridViewState.Columns.Add("task_id", "Mã công việc");
                dataGridViewState.Columns.Add("title", "Tên công việc");
                //dataGridViewState.Columns.Add("scope", "Phạm Vi");
                dataGridViewState.Columns.Add("state", "Trạng thái");
                dataGridViewState.Columns.Add("fromdate", "Ngày bắt đầu");
                dataGridViewState.Columns.Add("todate", "Ngày kết thúc");

                dataGridViewState.Columns["fromdate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewState.Columns["todate"].DefaultCellStyle.Format = "dd/MM/yyyy";

                foreach (DataGridViewColumn column in dataGridViewState.Columns)
                {
                    column.DataPropertyName = column.Name;
                }

                dataGridViewState.DataSource = data;

                MessageBox.Show("Thống kê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Thong_Ke_Trang_Thai_Load(object sender, EventArgs e)
        {
            thoigianbatdau.Format = DateTimePickerFormat.Custom;
            thoigianbatdau.CustomFormat = "dd-MM-yyyy";
            thoigianketthuc.Format = DateTimePickerFormat.Custom;
            thoigianketthuc.CustomFormat = "dd-MM-yyyy";
        }
    }
}

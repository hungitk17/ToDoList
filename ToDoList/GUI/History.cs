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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            dataGridViewHistoryList.DataSource = null;
            dataGridViewHistoryList.Columns.Add("his_id", "Mã lịch sử");
            dataGridViewHistoryList.Columns.Add("user_id", "Mã người dùng");
            dataGridViewHistoryList.Columns.Add("fullname", "Tên");
            dataGridViewHistoryList.Columns.Add("action", "Thao tác");
            dataGridViewHistoryList.Columns.Add("create_date", "Ngày tạo");

            foreach (DataGridViewColumn column in dataGridViewHistoryList.Columns)
            {
                column.DataPropertyName = column.Name;
            }
            dataGridViewHistoryList.DataSource = new BUS.History_BUS().load_history();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearchHistory_Click(object sender, EventArgs e)
        {
            //Search History
            dataGridViewHistoryList.DataSource = null;
            dataGridViewHistoryList.Columns.Add("his_id", "Mã lịch sử");
            dataGridViewHistoryList.Columns.Add("user_id", "Mã người dùng");
            dataGridViewHistoryList.Columns.Add("fullname", "Tên");
            dataGridViewHistoryList.Columns.Add("action", "Thao tác");
            dataGridViewHistoryList.Columns.Add("create_date", "Ngày tạo");

            foreach (DataGridViewColumn column in dataGridViewHistoryList.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            dataGridViewHistoryList.DataSource = new BUS.History_BUS().search_history(txbSearchHistory.Text);

        }

        private void BtnResetData_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}

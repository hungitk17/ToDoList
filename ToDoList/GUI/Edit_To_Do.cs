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
    public partial class Edit_To_Do : Form
    {
        public string task_id;
        public string tencongviec;
        public string nguoitao;
        public string nguoilamchung;
        public DateTime ngaybatdau;
        public DateTime ngayketthuc;
        public string phamvi;
        public string trangthai;
        public string[] arr_nguoilamchung;
        public string userName;


        string selectedItemText;
        int selectedIndex;
        List<string> data1;
        List<string> data2;

        public Edit_To_Do()
        {
            InitializeComponent();
        }

        public Edit_To_Do(string userName,string task_id,string tencongviec,string nguoitao,string nguoilamchung,DateTime ngaybatdau, DateTime ngayketthuc,string phamvi,string trangthai)
        {
            InitializeComponent();
            this.userName = userName;
            this.task_id = task_id;
            this.tencongviec = tencongviec;
            this.nguoitao = nguoitao;
            this.nguoilamchung = nguoilamchung;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.phamvi = phamvi;
            this.trangthai = trangthai;

            txbNameDoEdit.Text = tencongviec;
            txbTaskId.Text = task_id;
            cbbScoreEdit.Text = phamvi;
            comboBoxStatus.Text = trangthai;
            dateTimePicker1Edit.Value = ngaybatdau;
            dateTimePicker2Edit.Value = ngayketthuc;
            arr_nguoilamchung = nguoilamchung.Split('-');

            var res = new BUS.Add_To_Do_BUS().load_user();
            var dem = 0;
            data2 = new List<string>();
            data1 = new List<string>();
            foreach (user item in res)
            {
                foreach(string user in arr_nguoilamchung)
                {
                    if (item.fullname == user && item.user_id != this.userName)
                    {
                        data2.Add(item.user_id + "-" + item.fullname);
                        break;
                    }
                    dem++;
                    if(dem >= arr_nguoilamchung.Length && item.user_id != this.userName)
                    {
                        data1.Add(item.user_id + "-" + item.fullname);
                        break;
                    }
                }
            }


            listBoxEdit.DataSource = data1;
            listBoxEdit2.DataSource = data2;

            


        }

        private void Button1edit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {

            if (listBoxEdit.SelectedIndex != -1)
            {
                selectedItemText = listBoxEdit.SelectedItem.ToString();
                selectedIndex = listBoxEdit.SelectedIndex;
                //listBoxEdit2.Items.Add(selectedItemText);
                data2.Add(selectedItemText);
                data1.RemoveAt(selectedIndex);
            }
            DataBinding();
        }

        private void DataBinding()
        {
            listBoxEdit.DataSource = null;
            listBoxEdit.DataSource = data1;
            listBoxEdit2.DataSource = null;
            listBoxEdit2.DataSource = data2;
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (listBoxEdit2.SelectedIndex != -1)
            {
                selectedItemText = listBoxEdit2.SelectedItem.ToString();
                selectedIndex = listBoxEdit2.SelectedIndex;
                data1.Add(selectedItemText);
                data2.RemoveAt(listBoxEdit2.Items.IndexOf(listBoxEdit2.SelectedItem));
            }
            DataBinding();
        }

        private void BtnRightALl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxEdit.Items.Count; i++)
            {
                data2.Add(listBoxEdit.Items[i].ToString());
                data1.RemoveAt(0);
            }

            DataBinding();
        }

        private void BtnLeftAll_Click(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < listBoxEdit2.Items.Count; i++)
            {
                //listBoxEdit.Items.Edit(listBoxEdit2.Items[i].ToString());
                data1.Add(listBoxEdit2.Items[i].ToString());
                temp.Add(listBoxEdit2.Items[i].ToString());
                //listBoxEdit2.Items.RemoveAt(listBoxEdit2.Items.IndexOf(listBoxEdit2.SelectedItem));
            }

            for (int i = 0; i < temp.Count; i++)
            {
                data2.RemoveAt(0);
            }

            DataBinding();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string tencongviec = txbNameDoEdit.Text;
            string score = cbbScoreEdit.Text;
            string status = comboBoxStatus.Text;
            DateTime ngaybatdau = dateTimePicker1Edit.Value;
            DateTime ngayketthuc = dateTimePicker2Edit.Value;
            string task_id = txbTaskId.Text;
            string result = "";
            if (tencongviec == "")
            {
                result += "Tên công việc không được bỏ trống! \n";
            }
            if (score == "")
            {
                result += "Phạm vi không được bỏ trống! \n";
            }
            if (status == "")
            {
                result += "Trạng thái không được bỏ trống! \n";
            }
            if (ngaybatdau > ngayketthuc)
            {
                result += "Thời gian không hợp lệ! \n";
            }
            if (result != "")
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] subs;
                List<string> arr_nguoilamchung = new List<string>();
                for (int i = 0; i < listBoxEdit2.Items.Count; i++)
                {
                    subs = listBoxEdit2.Items[i].ToString().Split('-');
                    arr_nguoilamchung.Add(subs[0]);
                }
                new BUS.Add_To_Do_BUS().edit_task(task_id, this.userName, tencongviec, score, status, ngaybatdau, ngayketthuc, arr_nguoilamchung);
                if (MessageBox.Show("Sửa công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
                //MessageBox.Show("Sửa công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
        }
    }
}

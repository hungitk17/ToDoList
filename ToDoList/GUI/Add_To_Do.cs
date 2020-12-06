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
    public partial class Add_To_Do : Form
    {

        public string userName = "";

        string selectedItemText;
        int selectedIndex;
        List<string> data;

        public Add_To_Do()
        {
            InitializeComponent();
            load_user_listbox();
        }

        public Add_To_Do(string userName)
        {
            this.userName = userName;
            InitializeComponent();
            load_user_listbox();
        }

        public void load_user_listbox()
        {
            var res = new BUS.Add_To_Do_BUS().load_user();
            data = new List<string>();
            foreach(user item in res)
            {
                if(item.user_id != this.userName)
                {
                    data.Add(item.fullname);
                }
            }

            listBoxAdd.DataSource = data;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            //string index = "";
            //foreach (object item in listBoxAdd.SelectedItems)
            //{
            //    listBoxAdd2.Items.Add(item);
            //}


            //listBoxAdd.Items.Remove(index);

            if (listBoxAdd.SelectedIndex != -1)
            {
                selectedItemText = listBoxAdd.SelectedItem.ToString();
                selectedIndex = listBoxAdd.SelectedIndex;
                listBoxAdd2.Items.Add(selectedItemText);
                data.RemoveAt(selectedIndex);
            }
            DataBinding();
        }

        private void DataBinding()
        {
            listBoxAdd.DataSource = null;
            listBoxAdd.DataSource = data;
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            //string index = "";
            //foreach (string item in listBoxAdd2.SelectedItems)
            //{
            //    listBoxAdd.Items.Add(item);
            //    index = item;
            //}
            //listBoxAdd2.Items.Remove(index);
            if (listBoxAdd2.SelectedIndex != -1)
            {
                selectedItemText = listBoxAdd2.SelectedItem.ToString();
                selectedIndex = listBoxAdd2.SelectedIndex;
                data.Add(selectedItemText);
                listBoxAdd2.Items.RemoveAt(listBoxAdd2.Items.IndexOf(listBoxAdd2.SelectedItem));
            }
            DataBinding();
            
            
        }

        private void BtnRightALl_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBoxAdd.Items.Count; i++)
            {
                listBoxAdd2.Items.Add(listBoxAdd.Items[i].ToString());
                data.RemoveAt(0);
            }

            DataBinding();
        }

        private void BtnLeftAll_Click(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < listBoxAdd2.Items.Count; i++)
            {
                //listBoxAdd.Items.Add(listBoxAdd2.Items[i].ToString());
                data.Add(listBoxAdd2.Items[i].ToString());
                temp.Add(listBoxAdd2.Items[i].ToString());
                //listBoxAdd2.Items.RemoveAt(listBoxAdd2.Items.IndexOf(listBoxAdd2.SelectedItem));
            }

            for (int i = 0; i < temp.Count; i++)
            {
                listBoxAdd2.Items.RemoveAt(listBoxAdd2.Items.IndexOf(temp[i]));
            }

            DataBinding();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string tencongviec = txbNameDo.Text;
            string score = cbbScore.Text;
            string status = cbbState.Text;
            DateTime ngaybatdau = ngaybatdaudata.Value;
            DateTime ngayketthuc = ngayketthucdata.Value;
            string result = "";
            if(tencongviec == "")
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
            if(ngaybatdau > ngayketthuc)
            {
                result += "Thời gian không hợp lệ! \n";
            }
            if(result != "")
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            List<string> temp = new List<string>();
            for (int i = 0; i < listBoxAdd2.Items.Count; i++)
            {
                temp.Add(listBoxAdd2.Items[i].ToString());
            }
        }
    }
}

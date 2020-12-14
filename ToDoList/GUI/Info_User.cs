﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.GUI
{
    public partial class Info_User : Form
    {
        private String userName;
        public string role_id;
        public string password;
        public Info_User(String userName,string role_id)
        {
            this.role_id = role_id;
            this.userName = userName;
            InitializeComponent();
            loadData();
            if(this.role_id == "002")
            {
                btnAdd.Visible = false;
                button3.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void loadData()
        {


            //1
            ArrayList result = new BUS.LoginBUS().get_Info_User(userName);
            label_name.Text = result[0].ToString();
            label_sdt.Text = result[1].ToString();
            label_email.Text = result[2].ToString();
            label_username.Text = result[3].ToString();
            //label_pass.Text = result[4].ToString();
            label_role.Text = result[5].ToString();

            //2
            txbHoTen.Text = result[0].ToString();
            txbSdt.Text = result[1].ToString();
            txbEmail.Text = result[2].ToString();
            txbUsername.Text = result[3].ToString();
            //label_pass.Text = result[4].ToString();
            txbChucVu.Text = result[5].ToString();

            //3
            this.password = result[4].ToString();
            dataGridViewUserList.DataSource = null;
            dataGridViewUserList.Columns.Add("user_id", "Tài khoản");
            dataGridViewUserList.Columns.Add("fullname", "Tên");
            dataGridViewUserList.Columns.Add("phone", "Số điện thoại");
            dataGridViewUserList.Columns.Add("email", "Email");
            dataGridViewUserList.Columns.Add("name", "Chức vụ");

            foreach (DataGridViewColumn column in dataGridViewUserList.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            dataGridViewUserList.DataSource = new BUS.Role_Users_BUS().load_user(txbUsername.Text);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //change Info User
            string result = "";
            if(txbHoTen.Text.ToString() == "")
            {
                result += "Họ tên không được để trống! \n";
            }
            if (txbChucVu.Text.ToString() == "")
            {
                result += "Chức vụ không được để trống! \n";
            }
            if (txbEmail.Text.ToString() == "")
            {
                result += "Email không được để trống! \n";
            }
            else
            {
                bool flag_check_mail = false;
                try
                {
                    MailAddress m = new MailAddress(txbEmail.Text);

                    flag_check_mail = true;
                }
                catch (FormatException)
                {
                    flag_check_mail = false;
                }

                if (flag_check_mail == false)
                {
                    result += "Email không hợp lệ! \n";
                }

            }

            if (txbSdt.Text.ToString() == "")
            {
                result += "Số điện thoại không được để trống! \n";
            }
            else
            {
                if (txbSdt.Text.Length != 10)
                {
                    result += "Số điện thoại không hợp lệ! \n";
                }
            }

            if (result != "")
            {
                MessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int res = new BUS.Role_Users_BUS().changeInfoUser(txbUsername.Text, txbHoTen.Text, txbSdt.Text, txbEmail.Text);
                if(res == 1)
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin nhân viên thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            //Change Password
            int checkOldPass = new BUS.Role_Users_BUS().checkOldPassword(txbUsername.Text, txbOldPass.Text); ;
            string result = "";
            if (txbOldPass.Text.ToString() == "")
            {
                result += "Mật khẩu cũ không được bỏ trống! \n";
            }
            if (txbNewPass.Text.ToString() == "")
            {
                result += "Mật khẩu mới không được bỏ trống! \n";
            }
            if (txbAgianPass.Text.ToString() == "")
            {
                result += "Nhập lại mật khẩu mới không được bỏ trống! \n";
            }
            if (result != "")
            {
                MessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(checkOldPass == 1)
            {
                if(txbNewPass.Text != txbAgianPass.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu mới không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var res = new BUS.Role_Users_BUS().changePassword(txbUsername.Text, txbNewPass.Text);
                    if (res == 1)
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbOldPass.Text = "";
                        txbNewPass.Text = "";
                        txbAgianPass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi mật khẩu thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            //Search User
            dataGridViewUserList.DataSource = null;
            dataGridViewUserList.Columns.Add("user_id", "Tài khoản");
            dataGridViewUserList.Columns.Add("fullname", "Tên");
            dataGridViewUserList.Columns.Add("phone", "Số điện thoại");
            dataGridViewUserList.Columns.Add("email", "Email");
            dataGridViewUserList.Columns.Add("name", "Chức vụ");

            foreach (DataGridViewColumn column in dataGridViewUserList.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            dataGridViewUserList.DataSource = new BUS.Role_Users_BUS().searchUser(txbUsername.Text, txbSearchUser.Text);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add_User add = new Add_User(this.userName);
            add.ShowDialog();
            loadData();
            //this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string user_id = dataGridViewUserList.CurrentRow.Cells[0].Value.ToString();
            if(new BUS.Role_Users_BUS().check_user_exit(user_id) == 1)
            {
                MessageBox.Show("Xóa thất bại. Dữ liệu người dùng có nằm trong bảng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xóa người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new BUS.Role_Users_BUS().delete_user(this.userName,user_id);
                loadData();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string userName = dataGridViewUserList.CurrentRow.Cells[0].Value.ToString();
            string HoTen = dataGridViewUserList.CurrentRow.Cells[1].Value.ToString();
            string sdt = dataGridViewUserList.CurrentRow.Cells[2].Value.ToString();
            string email = dataGridViewUserList.CurrentRow.Cells[3].Value.ToString();
            string chucVu = dataGridViewUserList.CurrentRow.Cells[4].Value.ToString();
            Edit_User edit = new Edit_User(this.userName,userName, HoTen, sdt, email, chucVu, this.password);
            edit.ShowDialog();
            loadData();
            //this.Close();
        }
    }
}

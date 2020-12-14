using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.GUI
{
    public partial class Edit_User : Form
    {

        public string userName;
        public string hoTen;
        public string sdt;
        public string email;
        public string chucVu;
        public string user_id_exe;
        public string password;
        public Edit_User()
        {
            InitializeComponent();
        }
        
        public Edit_User(string user_id_exe,string userName, string hoTen, string sdt, string email, string chucVu,string password)
        {
            this.password = password;
            this.user_id_exe = user_id_exe;
            this.userName = userName;
            this.hoTen = hoTen;
            this.sdt = sdt;
            this.email = email;
            this.chucVu = chucVu;
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            txbUsername.Text = this.userName;
            txbEmail.Text = this.email;
            txbSdt.Text = this.sdt;
            txbChucVu.Text = this.chucVu;
            txbHoTen.Text = this.hoTen;
            txbPass.Text = this.password;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string result = "";

            if (txbHoTen.Text == "")
            {
                result += "Họ tên không được để trống! \n";
            }

            if (txbSdt.Text == "")
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

            if (txbPass.Text == "")
            {
                result += "Mật khẩu không được để trống! \n";
            }
            else
            {
                if (!Regex.Match(txbPass.Text, "[A-Za-z0-9]{6,}").Success)
                {
                    result += "Mật khẩu phải bao gồm 6 ký tự trở lên. Và không chứ ký tự đặt biệt! \n";
                }
            }

            if (result != "")
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new BUS.Role_Users_BUS().edit_user(this.user_id_exe,txbHoTen.Text, txbSdt.Text, txbUsername.Text, txbPass.Text);
                if(MessageBox.Show("Sửa người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }

        }
    }
}

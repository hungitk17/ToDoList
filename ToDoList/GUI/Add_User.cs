using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.GUI
{
    public partial class Add_User : Form
    {

        public string userName;
        public Add_User(string userName)
        {
            this.userName = userName;
            InitializeComponent();
            load_role();
        }

        public void load_role()
        {
            cbbRole.DataSource = new BUS.Role_Users_BUS().load_role();
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

            if (txbUsername.Text == "")
            {
                result += "Tài khoản không được để trống! \n";
            }
            else
            {
                if (new BUS.Role_Users_BUS().check_uesr_name(txbUsername.Text) == 1)
                {
                    result += "Tài khoản đã tồn tại! \n";
                }
                else
                {
                    if (!Regex.Match(txbUsername.Text, "[A-Za-z0-9]{6,}").Success)
                    {
                        result += "Tài khoản phải bao gồm 6 ký tự trở lên. Và không chứ ký tự đặt biệt! \n";
                    }
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
                else
                {
                    if (txbPass.Text != txbPassAgain.Text)
                    {
                        result += "Nhập lại mật khẩu không đúng! \n";
                    }
                }
            }

            if (txbPassAgain.Text == "")
            {
                result += "Nhập lại mật khẩu không được để trống! \n";
            }

            if (txbEmail.Text == "")
            {
                result += "Email không được để trống! \n";
            }
            else
            {
                if (new BUS.Role_Users_BUS().check_email_exists(txbEmail.Text) == 1)
                {
                    result += "Email đã tồn tại! \n";
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
            }

            if (cbbRole.Text == "")
            {
                result += "Chức vụ không được để trống! \n";
            }

            if (result != "")
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new BUS.Role_Users_BUS().add_user(this.userName,txbHoTen.Text, txbEmail.Text, cbbRole.Text, txbSdt.Text, txbUsername.Text, txbPass.Text);
                if(MessageBox.Show("Thêm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}

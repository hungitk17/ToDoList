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

namespace ToDoList
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            BUS.LoginBUS loginBus = new BUS.LoginBUS();
            String userName = txbUserName.Text;
            String password = txbPassword.Text;
            ArrayList result = loginBus.check_login(userName,password);
            //001-Lanh Dao 002-NhanVien
            if(result[0].ToString() == "success")
            {
                //GUI.Role_Users view = new GUI.Role_Users(result[1].ToString(),userName);
                //this.Hide();
                //view.ShowDialog();
                GUI.To_Do_Main view = new GUI.To_Do_Main(result[1].ToString(), result[3].ToString(), result[2].ToString());
                this.Hide();
                view.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

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

    // yyyy/MM/dd
    public partial class To_Do_Main : Form
    {
        private string fullName = "";
        public string userName = "";
        public To_Do_Main()
        {
            InitializeComponent();
            customizeDesing();
        }
   
        public To_Do_Main(string fullName, string userName)
        {
            this.fullName = fullName;
            this.userName = userName;
            InitializeComponent();
            customizeDesing();
        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void customizeDesing()
        {
            panelThongKe.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelThongKe.Visible == true)
            {
                panelThongKe.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }else
            {
                subMenu.Visible = false;
            }
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongKe);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Thong_Ke_Tre_Han());
            // Thong ke cong viec tre hen
            hideSubMenu();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Thong_Ke_Trang_Thai());
            // Thong ke cong viec theo trang thai
            hideSubMenu();
        }

        private void ManagementToDo_Click(object sender, EventArgs e)
        {
            openChildForm(new Role_Users(this.fullName.ToString(), this.userName));
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void To_Do_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void ManagementUser_Click(object sender, EventArgs e)
        {
            openChildForm(new Info_User(this.userName));
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new History());
        }
    }
}

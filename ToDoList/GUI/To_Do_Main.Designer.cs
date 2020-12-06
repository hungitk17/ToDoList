namespace ToDoList.GUI
{
    partial class To_Do_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelThongKe = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ThongKe = new System.Windows.Forms.Button();
            this.ManagementToDo = new System.Windows.Forms.Button();
            this.ManagementUser = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMainBottom = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelThongKe.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMainBottom.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnHistory);
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.panelThongKe);
            this.panelSideMenu.Controls.Add(this.ThongKe);
            this.panelSideMenu.Controls.Add(this.ManagementToDo);
            this.panelSideMenu.Controls.Add(this.ManagementUser);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 590);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnHistory.Location = new System.Drawing.Point(0, 328);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(250, 45);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "Quản lý lịch sử";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnExit.Location = new System.Drawing.Point(0, 545);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panelThongKe
            // 
            this.panelThongKe.Controls.Add(this.button2);
            this.panelThongKe.Controls.Add(this.button1);
            this.panelThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongKe.Location = new System.Drawing.Point(0, 235);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Size = new System.Drawing.Size(250, 93);
            this.panelThongKe.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Location = new System.Drawing.Point(0, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Công việc theo trạng thái";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Công việc trễ hạn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ThongKe
            // 
            this.ThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongKe.FlatAppearance.BorderSize = 0;
            this.ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThongKe.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ThongKe.Location = new System.Drawing.Point(0, 190);
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ThongKe.Size = new System.Drawing.Size(250, 45);
            this.ThongKe.TabIndex = 3;
            this.ThongKe.Text = "Quản lý thống kê";
            this.ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThongKe.UseVisualStyleBackColor = true;
            this.ThongKe.Click += new System.EventHandler(this.ThongKe_Click);
            // 
            // ManagementToDo
            // 
            this.ManagementToDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagementToDo.FlatAppearance.BorderSize = 0;
            this.ManagementToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagementToDo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ManagementToDo.Location = new System.Drawing.Point(0, 145);
            this.ManagementToDo.Name = "ManagementToDo";
            this.ManagementToDo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ManagementToDo.Size = new System.Drawing.Size(250, 45);
            this.ManagementToDo.TabIndex = 2;
            this.ManagementToDo.Text = "Quản lý công việc";
            this.ManagementToDo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagementToDo.UseVisualStyleBackColor = true;
            this.ManagementToDo.Click += new System.EventHandler(this.ManagementToDo_Click);
            // 
            // ManagementUser
            // 
            this.ManagementUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagementUser.FlatAppearance.BorderSize = 0;
            this.ManagementUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagementUser.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ManagementUser.Location = new System.Drawing.Point(0, 100);
            this.ManagementUser.Name = "ManagementUser";
            this.ManagementUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ManagementUser.Size = new System.Drawing.Size(250, 45);
            this.ManagementUser.TabIndex = 1;
            this.ManagementUser.Text = "Quản lý người dùng";
            this.ManagementUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagementUser.UseVisualStyleBackColor = true;
            this.ManagementUser.Click += new System.EventHandler(this.ManagementUser_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ToDoList.Properties.Resources.logoToDoList_removebg_preview__2_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelMainBottom
            // 
            this.panelMainBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelMainBottom.Controls.Add(this.label2);
            this.panelMainBottom.Controls.Add(this.label1);
            this.panelMainBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainBottom.Location = new System.Drawing.Point(250, 551);
            this.panelMainBottom.Name = "panelMainBottom";
            this.panelMainBottom.Size = new System.Drawing.Size(860, 39);
            this.panelMainBottom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(724, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created by team 16.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "© 2019-2020 Flexera Software Co.,Ltd. All rights reserved.";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(860, 551);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToDoList.Properties.Resources.logoToDoList_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(868, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // To_Do_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 590);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMainBottom);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1018, 609);
            this.Name = "To_Do_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý công việc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.To_Do_Main_FormClosing);
            this.panelSideMenu.ResumeLayout(false);
            this.panelThongKe.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMainBottom.ResumeLayout(false);
            this.panelMainBottom.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelThongKe;
        private System.Windows.Forms.Button ManagementToDo;
        private System.Windows.Forms.Button ManagementUser;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelMainBottom;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ThongKe;
    }
}
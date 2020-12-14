namespace ToDoList.GUI
{
    partial class Edit_To_Do
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbNameDoEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTaskId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxEdit2 = new System.Windows.Forms.ListBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.btnRightALl = new System.Windows.Forms.Button();
            this.listBoxEdit = new System.Windows.Forms.ListBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1edit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2Edit = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1Edit = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbScoreEdit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "SỬA CÔNG VIỆC";
            // 
            // txbNameDoEdit
            // 
            this.txbNameDoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameDoEdit.Location = new System.Drawing.Point(156, 4);
            this.txbNameDoEdit.Name = "txbNameDoEdit";
            this.txbNameDoEdit.Size = new System.Drawing.Size(216, 30);
            this.txbNameDoEdit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên công việc:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTaskId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.listBoxEdit2);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnLeftAll);
            this.panel1.Controls.Add(this.btnRightALl);
            this.panel1.Controls.Add(this.listBoxEdit);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1edit);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePicker2Edit);
            this.panel1.Controls.Add(this.dateTimePicker1Edit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbScoreEdit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbNameDoEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 523);
            this.panel1.TabIndex = 6;
            // 
            // txbTaskId
            // 
            this.txbTaskId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaskId.Location = new System.Drawing.Point(156, 73);
            this.txbTaskId.Name = "txbTaskId";
            this.txbTaskId.ReadOnly = true;
            this.txbTaskId.Size = new System.Drawing.Size(216, 30);
            this.txbTaskId.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Mã công việc:";
            // 
            // listBoxEdit2
            // 
            this.listBoxEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEdit2.FormattingEnabled = true;
            this.listBoxEdit2.ItemHeight = 20;
            this.listBoxEdit2.Location = new System.Drawing.Point(507, 202);
            this.listBoxEdit2.Name = "listBoxEdit2";
            this.listBoxEdit2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxEdit2.Size = new System.Drawing.Size(253, 244);
            this.listBoxEdit2.TabIndex = 35;
            // 
            // btnLeft
            // 
            this.btnLeft.AutoSize = true;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(445, 282);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(46, 35);
            this.btnLeft.TabIndex = 34;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.AutoSize = true;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(445, 218);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(46, 35);
            this.btnRight.TabIndex = 33;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.AutoSize = true;
            this.btnLeftAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftAll.Location = new System.Drawing.Point(445, 401);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(46, 35);
            this.btnLeftAll.TabIndex = 32;
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.UseVisualStyleBackColor = true;
            this.btnLeftAll.Click += new System.EventHandler(this.BtnLeftAll_Click);
            // 
            // btnRightALl
            // 
            this.btnRightALl.AutoSize = true;
            this.btnRightALl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightALl.Location = new System.Drawing.Point(445, 344);
            this.btnRightALl.Name = "btnRightALl";
            this.btnRightALl.Size = new System.Drawing.Size(46, 35);
            this.btnRightALl.TabIndex = 31;
            this.btnRightALl.Text = ">>";
            this.btnRightALl.UseVisualStyleBackColor = true;
            this.btnRightALl.Click += new System.EventHandler(this.BtnRightALl_Click);
            // 
            // listBoxEdit
            // 
            this.listBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEdit.FormattingEnabled = true;
            this.listBoxEdit.ItemHeight = 20;
            this.listBoxEdit.Location = new System.Drawing.Point(179, 202);
            this.listBoxEdit.Name = "listBoxEdit";
            this.listBoxEdit.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxEdit.Size = new System.Drawing.Size(252, 244);
            this.listBoxEdit.TabIndex = 30;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Đang làm",
            "Đã xong",
            "Trễ hạn"});
            this.comboBoxStatus.Location = new System.Drawing.Point(542, 70);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(216, 33);
            this.comboBoxStatus.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(393, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Trạng thái";
            // 
            // button1edit
            // 
            this.button1edit.AutoSize = true;
            this.button1edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1edit.Location = new System.Drawing.Point(602, 478);
            this.button1edit.Name = "button1edit";
            this.button1edit.Size = new System.Drawing.Size(75, 35);
            this.button1edit.TabIndex = 13;
            this.button1edit.Text = "Hủy";
            this.button1edit.UseVisualStyleBackColor = true;
            this.button1edit.Click += new System.EventHandler(this.Button1edit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(683, 478);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Người làm chung:";
            // 
            // dateTimePicker2Edit
            // 
            this.dateTimePicker2Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2Edit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2Edit.Location = new System.Drawing.Point(544, 140);
            this.dateTimePicker2Edit.Name = "dateTimePicker2Edit";
            this.dateTimePicker2Edit.Size = new System.Drawing.Size(216, 30);
            this.dateTimePicker2Edit.TabIndex = 9;
            // 
            // dateTimePicker1Edit
            // 
            this.dateTimePicker1Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1Edit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1Edit.Location = new System.Drawing.Point(156, 138);
            this.dateTimePicker1Edit.Name = "dateTimePicker1Edit";
            this.dateTimePicker1Edit.Size = new System.Drawing.Size(216, 30);
            this.dateTimePicker1Edit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // cbbScoreEdit
            // 
            this.cbbScoreEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbScoreEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbScoreEdit.FormattingEnabled = true;
            this.cbbScoreEdit.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.cbbScoreEdit.Location = new System.Drawing.Point(542, 4);
            this.cbbScoreEdit.Name = "cbbScoreEdit";
            this.cbbScoreEdit.Size = new System.Drawing.Size(216, 33);
            this.cbbScoreEdit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phạm vi:";
            // 
            // Edit_To_Do
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Edit_To_Do";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Công Việc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNameDoEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1edit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2Edit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbScoreEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxEdit2;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeftAll;
        private System.Windows.Forms.Button btnRightALl;
        private System.Windows.Forms.ListBox listBoxEdit;
        private System.Windows.Forms.TextBox txbTaskId;
        private System.Windows.Forms.Label label8;
    }
}
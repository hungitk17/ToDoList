namespace ToDoList.GUI
{
    partial class Add_To_Do
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNameDo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbtaskid = new System.Windows.Forms.TextBox();
            this.lableTaskId = new System.Windows.Forms.Label();
            this.cbbState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxAdd2 = new System.Windows.Forms.ListBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.btnRightALl = new System.Windows.Forms.Button();
            this.listBoxAdd = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ngayketthucdata = new System.Windows.Forms.DateTimePicker();
            this.ngaybatdaudata = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbScore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÊM CÔNG VIỆC";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
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
            // txbNameDo
            // 
            this.txbNameDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameDo.Location = new System.Drawing.Point(154, 4);
            this.txbNameDo.Name = "txbNameDo";
            this.txbNameDo.Size = new System.Drawing.Size(216, 30);
            this.txbNameDo.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbtaskid);
            this.panel1.Controls.Add(this.lableTaskId);
            this.panel1.Controls.Add(this.cbbState);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.listBoxAdd2);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnLeftAll);
            this.panel1.Controls.Add(this.btnRightALl);
            this.panel1.Controls.Add(this.listBoxAdd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ngayketthucdata);
            this.panel1.Controls.Add(this.ngaybatdaudata);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbScore);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbNameDo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 525);
            this.panel1.TabIndex = 4;
            // 
            // txbtaskid
            // 
            this.txbtaskid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtaskid.Location = new System.Drawing.Point(154, 72);
            this.txbtaskid.Name = "txbtaskid";
            this.txbtaskid.Size = new System.Drawing.Size(216, 30);
            this.txbtaskid.TabIndex = 25;
            // 
            // lableTaskId
            // 
            this.lableTaskId.AutoSize = true;
            this.lableTaskId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTaskId.Location = new System.Drawing.Point(7, 75);
            this.lableTaskId.Name = "lableTaskId";
            this.lableTaskId.Size = new System.Drawing.Size(134, 25);
            this.lableTaskId.TabIndex = 24;
            this.lableTaskId.Text = "Mã công việc:";
            // 
            // cbbState
            // 
            this.cbbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbState.FormattingEnabled = true;
            this.cbbState.Items.AddRange(new object[] {
            "Đang Làm",
            "Đã xong",
            "Trễ hạn"});
            this.cbbState.Location = new System.Drawing.Point(542, 74);
            this.cbbState.Name = "cbbState";
            this.cbbState.Size = new System.Drawing.Size(216, 33);
            this.cbbState.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Trạng thái:";
            // 
            // listBoxAdd2
            // 
            this.listBoxAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAdd2.FormattingEnabled = true;
            this.listBoxAdd2.ItemHeight = 20;
            this.listBoxAdd2.Location = new System.Drawing.Point(505, 208);
            this.listBoxAdd2.Name = "listBoxAdd2";
            this.listBoxAdd2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAdd2.Size = new System.Drawing.Size(253, 244);
            this.listBoxAdd2.TabIndex = 21;
            // 
            // btnLeft
            // 
            this.btnLeft.AutoSize = true;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(443, 288);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(46, 35);
            this.btnLeft.TabIndex = 20;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.AutoSize = true;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(443, 224);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(46, 35);
            this.btnRight.TabIndex = 19;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.AutoSize = true;
            this.btnLeftAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftAll.Location = new System.Drawing.Point(443, 407);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(46, 35);
            this.btnLeftAll.TabIndex = 18;
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.UseVisualStyleBackColor = true;
            this.btnLeftAll.Click += new System.EventHandler(this.BtnLeftAll_Click);
            // 
            // btnRightALl
            // 
            this.btnRightALl.AutoSize = true;
            this.btnRightALl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightALl.Location = new System.Drawing.Point(443, 350);
            this.btnRightALl.Name = "btnRightALl";
            this.btnRightALl.Size = new System.Drawing.Size(46, 35);
            this.btnRightALl.TabIndex = 16;
            this.btnRightALl.Text = ">>";
            this.btnRightALl.UseVisualStyleBackColor = true;
            this.btnRightALl.Click += new System.EventHandler(this.BtnRightALl_Click);
            // 
            // listBoxAdd
            // 
            this.listBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAdd.FormattingEnabled = true;
            this.listBoxAdd.ItemHeight = 20;
            this.listBoxAdd.Location = new System.Drawing.Point(177, 208);
            this.listBoxAdd.Name = "listBoxAdd";
            this.listBoxAdd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAdd.Size = new System.Drawing.Size(252, 244);
            this.listBoxAdd.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(606, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(687, 485);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Người làm chung:";
            // 
            // ngayketthucdata
            // 
            this.ngayketthucdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayketthucdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayketthucdata.Location = new System.Drawing.Point(542, 145);
            this.ngayketthucdata.Name = "ngayketthucdata";
            this.ngayketthucdata.Size = new System.Drawing.Size(216, 30);
            this.ngayketthucdata.TabIndex = 9;
            // 
            // ngaybatdaudata
            // 
            this.ngaybatdaudata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaybatdaudata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaybatdaudata.Location = new System.Drawing.Point(154, 143);
            this.ngaybatdaudata.Name = "ngaybatdaudata";
            this.ngaybatdaudata.Size = new System.Drawing.Size(216, 30);
            this.ngaybatdaudata.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày kết thúc:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày bắt đầu:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // cbbScore
            // 
            this.cbbScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbScore.FormattingEnabled = true;
            this.cbbScore.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.cbbScore.Location = new System.Drawing.Point(542, 4);
            this.cbbScore.Name = "cbbScore";
            this.cbbScore.Size = new System.Drawing.Size(216, 33);
            this.cbbScore.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phạm vi:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Add_To_Do
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_To_Do";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm công việc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNameDo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbScore;
        private System.Windows.Forms.DateTimePicker ngaybatdaudata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ngayketthucdata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxAdd;
        private System.Windows.Forms.ListBox listBoxAdd2;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeftAll;
        private System.Windows.Forms.Button btnRightALl;
        private System.Windows.Forms.ComboBox cbbState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbtaskid;
        private System.Windows.Forms.Label lableTaskId;
    }
}
namespace ToDoList.GUI
{
    partial class Comment
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchComment = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.btnResetData = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txbSearchHistory = new System.Windows.Forms.TextBox();
            this.dataGridViewCommentList = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommentList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearchComment);
            this.panel3.Controls.Add(this.btnComment);
            this.panel3.Controls.Add(this.txbComment);
            this.panel3.Controls.Add(this.btnResetData);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.txbSearchHistory);
            this.panel3.Controls.Add(this.dataGridViewCommentList);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(1, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1107, 591);
            this.panel3.TabIndex = 3;
            // 
            // btnSearchComment
            // 
            this.btnSearchComment.AutoSize = true;
            this.btnSearchComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchComment.Location = new System.Drawing.Point(634, 49);
            this.btnSearchComment.Name = "btnSearchComment";
            this.btnSearchComment.Size = new System.Drawing.Size(101, 35);
            this.btnSearchComment.TabIndex = 9;
            this.btnSearchComment.Text = "Tìm kiếm";
            this.btnSearchComment.UseVisualStyleBackColor = true;
            this.btnSearchComment.Click += new System.EventHandler(this.BtnSearchComment_Click);
            // 
            // btnComment
            // 
            this.btnComment.AutoSize = true;
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Location = new System.Drawing.Point(978, 497);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(115, 83);
            this.btnComment.TabIndex = 8;
            this.btnComment.Text = "Gửi bình luận";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.BtnComment_Click);
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(7, 497);
            this.txbComment.Multiline = true;
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(965, 83);
            this.txbComment.TabIndex = 7;
            // 
            // btnResetData
            // 
            this.btnResetData.AutoSize = true;
            this.btnResetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetData.Location = new System.Drawing.Point(741, 49);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(101, 35);
            this.btnResetData.TabIndex = 6;
            this.btnResetData.Text = "Làm mới";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.BtnResetData_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(7, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "Đóng";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // txbSearchHistory
            // 
            this.txbSearchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchHistory.Location = new System.Drawing.Point(234, 52);
            this.txbSearchHistory.Name = "txbSearchHistory";
            this.txbSearchHistory.Size = new System.Drawing.Size(394, 32);
            this.txbSearchHistory.TabIndex = 2;
            // 
            // dataGridViewCommentList
            // 
            this.dataGridViewCommentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCommentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCommentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewCommentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommentList.Location = new System.Drawing.Point(7, 107);
            this.dataGridViewCommentList.Name = "dataGridViewCommentList";
            this.dataGridViewCommentList.RowHeadersWidth = 60;
            this.dataGridViewCommentList.RowTemplate.Height = 24;
            this.dataGridViewCommentList.Size = new System.Drawing.Size(1086, 372);
            this.dataGridViewCommentList.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(410, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "DANH SÁCH BÌNH LUẬN CỦA CÔNG VIỆC";
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 600);
            this.Controls.Add(this.panel3);
            this.Name = "Comment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bình luận";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txbSearchHistory;
        private System.Windows.Forms.DataGridView dataGridViewCommentList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.TextBox txbComment;
        private System.Windows.Forms.Button btnSearchComment;
    }
}
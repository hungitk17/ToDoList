namespace ToDoList.GUI
{
    partial class History
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
            this.button5 = new System.Windows.Forms.Button();
            this.btnSearchHistory = new System.Windows.Forms.Button();
            this.txbSearchHistory = new System.Windows.Forms.TextBox();
            this.dataGridViewHistoryList = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnResetData = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnResetData);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.btnSearchHistory);
            this.panel3.Controls.Add(this.txbSearchHistory);
            this.panel3.Controls.Add(this.dataGridViewHistoryList);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 537);
            this.panel3.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnSearchHistory
            // 
            this.btnSearchHistory.AutoSize = true;
            this.btnSearchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchHistory.Location = new System.Drawing.Point(507, 63);
            this.btnSearchHistory.Name = "btnSearchHistory";
            this.btnSearchHistory.Size = new System.Drawing.Size(101, 35);
            this.btnSearchHistory.TabIndex = 3;
            this.btnSearchHistory.Text = "Tìm kiếm";
            this.btnSearchHistory.UseVisualStyleBackColor = true;
            this.btnSearchHistory.Click += new System.EventHandler(this.BtnSearchHistory_Click);
            // 
            // txbSearchHistory
            // 
            this.txbSearchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchHistory.Location = new System.Drawing.Point(107, 66);
            this.txbSearchHistory.Name = "txbSearchHistory";
            this.txbSearchHistory.Size = new System.Drawing.Size(394, 32);
            this.txbSearchHistory.TabIndex = 2;
            // 
            // dataGridViewHistoryList
            // 
            this.dataGridViewHistoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistoryList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoryList.Location = new System.Drawing.Point(7, 123);
            this.dataGridViewHistoryList.Name = "dataGridViewHistoryList";
            this.dataGridViewHistoryList.RowHeadersWidth = 60;
            this.dataGridViewHistoryList.RowTemplate.Height = 24;
            this.dataGridViewHistoryList.Size = new System.Drawing.Size(840, 411);
            this.dataGridViewHistoryList.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(261, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(322, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "DANH SÁCH LỊCH SỬ THAO TÁC";
            // 
            // btnResetData
            // 
            this.btnResetData.AutoSize = true;
            this.btnResetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetData.Location = new System.Drawing.Point(614, 63);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(101, 35);
            this.btnResetData.TabIndex = 6;
            this.btnResetData.Text = "Làm mới";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.BtnResetData_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 552);
            this.Controls.Add(this.panel3);
            this.Name = "History";
            this.Text = "History";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSearchHistory;
        private System.Windows.Forms.TextBox txbSearchHistory;
        private System.Windows.Forms.DataGridView dataGridViewHistoryList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnResetData;
    }
}
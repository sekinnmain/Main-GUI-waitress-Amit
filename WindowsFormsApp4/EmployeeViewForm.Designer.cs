namespace WindowsFormsApp4
{
    partial class EmployeeViewForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1OrdersFromSrv = new System.Windows.Forms.DataGridView();
            this.TotallDayWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerWorkedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFeedBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerRankFeedBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDayProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDayExpense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfReamianingDish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1OrdersFromSrv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Report Management";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit Management Service";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1OrdersFromSrv
            // 
            this.dataGridView1OrdersFromSrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1OrdersFromSrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotallDayWorked,
            this.WorkerWorkedTime,
            this.CustomerFeedBack,
            this.CustomerRankFeedBack,
            this.TotalDayProfit,
            this.TotalDayExpense,
            this.NumberOfReamianingDish});
            this.dataGridView1OrdersFromSrv.Location = new System.Drawing.Point(155, 2);
            this.dataGridView1OrdersFromSrv.Name = "dataGridView1OrdersFromSrv";
            this.dataGridView1OrdersFromSrv.Size = new System.Drawing.Size(644, 454);
            this.dataGridView1OrdersFromSrv.TabIndex = 2;
            // 
            // TotallDayWorked
            // 
            this.TotallDayWorked.HeaderText = "Total Day Worked";
            this.TotallDayWorked.Name = "TotallDayWorked";
            // 
            // WorkerWorkedTime
            // 
            this.WorkerWorkedTime.HeaderText = "Worker Worked Time";
            this.WorkerWorkedTime.Name = "WorkerWorkedTime";
            // 
            // CustomerFeedBack
            // 
            this.CustomerFeedBack.HeaderText = "Customer Feedback";
            this.CustomerFeedBack.Name = "CustomerFeedBack";
            // 
            // CustomerRankFeedBack
            // 
            this.CustomerRankFeedBack.HeaderText = "Customer Rank FeedBack";
            this.CustomerRankFeedBack.Name = "CustomerRankFeedBack";
            // 
            // TotalDayProfit
            // 
            this.TotalDayProfit.HeaderText = "Total Day Profit";
            this.TotalDayProfit.Name = "TotalDayProfit";
            // 
            // TotalDayExpense
            // 
            this.TotalDayExpense.HeaderText = "Total Day Expense\'s";
            this.TotalDayExpense.Name = "TotalDayExpense";
            // 
            // NumberOfReamianingDish
            // 
            this.NumberOfReamianingDish.HeaderText = "Number Of Remaining Dish\'s";
            this.NumberOfReamianingDish.Name = "NumberOfReamianingDish";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1OrdersFromSrv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Report Service";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1OrdersFromSrv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1OrdersFromSrv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotallDayWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerWorkedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFeedBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerRankFeedBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDayProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDayExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfReamianingDish;
    }
}


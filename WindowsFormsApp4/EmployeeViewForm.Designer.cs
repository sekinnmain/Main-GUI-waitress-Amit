﻿namespace WindowsFormsApp4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1OrderService2 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1OrderService2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1OrderService2
            // 
            this.dataGridView1OrderService2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1OrderService2.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1OrderService2.Name = "dataGridView1OrderService2";
            this.dataGridView1OrderService2.Size = new System.Drawing.Size(799, 411);
            this.dataGridView1OrderService2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // EmployeeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1OrderService2);
            this.Name = "EmployeeViewForm";
            this.Text = "Report Service";
            this.Load += new System.EventHandler(this.EmployeeViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1OrderService2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1OrderService2;
        private System.Windows.Forms.Timer timer1;
    }
}


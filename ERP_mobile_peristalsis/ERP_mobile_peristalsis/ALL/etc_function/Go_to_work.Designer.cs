﻿
namespace ERP_mobile_peristalsis
{
    partial class Go_to_work
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
            this.Go_to_work_gridview = new System.Windows.Forms.DataGridView();
            this.Go_to_work_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Go_to_work_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Go_to_work_gridview
            // 
            this.Go_to_work_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Go_to_work_gridview.Location = new System.Drawing.Point(80, 98);
            this.Go_to_work_gridview.Name = "Go_to_work_gridview";
            this.Go_to_work_gridview.RowTemplate.Height = 25;
            this.Go_to_work_gridview.Size = new System.Drawing.Size(750, 291);
            this.Go_to_work_gridview.TabIndex = 6;
            // 
            // Go_to_work_label
            // 
            this.Go_to_work_label.AutoSize = true;
            this.Go_to_work_label.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Go_to_work_label.Location = new System.Drawing.Point(419, 9);
            this.Go_to_work_label.Name = "Go_to_work_label";
            this.Go_to_work_label.Size = new System.Drawing.Size(134, 37);
            this.Go_to_work_label.TabIndex = 7;
            this.Go_to_work_label.Text = "출근 내역";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(658, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(755, 60);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 9;
            this.search_button.Text = "검색";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // Go_to_work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 424);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Go_to_work_label);
            this.Controls.Add(this.Go_to_work_gridview);
            this.Name = "Go_to_work";
            this.Text = "Go_to_work";
            ((System.ComponentModel.ISupportInitialize)(this.Go_to_work_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Go_to_work_gridview;
        private System.Windows.Forms.Label Go_to_work_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button search_button;
    }
}
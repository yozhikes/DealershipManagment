﻿namespace DealershipManagment
{
    partial class StaffForm
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
            searchBtn = new Button();
            label3 = new Label();
            searchTxt = new TextBox();
            groupBox1 = new GroupBox();
            clrFltrBtn = new Button();
            filterCmb = new ComboBox();
            staffDgv = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffDgv).BeginInit();
            SuspendLayout();
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ControlLightLight;
            searchBtn.Font = new Font("Times New Roman", 14.25F);
            searchBtn.Location = new Point(849, 215);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(99, 41);
            searchBtn.TabIndex = 12;
            searchBtn.Text = "Найти";
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(801, 146);
            label3.Name = "label3";
            label3.Size = new Size(92, 31);
            label3.TabIndex = 11;
            label3.Text = "Поиск:";
            // 
            // searchTxt
            // 
            searchTxt.Font = new Font("Times New Roman", 14.25F);
            searchTxt.Location = new Point(801, 180);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(200, 29);
            searchTxt.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clrFltrBtn);
            groupBox1.Controls.Add(filterCmb);
            groupBox1.Font = new Font("Times New Roman", 14.25F);
            groupBox1.Location = new Point(801, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 93);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтрация по маркам";
            // 
            // clrFltrBtn
            // 
            clrFltrBtn.BackColor = SystemColors.ControlLightLight;
            clrFltrBtn.Font = new Font("Times New Roman", 14.25F);
            clrFltrBtn.Location = new Point(61, 56);
            clrFltrBtn.Name = "clrFltrBtn";
            clrFltrBtn.Size = new Size(77, 31);
            clrFltrBtn.TabIndex = 8;
            clrFltrBtn.Text = "Сброс";
            clrFltrBtn.UseVisualStyleBackColor = false;
            // 
            // filterCmb
            // 
            filterCmb.FormattingEnabled = true;
            filterCmb.Location = new Point(6, 22);
            filterCmb.Name = "filterCmb";
            filterCmb.Size = new Size(202, 29);
            filterCmb.TabIndex = 1;
            // 
            // staffDgv
            // 
            staffDgv.AllowUserToAddRows = false;
            staffDgv.AllowUserToDeleteRows = false;
            staffDgv.BackgroundColor = SystemColors.Control;
            staffDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffDgv.Location = new Point(30, 25);
            staffDgv.Name = "staffDgv";
            staffDgv.ReadOnly = true;
            staffDgv.Size = new Size(742, 316);
            staffDgv.TabIndex = 8;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 405);
            Controls.Add(searchBtn);
            Controls.Add(label3);
            Controls.Add(searchTxt);
            Controls.Add(groupBox1);
            Controls.Add(staffDgv);
            Name = "StaffForm";
            Text = "Персонал";
            Load += StaffForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)staffDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchBtn;
        private Label label3;
        private TextBox searchTxt;
        private GroupBox groupBox1;
        private Button clrFltrBtn;
        private ComboBox filterCmb;
        private DataGridView staffDgv;
    }
}
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
            groupBox1 = new GroupBox();
            clrFltrBtn = new Button();
            filterCmb = new ComboBox();
            staffDgv = new DataGridView();
            delBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            groupBox2 = new GroupBox();
            searchTxt = new TextBox();
            searchBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffDgv).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clrFltrBtn);
            groupBox1.Controls.Add(filterCmb);
            groupBox1.Font = new Font("Times New Roman", 20.25F);
            groupBox1.Location = new Point(1030, 32);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(275, 118);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтрация по маркам";
            // 
            // clrFltrBtn
            // 
            clrFltrBtn.BackColor = SystemColors.ControlLightLight;
            clrFltrBtn.Font = new Font("Times New Roman", 14.25F);
            clrFltrBtn.Location = new Point(78, 71);
            clrFltrBtn.Margin = new Padding(4);
            clrFltrBtn.Name = "clrFltrBtn";
            clrFltrBtn.Size = new Size(99, 39);
            clrFltrBtn.TabIndex = 8;
            clrFltrBtn.Text = "Сброс";
            clrFltrBtn.UseVisualStyleBackColor = false;
            // 
            // filterCmb
            // 
            filterCmb.FormattingEnabled = true;
            filterCmb.Location = new Point(8, 28);
            filterCmb.Margin = new Padding(4);
            filterCmb.Name = "filterCmb";
            filterCmb.Size = new Size(259, 39);
            filterCmb.TabIndex = 1;
            // 
            // staffDgv
            // 
            staffDgv.AllowUserToAddRows = false;
            staffDgv.AllowUserToDeleteRows = false;
            staffDgv.BackgroundColor = SystemColors.Control;
            staffDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffDgv.Location = new Point(39, 32);
            staffDgv.Margin = new Padding(4);
            staffDgv.Name = "staffDgv";
            staffDgv.ReadOnly = true;
            staffDgv.Size = new Size(954, 400);
            staffDgv.TabIndex = 8;
            // 
            // delBtn
            // 
            delBtn.BackColor = SystemColors.ControlLightLight;
            delBtn.Font = new Font("Times New Roman", 14.25F);
            delBtn.Location = new Point(751, 457);
            delBtn.Margin = new Padding(4);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(243, 73);
            delBtn.TabIndex = 15;
            delBtn.Text = "Удалить";
            delBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            editBtn.BackColor = SystemColors.ControlLightLight;
            editBtn.Font = new Font("Times New Roman", 14.25F);
            editBtn.Location = new Point(400, 457);
            editBtn.Margin = new Padding(4);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(243, 73);
            editBtn.TabIndex = 14;
            editBtn.Text = "Изменить";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.ControlLightLight;
            addBtn.Font = new Font("Times New Roman", 14.25F);
            addBtn.Location = new Point(40, 457);
            addBtn.Margin = new Padding(4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(243, 73);
            addBtn.TabIndex = 13;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(searchTxt);
            groupBox2.Controls.Add(searchBtn);
            groupBox2.Font = new Font("Times New Roman", 20.25F);
            groupBox2.Location = new Point(1030, 223);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(275, 148);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск:";
            // 
            // searchTxt
            // 
            searchTxt.Font = new Font("Times New Roman", 14.25F);
            searchTxt.Location = new Point(10, 42);
            searchTxt.Margin = new Padding(4);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(256, 29);
            searchTxt.TabIndex = 3;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ControlLightLight;
            searchBtn.Font = new Font("Times New Roman", 14.25F);
            searchBtn.Location = new Point(62, 86);
            searchBtn.Margin = new Padding(4);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(152, 52);
            searchBtn.TabIndex = 7;
            searchBtn.Text = "Найти";
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 546);
            Controls.Add(groupBox2);
            Controls.Add(delBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(groupBox1);
            Controls.Add(staffDgv);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4);
            Name = "StaffForm";
            Text = "Персонал";
            Load += StaffForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)staffDgv).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button clrFltrBtn;
        private ComboBox filterCmb;
        private DataGridView staffDgv;
        private Button delBtn;
        private Button editBtn;
        private Button addBtn;
        private GroupBox groupBox2;
        private TextBox searchTxt;
        private Button searchBtn;
    }
}
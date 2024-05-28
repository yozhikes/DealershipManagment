namespace DealershipManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            groupBox1 = new GroupBox();
            applyFilterBtn = new Button();
            clrFltrBtn = new Button();
            filterCmb = new ComboBox();
            staffDgv = new DataGridView();
            delBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            groupBox2 = new GroupBox();
            searchTxt = new TextBox();
            searchBtn = new Button();
            closeBtn = new Button();
            groupBox3 = new GroupBox();
            statusBtn = new Button();
            statusCmb = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffDgv).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(applyFilterBtn);
            groupBox1.Controls.Add(clrFltrBtn);
            groupBox1.Controls.Add(filterCmb);
            groupBox1.Font = new Font("Times New Roman", 20.25F);
            groupBox1.Location = new Point(1015, 32);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(307, 176);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтрация по статусу";
            // 
            // applyFilterBtn
            // 
            applyFilterBtn.BackColor = SystemColors.ControlLightLight;
            applyFilterBtn.Font = new Font("Times New Roman", 14.25F);
            applyFilterBtn.Location = new Point(81, 87);
            applyFilterBtn.Margin = new Padding(4);
            applyFilterBtn.Name = "applyFilterBtn";
            applyFilterBtn.Size = new Size(152, 39);
            applyFilterBtn.TabIndex = 10;
            applyFilterBtn.Text = "Применить";
            applyFilterBtn.UseVisualStyleBackColor = false;
            applyFilterBtn.Click += applyFilterBtn_Click;
            // 
            // clrFltrBtn
            // 
            clrFltrBtn.BackColor = SystemColors.ControlLightLight;
            clrFltrBtn.Font = new Font("Times New Roman", 14.25F);
            clrFltrBtn.Location = new Point(81, 134);
            clrFltrBtn.Margin = new Padding(4);
            clrFltrBtn.Name = "clrFltrBtn";
            clrFltrBtn.Size = new Size(152, 39);
            clrFltrBtn.TabIndex = 8;
            clrFltrBtn.Text = "Сброс";
            clrFltrBtn.UseVisualStyleBackColor = false;
            clrFltrBtn.Click += clrFltrBtn_Click;
            // 
            // filterCmb
            // 
            filterCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            filterCmb.FormattingEnabled = true;
            filterCmb.Location = new Point(27, 40);
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
            staffDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDgv.Size = new Size(954, 576);
            staffDgv.TabIndex = 8;
            staffDgv.CellClick += staffDgv_CellClick;
            staffDgv.CellContentClick += staffDgv_CellContentClick;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.Transparent;
            delBtn.Font = new Font("Times New Roman", 14.25F);
            delBtn.Location = new Point(750, 638);
            delBtn.Margin = new Padding(4);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(243, 73);
            delBtn.TabIndex = 15;
            delBtn.Text = "Удалить";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.Transparent;
            editBtn.Font = new Font("Times New Roman", 14.25F);
            editBtn.Location = new Point(399, 638);
            editBtn.Margin = new Padding(4);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(243, 73);
            editBtn.TabIndex = 14;
            editBtn.Text = "Изменить";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Transparent;
            addBtn.Font = new Font("Times New Roman", 14.25F);
            addBtn.Location = new Point(39, 638);
            addBtn.Margin = new Padding(4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(243, 73);
            addBtn.TabIndex = 13;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(searchTxt);
            groupBox2.Controls.Add(searchBtn);
            groupBox2.Font = new Font("Times New Roman", 20.25F);
            groupBox2.Location = new Point(1015, 229);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(307, 148);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск:";
            // 
            // searchTxt
            // 
            searchTxt.Font = new Font("Times New Roman", 14.25F);
            searchTxt.Location = new Point(30, 40);
            searchTxt.Margin = new Padding(4);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(256, 29);
            searchTxt.TabIndex = 3;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ControlLightLight;
            searchBtn.Font = new Font("Times New Roman", 14.25F);
            searchBtn.Location = new Point(82, 84);
            searchBtn.Margin = new Padding(4);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(152, 52);
            searchBtn.TabIndex = 7;
            searchBtn.Text = "Найти";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ControlLightLight;
            closeBtn.Font = new Font("Times New Roman", 14.25F);
            closeBtn.Location = new Point(1015, 569);
            closeBtn.Margin = new Padding(4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(307, 39);
            closeBtn.TabIndex = 55;
            closeBtn.Text = "Назад";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(statusBtn);
            groupBox3.Controls.Add(statusCmb);
            groupBox3.Font = new Font("Times New Roman", 20.25F);
            groupBox3.Location = new Point(1015, 402);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(307, 144);
            groupBox3.TabIndex = 56;
            groupBox3.TabStop = false;
            groupBox3.Text = "Статус";
            // 
            // statusBtn
            // 
            statusBtn.BackColor = SystemColors.ControlLightLight;
            statusBtn.Font = new Font("Times New Roman", 14.25F);
            statusBtn.Location = new Point(82, 86);
            statusBtn.Margin = new Padding(4);
            statusBtn.Name = "statusBtn";
            statusBtn.Size = new Size(152, 52);
            statusBtn.TabIndex = 9;
            statusBtn.Text = "Применить";
            statusBtn.UseVisualStyleBackColor = false;
            statusBtn.Click += statusBtn_Click;
            // 
            // statusCmb
            // 
            statusCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCmb.FormattingEnabled = true;
            statusCmb.Location = new Point(30, 30);
            statusCmb.Margin = new Padding(4);
            statusCmb.Name = "statusCmb";
            statusCmb.Size = new Size(256, 39);
            statusCmb.TabIndex = 8;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1335, 724);
            Controls.Add(groupBox3);
            Controls.Add(closeBtn);
            Controls.Add(groupBox2);
            Controls.Add(delBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(groupBox1);
            Controls.Add(staffDgv);
            Font = new Font("Times New Roman", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "StaffForm";
            Text = "Персонал";
            Load += StaffForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)staffDgv).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
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
        private Button closeBtn;
        private GroupBox groupBox3;
        private Button statusBtn;
        private ComboBox statusCmb;
        private Button applyFilterBtn;
    }
}
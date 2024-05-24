namespace DealershipManagment
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            groupBox1 = new GroupBox();
            clrFltrBtn = new Button();
            filterCmb = new ComboBox();
            serviceDgv = new DataGridView();
            delBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            groupBox2 = new GroupBox();
            searchTxt = new TextBox();
            searchBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceDgv).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(clrFltrBtn);
            groupBox1.Controls.Add(filterCmb);
            groupBox1.Font = new Font("Times New Roman", 20.25F);
            groupBox1.Location = new Point(1040, 15);
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
            // serviceDgv
            // 
            serviceDgv.AllowUserToAddRows = false;
            serviceDgv.AllowUserToDeleteRows = false;
            serviceDgv.BackgroundColor = SystemColors.Control;
            serviceDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceDgv.Location = new Point(49, 15);
            serviceDgv.Margin = new Padding(4);
            serviceDgv.Name = "serviceDgv";
            serviceDgv.ReadOnly = true;
            serviceDgv.Size = new Size(954, 400);
            serviceDgv.TabIndex = 8;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.Transparent;
            delBtn.Font = new Font("Times New Roman", 14.25F);
            delBtn.Location = new Point(761, 433);
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
            editBtn.Location = new Point(410, 433);
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
            addBtn.Location = new Point(50, 433);
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
            groupBox2.Location = new Point(1040, 150);
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
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1328, 538);
            Controls.Add(groupBox2);
            Controls.Add(delBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(groupBox1);
            Controls.Add(serviceDgv);
            Font = new Font("Times New Roman", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ServiceForm";
            Text = "Сервис";
            Load += ServiceForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)serviceDgv).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button clrFltrBtn;
        private ComboBox filterCmb;
        private DataGridView serviceDgv;
        private Button delBtn;
        private Button editBtn;
        private Button addBtn;
        private GroupBox groupBox2;
        private TextBox searchTxt;
        private Button searchBtn;
    }
}
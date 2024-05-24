namespace DealershipManagment
{
    partial class CarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            carsDgv = new DataGridView();
            filterCmb = new ComboBox();
            groupBox1 = new GroupBox();
            applyFilterBtn = new Button();
            clrFltrBtn = new Button();
            searchTxt = new TextBox();
            searchBtn = new Button();
            addBtn = new Button();
            editBtn = new Button();
            delBtn = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)carsDgv).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // carsDgv
            // 
            carsDgv.AllowUserToAddRows = false;
            carsDgv.AllowUserToDeleteRows = false;
            carsDgv.BackgroundColor = SystemColors.Control;
            carsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carsDgv.Location = new Point(60, 15);
            carsDgv.Margin = new Padding(4);
            carsDgv.Name = "carsDgv";
            carsDgv.ReadOnly = true;
            carsDgv.Size = new Size(954, 511);
            carsDgv.TabIndex = 0;
            // 
            // filterCmb
            // 
            filterCmb.FormattingEnabled = true;
            filterCmb.Location = new Point(8, 49);
            filterCmb.Margin = new Padding(4);
            filterCmb.Name = "filterCmb";
            filterCmb.Size = new Size(289, 39);
            filterCmb.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(applyFilterBtn);
            groupBox1.Controls.Add(clrFltrBtn);
            groupBox1.Controls.Add(filterCmb);
            groupBox1.Font = new Font("Times New Roman", 20.25F);
            groupBox1.Location = new Point(1035, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(305, 196);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтрация по маркам";
            // 
            // applyFilterBtn
            // 
            applyFilterBtn.BackColor = SystemColors.ControlLightLight;
            applyFilterBtn.Font = new Font("Times New Roman", 14.25F);
            applyFilterBtn.Location = new Point(81, 96);
            applyFilterBtn.Margin = new Padding(4);
            applyFilterBtn.Name = "applyFilterBtn";
            applyFilterBtn.Size = new Size(152, 39);
            applyFilterBtn.TabIndex = 9;
            applyFilterBtn.Text = "Применить";
            applyFilterBtn.UseVisualStyleBackColor = false;
            applyFilterBtn.Click += applyFilterBtn_Click;
            // 
            // clrFltrBtn
            // 
            clrFltrBtn.BackColor = SystemColors.ControlLightLight;
            clrFltrBtn.Font = new Font("Times New Roman", 14.25F);
            clrFltrBtn.Location = new Point(81, 143);
            clrFltrBtn.Margin = new Padding(4);
            clrFltrBtn.Name = "clrFltrBtn";
            clrFltrBtn.Size = new Size(152, 39);
            clrFltrBtn.TabIndex = 8;
            clrFltrBtn.Text = "Сброс";
            clrFltrBtn.UseVisualStyleBackColor = false;
            clrFltrBtn.Click += clrFltrBtn_Click;
            // 
            // searchTxt
            // 
            searchTxt.Font = new Font("Times New Roman", 14.25F);
            searchTxt.Location = new Point(10, 42);
            searchTxt.Margin = new Padding(4);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(287, 29);
            searchTxt.TabIndex = 3;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ControlLightLight;
            searchBtn.Font = new Font("Times New Roman", 14.25F);
            searchBtn.Location = new Point(81, 88);
            searchBtn.Margin = new Padding(4);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(152, 52);
            searchBtn.TabIndex = 7;
            searchBtn.Text = "Найти";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Transparent;
            addBtn.Font = new Font("Times New Roman", 14.25F);
            addBtn.Location = new Point(60, 555);
            addBtn.Margin = new Padding(4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(243, 73);
            addBtn.TabIndex = 8;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.Transparent;
            editBtn.Font = new Font("Times New Roman", 14.25F);
            editBtn.Location = new Point(420, 555);
            editBtn.Margin = new Padding(4);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(243, 73);
            editBtn.TabIndex = 9;
            editBtn.Text = "Изменить";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.Transparent;
            delBtn.Font = new Font("Times New Roman", 14.25F);
            delBtn.Location = new Point(771, 555);
            delBtn.Margin = new Padding(4);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(243, 73);
            delBtn.TabIndex = 10;
            delBtn.Text = "Удалить";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(searchTxt);
            groupBox2.Controls.Add(searchBtn);
            groupBox2.Font = new Font("Times New Roman", 20.25F);
            groupBox2.Location = new Point(1035, 219);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(305, 148);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск:";
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1347, 641);
            Controls.Add(groupBox2);
            Controls.Add(delBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(groupBox1);
            Controls.Add(carsDgv);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "CarsForm";
            Text = "Автомобили";
            Load += CarsForm_Load;
            ((System.ComponentModel.ISupportInitialize)carsDgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView carsDgv;
        private ComboBox filterCmb;
        private GroupBox groupBox1;
        private TextBox searchTxt;
        private Button searchBtn;
        private Button clrFltrBtn;
        private Button applyFilterBtn;
        private Button addBtn;
        private Button editBtn;
        private Button delBtn;
        private GroupBox groupBox2;
    }
}
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
            closeBtn = new Button();
            groupBox3 = new GroupBox();
            statusBtn = new Button();
            statusCmb = new ComboBox();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            carsTS = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            filterTS = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)carsDgv).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            carsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carsDgv.Size = new Size(954, 586);
            carsDgv.TabIndex = 0;
            carsDgv.CellClick += carsDgv_CellClick;
            carsDgv.CellContentClick += carsDgv_CellContentClick;
            // 
            // filterCmb
            // 
            filterCmb.DropDownStyle = ComboBoxStyle.DropDownList;
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
            groupBox1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1035, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(305, 196);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтрация по статусу";
            // 
            // applyFilterBtn
            // 
            applyFilterBtn.BackColor = SystemColors.ControlLightLight;
            applyFilterBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            clrFltrBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            searchTxt.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchTxt.Location = new Point(10, 42);
            searchTxt.Margin = new Padding(4);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(287, 29);
            searchTxt.TabIndex = 3;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ControlLightLight;
            searchBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            addBtn.BackColor = SystemColors.ControlLightLight;
            addBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Location = new Point(60, 620);
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
            editBtn.BackColor = SystemColors.ControlLightLight;
            editBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            editBtn.Location = new Point(420, 620);
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
            delBtn.BackColor = SystemColors.ControlLightLight;
            delBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            delBtn.Location = new Point(771, 620);
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
            groupBox2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1035, 219);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(305, 148);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск:";
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ControlLightLight;
            closeBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            closeBtn.Location = new Point(1035, 562);
            closeBtn.Margin = new Padding(4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(305, 39);
            closeBtn.TabIndex = 54;
            closeBtn.Text = "Назад";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(statusBtn);
            groupBox3.Controls.Add(statusCmb);
            groupBox3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(1035, 375);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(305, 144);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Статус";
            // 
            // statusBtn
            // 
            statusBtn.BackColor = SystemColors.ControlLightLight;
            statusBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            statusBtn.Location = new Point(81, 84);
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
            statusCmb.Location = new Point(10, 28);
            statusCmb.Margin = new Padding(4);
            statusCmb.Name = "statusCmb";
            statusCmb.Size = new Size(289, 39);
            statusCmb.TabIndex = 8;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, carsTS, toolStripSeparator1, toolStripLabel3, filterTS });
            toolStrip1.Location = new Point(0, 711);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1347, 25);
            toolStrip1.TabIndex = 57;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(133, 22);
            toolStripLabel1.Text = "Общее кол-во машин:";
            // 
            // carsTS
            // 
            carsTS.Name = "carsTS";
            carsTS.Size = new Size(86, 22);
            carsTS.Text = "toolStripLabel2";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(186, 22);
            toolStripLabel3.Text = "Машин по выбранному статусу:";
            // 
            // filterTS
            // 
            filterTS.Name = "filterTS";
            filterTS.Size = new Size(86, 22);
            filterTS.Text = "toolStripLabel4";
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1347, 736);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox3);
            Controls.Add(closeBtn);
            Controls.Add(groupBox2);
            Controls.Add(delBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(groupBox1);
            Controls.Add(carsDgv);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "CarsForm";
            Text = "Автомобили";
            Load += CarsForm_Load;
            ((System.ComponentModel.ISupportInitialize)carsDgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button closeBtn;
        private GroupBox groupBox3;
        private Button statusBtn;
        private ComboBox statusCmb;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel carsTS;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel filterTS;
    }
}
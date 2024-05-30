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
            applyFilterBtn = new Button();
            clrFltrBtn = new Button();
            filterCmb = new ComboBox();
            serviceDgv = new DataGridView();
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
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            serviceTS = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            filterTS = new ToolStripLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceDgv).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(applyFilterBtn);
            groupBox1.Controls.Add(clrFltrBtn);
            groupBox1.Controls.Add(filterCmb);
            groupBox1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1040, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(305, 178);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтрация по статусу";
            // 
            // applyFilterBtn
            // 
            applyFilterBtn.BackColor = SystemColors.ControlLightLight;
            applyFilterBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            applyFilterBtn.Location = new Point(62, 84);
            applyFilterBtn.Margin = new Padding(4);
            applyFilterBtn.Name = "applyFilterBtn";
            applyFilterBtn.Size = new Size(182, 39);
            applyFilterBtn.TabIndex = 10;
            applyFilterBtn.Text = "Применить";
            applyFilterBtn.UseVisualStyleBackColor = false;
            applyFilterBtn.Click += applyFilterBtn_Click;
            // 
            // clrFltrBtn
            // 
            clrFltrBtn.BackColor = SystemColors.ControlLightLight;
            clrFltrBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            clrFltrBtn.Location = new Point(62, 131);
            clrFltrBtn.Margin = new Padding(4);
            clrFltrBtn.Name = "clrFltrBtn";
            clrFltrBtn.Size = new Size(182, 39);
            clrFltrBtn.TabIndex = 8;
            clrFltrBtn.Text = "Сброс";
            clrFltrBtn.UseVisualStyleBackColor = false;
            clrFltrBtn.Click += clrFltrBtn_Click;
            // 
            // filterCmb
            // 
            filterCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            filterCmb.FormattingEnabled = true;
            filterCmb.Location = new Point(8, 37);
            filterCmb.Margin = new Padding(4);
            filterCmb.Name = "filterCmb";
            filterCmb.Size = new Size(289, 39);
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
            serviceDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            serviceDgv.Size = new Size(954, 537);
            serviceDgv.TabIndex = 8;
            serviceDgv.CellClick += serviceDgv_CellClick;
            serviceDgv.CellContentClick += serviceDgv_CellContentClick;
            // 
            // delBtn
            // 
            delBtn.BackColor = SystemColors.ControlLightLight;
            delBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            delBtn.Location = new Point(760, 584);
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
            editBtn.BackColor = SystemColors.ControlLightLight;
            editBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            editBtn.Location = new Point(409, 584);
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
            addBtn.BackColor = SystemColors.ControlLightLight;
            addBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Location = new Point(49, 584);
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
            groupBox2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1040, 201);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(305, 148);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск:";
            // 
            // searchTxt
            // 
            searchTxt.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchTxt.Location = new Point(10, 42);
            searchTxt.Margin = new Padding(4);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(286, 29);
            searchTxt.TabIndex = 3;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ControlLightLight;
            searchBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.Location = new Point(62, 86);
            searchBtn.Margin = new Padding(4);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(182, 52);
            searchBtn.TabIndex = 7;
            searchBtn.Text = "Найти";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ControlLightLight;
            closeBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            closeBtn.Location = new Point(1040, 513);
            closeBtn.Margin = new Padding(4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(305, 39);
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
            groupBox3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(1040, 361);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(305, 144);
            groupBox3.TabIndex = 56;
            groupBox3.TabStop = false;
            groupBox3.Text = "Статус";
            // 
            // statusBtn
            // 
            statusBtn.BackColor = SystemColors.ControlLightLight;
            statusBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            statusBtn.Location = new Point(62, 84);
            statusBtn.Margin = new Padding(4);
            statusBtn.Name = "statusBtn";
            statusBtn.Size = new Size(182, 52);
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
            statusCmb.Size = new Size(286, 39);
            statusCmb.TabIndex = 8;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, serviceTS, toolStripSeparator1, toolStripLabel3, filterTS });
            toolStrip1.Location = new Point(0, 668);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1365, 25);
            toolStrip1.TabIndex = 57;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(189, 22);
            toolStripLabel1.Text = "Общее кол-во машин в сервисе:";
            // 
            // serviceTS
            // 
            serviceTS.Name = "serviceTS";
            serviceTS.Size = new Size(86, 22);
            serviceTS.Text = "toolStripLabel2";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(226, 22);
            toolStripLabel3.Text = "Кол-во машин по выбранному статусу:";
            // 
            // filterTS
            // 
            filterTS.Name = "filterTS";
            filterTS.Size = new Size(86, 22);
            filterTS.Text = "toolStripLabel4";
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1365, 693);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox3);
            Controls.Add(closeBtn);
            Controls.Add(groupBox2);
            Controls.Add(delBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(groupBox1);
            Controls.Add(serviceDgv);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ServiceForm";
            Text = "Сервис";
            Load += ServiceForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)serviceDgv).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button closeBtn;
        private GroupBox groupBox3;
        private Button statusBtn;
        private ComboBox statusCmb;
        private Button applyFilterBtn;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel serviceTS;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel filterTS;
    }
}
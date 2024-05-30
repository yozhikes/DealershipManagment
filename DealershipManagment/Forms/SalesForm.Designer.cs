namespace DealershipManagment
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            groupBox1 = new GroupBox();
            applyFilterBtn = new Button();
            clrFltrBtn = new Button();
            filterCmb = new ComboBox();
            salesDgv = new DataGridView();
            delBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            groupBox2 = new GroupBox();
            searchTxt = new TextBox();
            searchBtn = new Button();
            closeBtn = new Button();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            salesTS = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            filterTS = new ToolStripLabel();
            documentBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesDgv).BeginInit();
            groupBox2.SuspendLayout();
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
            groupBox1.Location = new Point(1022, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(275, 223);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтрация по менеджерам";
            // 
            // applyFilterBtn
            // 
            applyFilterBtn.BackColor = SystemColors.ControlLightLight;
            applyFilterBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            applyFilterBtn.Location = new Point(62, 126);
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
            clrFltrBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            clrFltrBtn.Location = new Point(62, 173);
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
            filterCmb.Location = new Point(9, 79);
            filterCmb.Margin = new Padding(4);
            filterCmb.Name = "filterCmb";
            filterCmb.Size = new Size(259, 39);
            filterCmb.TabIndex = 1;
            // 
            // salesDgv
            // 
            salesDgv.AllowUserToAddRows = false;
            salesDgv.AllowUserToDeleteRows = false;
            salesDgv.BackgroundColor = SystemColors.Control;
            salesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesDgv.Location = new Point(31, 15);
            salesDgv.Margin = new Padding(4);
            salesDgv.Name = "salesDgv";
            salesDgv.ReadOnly = true;
            salesDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            salesDgv.Size = new Size(954, 438);
            salesDgv.TabIndex = 8;
            // 
            // delBtn
            // 
            delBtn.BackColor = SystemColors.ControlLightLight;
            delBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            delBtn.Location = new Point(742, 474);
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
            editBtn.Location = new Point(391, 474);
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
            addBtn.Location = new Point(31, 474);
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
            groupBox2.Location = new Point(1022, 246);
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
            searchTxt.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchTxt.Location = new Point(10, 42);
            searchTxt.Margin = new Padding(4);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(256, 29);
            searchTxt.TabIndex = 3;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ControlLightLight;
            searchBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.Location = new Point(62, 86);
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
            closeBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            closeBtn.Location = new Point(1022, 414);
            closeBtn.Margin = new Padding(4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(275, 39);
            closeBtn.TabIndex = 55;
            closeBtn.Text = "Назад";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, salesTS, toolStripSeparator1, toolStripLabel3, filterTS });
            toolStrip1.Location = new Point(0, 563);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1315, 25);
            toolStrip1.TabIndex = 56;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(135, 22);
            toolStripLabel1.Text = "Общее кол-во продаж:";
            // 
            // salesTS
            // 
            salesTS.Name = "salesTS";
            salesTS.Size = new Size(86, 22);
            salesTS.Text = "toolStripLabel2";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(205, 22);
            toolStripLabel3.Text = "Продаж от выбранного менеджера:";
            // 
            // filterTS
            // 
            filterTS.Name = "filterTS";
            filterTS.Size = new Size(86, 22);
            filterTS.Text = "toolStripLabel4";
            // 
            // documentBtn
            // 
            documentBtn.BackColor = SystemColors.ControlLightLight;
            documentBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            documentBtn.Location = new Point(1022, 474);
            documentBtn.Margin = new Padding(4);
            documentBtn.Name = "documentBtn";
            documentBtn.Size = new Size(275, 73);
            documentBtn.TabIndex = 57;
            documentBtn.Text = "Сформировать договор продажи";
            documentBtn.UseVisualStyleBackColor = false;
            documentBtn.Click += documentBtn_Click;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 588);
            Controls.Add(documentBtn);
            Controls.Add(toolStrip1);
            Controls.Add(closeBtn);
            Controls.Add(groupBox2);
            Controls.Add(delBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(groupBox1);
            Controls.Add(salesDgv);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SalesForm";
            Text = "Продажи";
            Load += SalesForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)salesDgv).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button clrFltrBtn;
        private ComboBox filterCmb;
        private DataGridView salesDgv;
        private Button delBtn;
        private Button editBtn;
        private Button addBtn;
        private GroupBox groupBox2;
        private TextBox searchTxt;
        private Button searchBtn;
        private Button closeBtn;
        private Button applyFilterBtn;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel salesTS;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel filterTS;
        private Button documentBtn;
    }
}
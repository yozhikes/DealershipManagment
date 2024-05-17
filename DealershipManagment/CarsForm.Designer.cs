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
            carsDgv = new DataGridView();
            filterCmb = new ComboBox();
            groupBox1 = new GroupBox();
            clrFltrBtn = new Button();
            searchTxt = new TextBox();
            label3 = new Label();
            searchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)carsDgv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // carsDgv
            // 
            carsDgv.AllowUserToAddRows = false;
            carsDgv.AllowUserToDeleteRows = false;
            carsDgv.BackgroundColor = SystemColors.Control;
            carsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carsDgv.Location = new Point(47, 12);
            carsDgv.Name = "carsDgv";
            carsDgv.ReadOnly = true;
            carsDgv.Size = new Size(742, 316);
            carsDgv.TabIndex = 0;
            // 
            // filterCmb
            // 
            filterCmb.FormattingEnabled = true;
            filterCmb.Location = new Point(6, 22);
            filterCmb.Name = "filterCmb";
            filterCmb.Size = new Size(202, 29);
            filterCmb.TabIndex = 1;
            filterCmb.SelectedIndexChanged += filterCmb_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clrFltrBtn);
            groupBox1.Controls.Add(filterCmb);
            groupBox1.Font = new Font("Times New Roman", 14.25F);
            groupBox1.Location = new Point(818, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 93);
            groupBox1.TabIndex = 2;
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
            // searchTxt
            // 
            searchTxt.Font = new Font("Times New Roman", 14.25F);
            searchTxt.Location = new Point(818, 167);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(200, 29);
            searchTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(818, 133);
            label3.Name = "label3";
            label3.Size = new Size(92, 31);
            label3.TabIndex = 6;
            label3.Text = "Поиск:";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ControlLightLight;
            searchBtn.Font = new Font("Times New Roman", 14.25F);
            searchBtn.Location = new Point(866, 202);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(99, 41);
            searchBtn.TabIndex = 7;
            searchBtn.Text = "Найти";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 355);
            Controls.Add(searchBtn);
            Controls.Add(label3);
            Controls.Add(searchTxt);
            Controls.Add(groupBox1);
            Controls.Add(carsDgv);
            Name = "CarsForm";
            Text = "Автомобили";
            ((System.ComponentModel.ISupportInitialize)carsDgv).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView carsDgv;
        private ComboBox filterCmb;
        private GroupBox groupBox1;
        private TextBox searchTxt;
        private Label label3;
        private Button searchBtn;
        private Button clrFltrBtn;
    }
}
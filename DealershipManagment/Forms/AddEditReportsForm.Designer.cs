namespace DealershipManagment
{
    partial class AddEditReportsForm
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
            label10 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            workersCmb = new ComboBox();
            label1 = new Label();
            addEditBtn = new Button();
            monthCmb = new ComboBox();
            hoursTxt = new NumericUpDown();
            salaryTxt = new TextBox();
            prizeTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)hoursTxt).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F);
            label10.Location = new Point(107, 184);
            label10.Name = "label10";
            label10.Size = new Size(76, 21);
            label10.TabIndex = 51;
            label10.Text = "Премия:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F);
            label9.Location = new Point(95, 12);
            label9.Name = "label9";
            label9.Size = new Size(90, 21);
            label9.TabIndex = 50;
            label9.Text = "Работник:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(63, 98);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 44;
            label3.Text = "Часы работы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(98, 143);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 43;
            label2.Text = "Зарплата:";
            // 
            // workersCmb
            // 
            workersCmb.FormattingEnabled = true;
            workersCmb.Location = new Point(204, 13);
            workersCmb.Margin = new Padding(4);
            workersCmb.Name = "workersCmb";
            workersCmb.Size = new Size(289, 23);
            workersCmb.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F);
            label1.Location = new Point(117, 55);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 34;
            label1.Text = "Месяц:";
            // 
            // addEditBtn
            // 
            addEditBtn.BackColor = SystemColors.ControlLightLight;
            addEditBtn.Font = new Font("Times New Roman", 14.25F);
            addEditBtn.Location = new Point(176, 237);
            addEditBtn.Margin = new Padding(4);
            addEditBtn.Name = "addEditBtn";
            addEditBtn.Size = new Size(152, 39);
            addEditBtn.TabIndex = 33;
            addEditBtn.Text = "Применить";
            addEditBtn.UseVisualStyleBackColor = false;
            addEditBtn.Click += addEditBtn_Click;
            // 
            // monthCmb
            // 
            monthCmb.FormattingEnabled = true;
            monthCmb.Items.AddRange(new object[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            monthCmb.Location = new Point(204, 53);
            monthCmb.Margin = new Padding(4);
            monthCmb.Name = "monthCmb";
            monthCmb.Size = new Size(289, 23);
            monthCmb.TabIndex = 32;
            // 
            // hoursTxt
            // 
            hoursTxt.Font = new Font("Times New Roman", 14.25F);
            hoursTxt.Location = new Point(204, 96);
            hoursTxt.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hoursTxt.Name = "hoursTxt";
            hoursTxt.Size = new Size(291, 29);
            hoursTxt.TabIndex = 53;
            hoursTxt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // salaryTxt
            // 
            salaryTxt.Font = new Font("Times New Roman", 14.25F);
            salaryTxt.Location = new Point(202, 143);
            salaryTxt.Margin = new Padding(4);
            salaryTxt.Name = "salaryTxt";
            salaryTxt.Size = new Size(293, 29);
            salaryTxt.TabIndex = 54;
            // 
            // prizeTxt
            // 
            prizeTxt.Font = new Font("Times New Roman", 14.25F);
            prizeTxt.Location = new Point(202, 184);
            prizeTxt.Margin = new Padding(4);
            prizeTxt.Name = "prizeTxt";
            prizeTxt.Size = new Size(293, 29);
            prizeTxt.TabIndex = 55;
            // 
            // AddEditReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 314);
            Controls.Add(prizeTxt);
            Controls.Add(salaryTxt);
            Controls.Add(hoursTxt);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(workersCmb);
            Controls.Add(label1);
            Controls.Add(addEditBtn);
            Controls.Add(monthCmb);
            Name = "AddEditReportsForm";
            Text = "AddEditReportsForm";
            Load += AddEditReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)hoursTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown yearTxt;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox notesTxt;
        private TextBox priceTxt;
        private TextBox vinTxt;
        private ComboBox driveCmb;
        private ComboBox transmissionCmb;
        private ComboBox engineCmb;
        private ComboBox workersCmb;
        private Label label1;
        private Button addEditBtn;
        private ComboBox monthCmb;
        private NumericUpDown hoursTxt;
        private TextBox salaryTxt;
        private TextBox prizeTxt;
    }
}
namespace DealershipManagment
{
    partial class AddEditSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditSalesForm));
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            notesTxt = new TextBox();
            priceTxt = new TextBox();
            workerCmb = new ComboBox();
            clientCmb = new ComboBox();
            label1 = new Label();
            addEditBtn = new Button();
            carsCmb = new ComboBox();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label8.Location = new Point(59, 114);
            label8.Name = "label8";
            label8.Size = new Size(80, 22);
            label8.TabIndex = 49;
            label8.Text = "Клиент:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label5.Location = new Point(78, 70);
            label5.Name = "label5";
            label5.Size = new Size(59, 22);
            label5.TabIndex = 46;
            label5.Text = "Цена:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label4.Location = new Point(553, 70);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 45;
            label4.Text = "Заметки:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label2.Location = new Point(542, 26);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 43;
            label2.Text = "Работник:";
            // 
            // notesTxt
            // 
            notesTxt.Font = new Font("Times New Roman", 14.25F);
            notesTxt.Location = new Point(648, 63);
            notesTxt.Margin = new Padding(4);
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(291, 29);
            notesTxt.TabIndex = 41;
            // 
            // priceTxt
            // 
            priceTxt.Font = new Font("Times New Roman", 14.25F);
            priceTxt.Location = new Point(144, 68);
            priceTxt.Margin = new Padding(4);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(291, 29);
            priceTxt.TabIndex = 40;
            // 
            // workerCmb
            // 
            workerCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            workerCmb.FormattingEnabled = true;
            workerCmb.Location = new Point(648, 25);
            workerCmb.Margin = new Padding(4);
            workerCmb.Name = "workerCmb";
            workerCmb.Size = new Size(289, 23);
            workerCmb.TabIndex = 38;
            // 
            // clientCmb
            // 
            clientCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            clientCmb.FormattingEnabled = true;
            clientCmb.Location = new Point(146, 114);
            clientCmb.Margin = new Padding(4);
            clientCmb.Name = "clientCmb";
            clientCmb.Size = new Size(289, 23);
            clientCmb.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.Location = new Point(47, 26);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 34;
            label1.Text = "Машина:";
            // 
            // addEditBtn
            // 
            addEditBtn.BackColor = SystemColors.ControlLightLight;
            addEditBtn.Font = new Font("Times New Roman", 14.25F);
            addEditBtn.Location = new Point(405, 283);
            addEditBtn.Margin = new Padding(4);
            addEditBtn.Name = "addEditBtn";
            addEditBtn.Size = new Size(152, 39);
            addEditBtn.TabIndex = 33;
            addEditBtn.Text = "Применить";
            addEditBtn.UseVisualStyleBackColor = false;
            addEditBtn.Click += addEditBtn_Click;
            // 
            // carsCmb
            // 
            carsCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            carsCmb.FormattingEnabled = true;
            carsCmb.Location = new Point(144, 25);
            carsCmb.Margin = new Padding(4);
            carsCmb.Name = "carsCmb";
            carsCmb.Size = new Size(289, 23);
            carsCmb.TabIndex = 32;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ControlLightLight;
            closeBtn.Font = new Font("Times New Roman", 14.25F);
            closeBtn.Location = new Point(405, 330);
            closeBtn.Margin = new Padding(4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(152, 39);
            closeBtn.TabIndex = 54;
            closeBtn.Text = "Отмена";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // AddEditSalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 439);
            Controls.Add(closeBtn);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(notesTxt);
            Controls.Add(priceTxt);
            Controls.Add(workerCmb);
            Controls.Add(clientCmb);
            Controls.Add(label1);
            Controls.Add(addEditBtn);
            Controls.Add(carsCmb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEditSalesForm";
            Text = "AddEditSalesForm";
            Load += AddEditSalesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox notesTxt;
        private TextBox priceTxt;
        private ComboBox workerCmb;
        private ComboBox clientCmb;
        private Label label1;
        private Button addEditBtn;
        private ComboBox carsCmb;
        private Button closeBtn;
    }
}
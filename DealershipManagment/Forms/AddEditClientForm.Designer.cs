namespace DealershipManagment.Forms
{
    partial class AddEditClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditClientForm));
            closeBtn = new Button();
            addEditBtn = new Button();
            label3 = new Label();
            fioTxt = new TextBox();
            label1 = new Label();
            passTxt = new TextBox();
            label2 = new Label();
            telnumTxt = new MaskedTextBox();
            SuspendLayout();
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ControlLightLight;
            closeBtn.Font = new Font("Times New Roman", 14.25F);
            closeBtn.Location = new Point(168, 197);
            closeBtn.Margin = new Padding(4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(152, 39);
            closeBtn.TabIndex = 60;
            closeBtn.Text = "Отмена";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // addEditBtn
            // 
            addEditBtn.BackColor = SystemColors.ControlLightLight;
            addEditBtn.Font = new Font("Times New Roman", 14.25F);
            addEditBtn.Location = new Point(168, 150);
            addEditBtn.Margin = new Padding(4);
            addEditBtn.Name = "addEditBtn";
            addEditBtn.Size = new Size(152, 39);
            addEditBtn.TabIndex = 59;
            addEditBtn.Text = "Применить";
            addEditBtn.UseVisualStyleBackColor = false;
            addEditBtn.Click += addEditBtn_Click;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label3.Location = new Point(111, 21);
            label3.Name = "label3";
            label3.Size = new Size(61, 22);
            label3.TabIndex = 58;
            label3.Text = "ФИО:";
            // 
            // fioTxt
            // 
            fioTxt.Font = new Font("Times New Roman", 14.25F);
            fioTxt.Location = new Point(179, 19);
            fioTxt.Margin = new Padding(4);
            fioTxt.Name = "fioTxt";
            fioTxt.Size = new Size(287, 29);
            fioTxt.TabIndex = 57;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.Location = new Point(15, 95);
            label1.Name = "label1";
            label1.Size = new Size(158, 22);
            label1.TabIndex = 62;
            label1.Text = "Номер телефона:";
            // 
            // passTxt
            // 
            passTxt.Font = new Font("Times New Roman", 14.25F);
            passTxt.Location = new Point(179, 56);
            passTxt.Margin = new Padding(4);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(287, 29);
            passTxt.TabIndex = 61;
            passTxt.KeyPress += passTxt_KeyPress;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label2.Location = new Point(84, 58);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 64;
            label2.Text = "Паспорт:";
            // 
            // telnumTxt
            // 
            telnumTxt.Location = new Point(179, 97);
            telnumTxt.Mask = "+7 (999) 000-0000";
            telnumTxt.Name = "telnumTxt";
            telnumTxt.Size = new Size(287, 23);
            telnumTxt.TabIndex = 65;
            // 
            // AddEditClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(495, 272);
            Controls.Add(telnumTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passTxt);
            Controls.Add(closeBtn);
            Controls.Add(addEditBtn);
            Controls.Add(label3);
            Controls.Add(fioTxt);
            Name = "AddEditClientForm";
            Text = "AddEditClientForm";
            Load += AddEditClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeBtn;
        private Button addEditBtn;
        private Label label3;
        private TextBox fioTxt;
        private Label label1;
        private TextBox passTxt;
        private Label label2;
        private MaskedTextBox telnumTxt;
    }
}
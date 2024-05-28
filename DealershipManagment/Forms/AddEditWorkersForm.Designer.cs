namespace DealershipManagment
{
    partial class AddEditWorkersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditWorkersForm));
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            passTxt = new TextBox();
            passwordTxt = new TextBox();
            loginTxt = new TextBox();
            roleCmb = new ComboBox();
            label1 = new Label();
            addEditBtn = new Button();
            fioTxt = new TextBox();
            closeBtn = new Button();
            telnumTxt = new MaskedTextBox();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(498, 24);
            label10.Name = "label10";
            label10.Size = new Size(58, 22);
            label10.TabIndex = 51;
            label10.Text = "Роль:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(486, 69);
            label8.Name = "label8";
            label8.Size = new Size(70, 22);
            label8.TabIndex = 49;
            label8.Text = "Логин:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(478, 115);
            label7.Name = "label7";
            label7.Size = new Size(80, 22);
            label7.TabIndex = 48;
            label7.Text = "Пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label3.Location = new Point(71, 67);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 44;
            label3.Text = "Паспорт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label2.Location = new Point(1, 115);
            label2.Name = "label2";
            label2.Size = new Size(158, 22);
            label2.TabIndex = 43;
            label2.Text = "Номер телефона:";
            // 
            // passTxt
            // 
            passTxt.Font = new Font("Times New Roman", 14.25F);
            passTxt.Location = new Point(168, 67);
            passTxt.Margin = new Padding(4);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(291, 29);
            passTxt.TabIndex = 42;
            passTxt.KeyPress += passTxt_KeyPress;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Times New Roman", 14.25F);
            passwordTxt.Location = new Point(576, 112);
            passwordTxt.Margin = new Padding(4);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(291, 29);
            passwordTxt.TabIndex = 40;
            // 
            // loginTxt
            // 
            loginTxt.Font = new Font("Times New Roman", 14.25F);
            loginTxt.Location = new Point(576, 65);
            loginTxt.Margin = new Padding(4);
            loginTxt.Name = "loginTxt";
            loginTxt.Size = new Size(291, 29);
            loginTxt.TabIndex = 39;
            // 
            // roleCmb
            // 
            roleCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            roleCmb.FormattingEnabled = true;
            roleCmb.Location = new Point(576, 24);
            roleCmb.Margin = new Padding(4);
            roleCmb.Name = "roleCmb";
            roleCmb.Size = new Size(289, 23);
            roleCmb.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.Location = new Point(97, 25);
            label1.Name = "label1";
            label1.Size = new Size(61, 22);
            label1.TabIndex = 34;
            label1.Text = "ФИО:";
            // 
            // addEditBtn
            // 
            addEditBtn.BackColor = SystemColors.ControlLightLight;
            addEditBtn.Font = new Font("Times New Roman", 14.25F);
            addEditBtn.Location = new Point(378, 242);
            addEditBtn.Margin = new Padding(4);
            addEditBtn.Name = "addEditBtn";
            addEditBtn.Size = new Size(152, 39);
            addEditBtn.TabIndex = 33;
            addEditBtn.Text = "Применить";
            addEditBtn.UseVisualStyleBackColor = false;
            addEditBtn.Click += addEditBtn_Click;
            // 
            // fioTxt
            // 
            fioTxt.Font = new Font("Times New Roman", 14.25F);
            fioTxt.Location = new Point(168, 22);
            fioTxt.Margin = new Padding(4);
            fioTxt.Name = "fioTxt";
            fioTxt.Size = new Size(291, 29);
            fioTxt.TabIndex = 52;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ControlLightLight;
            closeBtn.Font = new Font("Times New Roman", 14.25F);
            closeBtn.Location = new Point(378, 289);
            closeBtn.Margin = new Padding(4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(152, 39);
            closeBtn.TabIndex = 53;
            closeBtn.Text = "Отмена";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // telnumTxt
            // 
            telnumTxt.Location = new Point(168, 115);
            telnumTxt.Mask = "+7 (999) 000-0000";
            telnumTxt.Name = "telnumTxt";
            telnumTxt.Size = new Size(291, 23);
            telnumTxt.TabIndex = 54;
            // 
            // AddEditWorkersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(908, 350);
            Controls.Add(telnumTxt);
            Controls.Add(closeBtn);
            Controls.Add(fioTxt);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passTxt);
            Controls.Add(passwordTxt);
            Controls.Add(loginTxt);
            Controls.Add(roleCmb);
            Controls.Add(label1);
            Controls.Add(addEditBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEditWorkersForm";
            Text = "AddEditWorkersForm";
            Load += AddEditWorkersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label2;
        private TextBox passTxt;
        private TextBox passwordTxt;
        private TextBox loginTxt;
        private ComboBox roleCmb;
        private Label label1;
        private Button addEditBtn;
        private TextBox fioTxt;
        private Button closeBtn;
        private MaskedTextBox telnumTxt;
    }
}
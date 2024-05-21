namespace DealershipManagment
{
    partial class AutorisationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorisationForm));
            entryBtn = new Button();
            label1 = new Label();
            loginTxt = new TextBox();
            label2 = new Label();
            passTxt = new TextBox();
            label3 = new Label();
            passCheck = new CheckBox();
            SuspendLayout();
            // 
            // entryBtn
            // 
            entryBtn.BackColor = SystemColors.ControlLightLight;
            entryBtn.Font = new Font("Times New Roman", 14.25F);
            entryBtn.Location = new Point(213, 217);
            entryBtn.Name = "entryBtn";
            entryBtn.Size = new Size(99, 41);
            entryBtn.TabIndex = 0;
            entryBtn.Text = "Войти";
            entryBtn.UseVisualStyleBackColor = false;
            entryBtn.Click += entryBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 78);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 1;
            label1.Text = "Логин:";
            // 
            // loginTxt
            // 
            loginTxt.Font = new Font("Times New Roman", 14.25F);
            loginTxt.Location = new Point(179, 75);
            loginTxt.Name = "loginTxt";
            loginTxt.Size = new Size(298, 29);
            loginTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 149);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 3;
            label2.Text = "Пароль:";
            // 
            // passTxt
            // 
            passTxt.Font = new Font("Times New Roman", 14.25F);
            passTxt.Location = new Point(179, 141);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(298, 29);
            passTxt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(352, 9);
            label3.Name = "label3";
            label3.Size = new Size(71, 31);
            label3.TabIndex = 5;
            label3.Text = "Вход";
            // 
            // passCheck
            // 
            passCheck.AutoSize = true;
            passCheck.Location = new Point(358, 192);
            passCheck.Name = "passCheck";
            passCheck.Size = new Size(119, 19);
            passCheck.TabIndex = 6;
            passCheck.Text = "Показать пароль";
            passCheck.UseVisualStyleBackColor = true;
            passCheck.CheckedChanged += passCheck_CheckedChanged;
            // 
            // AutorisationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(549, 324);
            Controls.Add(passCheck);
            Controls.Add(label3);
            Controls.Add(passTxt);
            Controls.Add(label2);
            Controls.Add(loginTxt);
            Controls.Add(label1);
            Controls.Add(entryBtn);
            DoubleBuffered = true;
            Name = "AutorisationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button entryBtn;
        private Label label1;
        private TextBox loginTxt;
        private Label label2;
        private TextBox passTxt;
        private Label label3;
        private CheckBox passCheck;
    }
}

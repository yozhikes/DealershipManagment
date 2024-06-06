namespace DealershipManagment.Forms
{
    partial class MainAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminForm));
            rezervBtn = new Button();
            marksBtn = new Button();
            backBtn = new Button();
            SuspendLayout();
            // 
            // rezervBtn
            // 
            rezervBtn.BackColor = SystemColors.ControlLightLight;
            rezervBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rezervBtn.Location = new Point(59, 35);
            rezervBtn.Margin = new Padding(4);
            rezervBtn.Name = "rezervBtn";
            rezervBtn.Size = new Size(180, 88);
            rezervBtn.TabIndex = 18;
            rezervBtn.Text = "Сделать резервное копирование БД";
            rezervBtn.UseVisualStyleBackColor = false;
            rezervBtn.Click += rezervBtn_Click;
            // 
            // marksBtn
            // 
            marksBtn.BackColor = SystemColors.ControlLightLight;
            marksBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            marksBtn.Location = new Point(279, 35);
            marksBtn.Margin = new Padding(4);
            marksBtn.Name = "marksBtn";
            marksBtn.Size = new Size(180, 88);
            marksBtn.TabIndex = 19;
            marksBtn.Text = "Марки машин:";
            marksBtn.UseVisualStyleBackColor = false;
            marksBtn.Click += marksBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.ControlLightLight;
            backBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            backBtn.Location = new Point(190, 134);
            backBtn.Margin = new Padding(4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(128, 52);
            backBtn.TabIndex = 20;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // MainAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(513, 199);
            Controls.Add(backBtn);
            Controls.Add(marksBtn);
            Controls.Add(rezervBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainAdminForm";
            Text = "Меню администратора";
            ResumeLayout(false);
        }

        #endregion

        private Button rezervBtn;
        private Button marksBtn;
        private Button backBtn;
    }
}
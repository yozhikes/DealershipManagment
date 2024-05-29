namespace DealershipManagment.Forms
{
    partial class MainManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainManagerForm));
            salesBtn = new Button();
            clientsBtn = new Button();
            backBtn = new Button();
            SuspendLayout();
            // 
            // salesBtn
            // 
            salesBtn.BackColor = SystemColors.ControlLightLight;
            salesBtn.Font = new Font("Times New Roman", 14.25F);
            salesBtn.Location = new Point(322, 39);
            salesBtn.Margin = new Padding(4);
            salesBtn.Name = "salesBtn";
            salesBtn.Size = new Size(198, 76);
            salesBtn.TabIndex = 38;
            salesBtn.Text = "Продажи";
            salesBtn.UseVisualStyleBackColor = false;
            salesBtn.Click += salesBtn_Click;
            // 
            // clientsBtn
            // 
            clientsBtn.BackColor = SystemColors.ControlLightLight;
            clientsBtn.Font = new Font("Times New Roman", 14.25F);
            clientsBtn.Location = new Point(73, 39);
            clientsBtn.Margin = new Padding(4);
            clientsBtn.Name = "clientsBtn";
            clientsBtn.Size = new Size(198, 76);
            clientsBtn.TabIndex = 37;
            clientsBtn.Text = "Клиенты";
            clientsBtn.UseVisualStyleBackColor = false;
            clientsBtn.Click += clientsBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.ControlLightLight;
            backBtn.Font = new Font("Times New Roman", 14.25F);
            backBtn.Location = new Point(187, 133);
            backBtn.Margin = new Padding(4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(198, 76);
            backBtn.TabIndex = 39;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // MainManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(571, 222);
            Controls.Add(backBtn);
            Controls.Add(salesBtn);
            Controls.Add(clientsBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainManagerForm";
            Text = "Меню менеджера";
            ResumeLayout(false);
        }

        #endregion

        private Button salesBtn;
        private Button clientsBtn;
        private Button backBtn;
    }
}
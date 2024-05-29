namespace DealershipManagment.Forms
{
    partial class AddEditMarkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditMarkForm));
            label3 = new Label();
            markTxt = new TextBox();
            closeBtn = new Button();
            addEditBtn = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label3.Location = new Point(25, 24);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 25;
            label3.Text = "Марка:";
            // 
            // markTxt
            // 
            markTxt.Font = new Font("Times New Roman", 14.25F);
            markTxt.Location = new Point(122, 24);
            markTxt.Margin = new Padding(4);
            markTxt.Name = "markTxt";
            markTxt.Size = new Size(287, 29);
            markTxt.TabIndex = 24;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ControlLightLight;
            closeBtn.Font = new Font("Times New Roman", 14.25F);
            closeBtn.Location = new Point(142, 124);
            closeBtn.Margin = new Padding(4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(152, 39);
            closeBtn.TabIndex = 56;
            closeBtn.Text = "Отмена";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // addEditBtn
            // 
            addEditBtn.BackColor = SystemColors.ControlLightLight;
            addEditBtn.Font = new Font("Times New Roman", 14.25F);
            addEditBtn.Location = new Point(142, 77);
            addEditBtn.Margin = new Padding(4);
            addEditBtn.Name = "addEditBtn";
            addEditBtn.Size = new Size(152, 39);
            addEditBtn.TabIndex = 55;
            addEditBtn.Text = "Применить";
            addEditBtn.UseVisualStyleBackColor = false;
            addEditBtn.Click += addEditBtn_Click;
            // 
            // AddEditMarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(428, 187);
            Controls.Add(closeBtn);
            Controls.Add(addEditBtn);
            Controls.Add(label3);
            Controls.Add(markTxt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEditMarkForm";
            Text = "AddEditMarkForm";
            Load += AddEditMarkForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox markTxt;
        private Button closeBtn;
        private Button addEditBtn;
    }
}
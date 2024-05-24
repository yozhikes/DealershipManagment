namespace DealershipManagment
{
    partial class AddEditRequestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditRequestsForm));
            label3 = new Label();
            label2 = new Label();
            notesTxt = new TextBox();
            statusCmb = new ComboBox();
            label1 = new Label();
            addEditBtn = new Button();
            carsCmb = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(70, 69);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 44;
            label3.Text = "Статус заявки:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(83, 114);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 43;
            label2.Text = "Примечания:";
            // 
            // notesTxt
            // 
            notesTxt.Font = new Font("Times New Roman", 14.25F);
            notesTxt.Location = new Point(206, 111);
            notesTxt.Margin = new Padding(4);
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(287, 29);
            notesTxt.TabIndex = 42;
            // 
            // statusCmb
            // 
            statusCmb.FormattingEnabled = true;
            statusCmb.Location = new Point(204, 69);
            statusCmb.Margin = new Padding(4);
            statusCmb.Name = "statusCmb";
            statusCmb.Size = new Size(289, 23);
            statusCmb.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14.25F);
            label1.Location = new Point(117, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 34;
            label1.Text = "Машина:";
            // 
            // addEditBtn
            // 
            addEditBtn.BackColor = SystemColors.ControlLightLight;
            addEditBtn.Font = new Font("Times New Roman", 14.25F);
            addEditBtn.Location = new Point(181, 308);
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
            carsCmb.FormattingEnabled = true;
            carsCmb.Location = new Point(204, 27);
            carsCmb.Margin = new Padding(4);
            carsCmb.Name = "carsCmb";
            carsCmb.Size = new Size(289, 23);
            carsCmb.TabIndex = 32;
            // 
            // AddEditRequestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(524, 395);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(notesTxt);
            Controls.Add(statusCmb);
            Controls.Add(label1);
            Controls.Add(addEditBtn);
            Controls.Add(carsCmb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEditRequestsForm";
            Text = "AddEditRequestsForm";
            Load += AddEditRequestsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private TextBox notesTxt;
        private ComboBox statusCmb;
        private Label label1;
        private Button addEditBtn;
        private ComboBox carsCmb;
    }
}
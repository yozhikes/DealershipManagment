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
            label2 = new Label();
            notesTxt = new TextBox();
            label1 = new Label();
            addEditBtn = new Button();
            carsCmb = new ComboBox();
            closeBtn = new Button();
            label4 = new Label();
            priceTxt = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label2.Location = new Point(196, 82);
            label2.Name = "label2";
            label2.Size = new Size(125, 22);
            label2.TabIndex = 43;
            label2.Text = "Примечания:";
            // 
            // notesTxt
            // 
            notesTxt.Font = new Font("Times New Roman", 14.25F);
            notesTxt.Location = new Point(328, 80);
            notesTxt.Margin = new Padding(4);
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(287, 29);
            notesTxt.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 34;
            label1.Text = "Машина:";
            // 
            // addEditBtn
            // 
            addEditBtn.BackColor = SystemColors.ControlLightLight;
            addEditBtn.Font = new Font("Times New Roman", 14.25F);
            addEditBtn.Location = new Point(370, 221);
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
            carsCmb.Location = new Point(114, 29);
            carsCmb.Margin = new Padding(4);
            carsCmb.Name = "carsCmb";
            carsCmb.Size = new Size(289, 23);
            carsCmb.TabIndex = 32;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ControlLightLight;
            closeBtn.Font = new Font("Times New Roman", 14.25F);
            closeBtn.Location = new Point(370, 268);
            closeBtn.Margin = new Padding(4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(152, 39);
            closeBtn.TabIndex = 54;
            closeBtn.Text = "Отмена";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label4.Location = new Point(506, 30);
            label4.Name = "label4";
            label4.Size = new Size(59, 22);
            label4.TabIndex = 56;
            label4.Text = "Цена:";
            // 
            // priceTxt
            // 
            priceTxt.Font = new Font("Times New Roman", 14.25F);
            priceTxt.Location = new Point(572, 27);
            priceTxt.Margin = new Padding(4);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(287, 29);
            priceTxt.TabIndex = 55;
            // 
            // AddEditRequestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 348);
            Controls.Add(label4);
            Controls.Add(priceTxt);
            Controls.Add(closeBtn);
            Controls.Add(label2);
            Controls.Add(notesTxt);
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
        private Label label2;
        private TextBox notesTxt;
        private Label label1;
        private Button addEditBtn;
        private ComboBox carsCmb;
        private Button closeBtn;
        private Label label4;
        private TextBox priceTxt;
    }
}
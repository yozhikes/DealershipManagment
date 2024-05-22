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
            yearTxt = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            modelTxt = new TextBox();
            notesTxt = new TextBox();
            priceTxt = new TextBox();
            vinTxt = new TextBox();
            driveCmb = new ComboBox();
            transmissionCmb = new ComboBox();
            engineCmb = new ComboBox();
            bodyCmb = new ComboBox();
            label1 = new Label();
            addEditBtn = new Button();
            marksCmb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)yearTxt).BeginInit();
            SuspendLayout();
            // 
            // yearTxt
            // 
            yearTxt.Font = new Font("Times New Roman", 14.25F);
            yearTxt.Location = new Point(202, 302);
            yearTxt.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            yearTxt.Name = "yearTxt";
            yearTxt.Size = new Size(291, 29);
            yearTxt.TabIndex = 52;
            yearTxt.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F);
            label10.Location = new Point(31, 159);
            label10.Name = "label10";
            label10.Size = new Size(151, 21);
            label10.TabIndex = 51;
            label10.Text = "Коробка передач:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F);
            label9.Location = new Point(78, 203);
            label9.Name = "label9";
            label9.Size = new Size(104, 21);
            label9.TabIndex = 50;
            label9.Text = "Тип кузова:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F);
            label8.Location = new Point(67, 250);
            label8.Name = "label8";
            label8.Size = new Size(115, 21);
            label8.TabIndex = 49;
            label8.Text = "Тип топлива:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F);
            label7.Location = new Point(67, 302);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 48;
            label7.Text = "Год выпуска:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F);
            label6.Location = new Point(133, 350);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 47;
            label6.Text = "VIN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F);
            label5.Location = new Point(126, 400);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 46;
            label5.Text = "Цена:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F);
            label4.Location = new Point(100, 440);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 45;
            label4.Text = "Заметки:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(107, 69);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 44;
            label3.Text = "Модель:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(107, 117);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 43;
            label2.Text = "Привод:";
            // 
            // modelTxt
            // 
            modelTxt.Font = new Font("Times New Roman", 14.25F);
            modelTxt.Location = new Point(204, 69);
            modelTxt.Margin = new Padding(4);
            modelTxt.Name = "modelTxt";
            modelTxt.Size = new Size(287, 29);
            modelTxt.TabIndex = 42;
            // 
            // notesTxt
            // 
            notesTxt.Font = new Font("Times New Roman", 14.25F);
            notesTxt.Location = new Point(202, 440);
            notesTxt.Margin = new Padding(4);
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(291, 29);
            notesTxt.TabIndex = 41;
            // 
            // priceTxt
            // 
            priceTxt.Font = new Font("Times New Roman", 14.25F);
            priceTxt.Location = new Point(202, 397);
            priceTxt.Margin = new Padding(4);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(291, 29);
            priceTxt.TabIndex = 40;
            // 
            // vinTxt
            // 
            vinTxt.Font = new Font("Times New Roman", 14.25F);
            vinTxt.Location = new Point(202, 350);
            vinTxt.Margin = new Padding(4);
            vinTxt.Name = "vinTxt";
            vinTxt.Size = new Size(291, 29);
            vinTxt.TabIndex = 39;
            // 
            // driveCmb
            // 
            driveCmb.FormattingEnabled = true;
            driveCmb.Location = new Point(204, 115);
            driveCmb.Margin = new Padding(4);
            driveCmb.Name = "driveCmb";
            driveCmb.Size = new Size(289, 23);
            driveCmb.TabIndex = 38;
            // 
            // transmissionCmb
            // 
            transmissionCmb.FormattingEnabled = true;
            transmissionCmb.Location = new Point(204, 159);
            transmissionCmb.Margin = new Padding(4);
            transmissionCmb.Name = "transmissionCmb";
            transmissionCmb.Size = new Size(289, 23);
            transmissionCmb.TabIndex = 37;
            // 
            // engineCmb
            // 
            engineCmb.FormattingEnabled = true;
            engineCmb.Location = new Point(204, 251);
            engineCmb.Margin = new Padding(4);
            engineCmb.Name = "engineCmb";
            engineCmb.Size = new Size(289, 23);
            engineCmb.TabIndex = 36;
            // 
            // bodyCmb
            // 
            bodyCmb.FormattingEnabled = true;
            bodyCmb.Location = new Point(202, 204);
            bodyCmb.Margin = new Padding(4);
            bodyCmb.Name = "bodyCmb";
            bodyCmb.Size = new Size(289, 23);
            bodyCmb.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F);
            label1.Location = new Point(117, 29);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 34;
            label1.Text = "Марка:";
            // 
            // addEditBtn
            // 
            addEditBtn.BackColor = SystemColors.ControlLightLight;
            addEditBtn.Font = new Font("Times New Roman", 14.25F);
            addEditBtn.Location = new Point(186, 496);
            addEditBtn.Margin = new Padding(4);
            addEditBtn.Name = "addEditBtn";
            addEditBtn.Size = new Size(152, 39);
            addEditBtn.TabIndex = 33;
            addEditBtn.Text = "Применить";
            addEditBtn.UseVisualStyleBackColor = false;
            // 
            // marksCmb
            // 
            marksCmb.FormattingEnabled = true;
            marksCmb.Location = new Point(204, 27);
            marksCmb.Margin = new Padding(4);
            marksCmb.Name = "marksCmb";
            marksCmb.Size = new Size(289, 23);
            marksCmb.TabIndex = 32;
            // 
            // AddEditWorkersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 562);
            Controls.Add(yearTxt);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(modelTxt);
            Controls.Add(notesTxt);
            Controls.Add(priceTxt);
            Controls.Add(vinTxt);
            Controls.Add(driveCmb);
            Controls.Add(transmissionCmb);
            Controls.Add(engineCmb);
            Controls.Add(bodyCmb);
            Controls.Add(label1);
            Controls.Add(addEditBtn);
            Controls.Add(marksCmb);
            Name = "AddEditWorkersForm";
            Text = "AddEditWorkersForm";
            ((System.ComponentModel.ISupportInitialize)yearTxt).EndInit();
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
        private TextBox modelTxt;
        private TextBox notesTxt;
        private TextBox priceTxt;
        private TextBox vinTxt;
        private ComboBox driveCmb;
        private ComboBox transmissionCmb;
        private ComboBox engineCmb;
        private ComboBox bodyCmb;
        private Label label1;
        private Button addEditBtn;
        private ComboBox marksCmb;
    }
}
namespace Last.Forms
{
    partial class AddForm
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            oborCmb = new ComboBox();
            label4 = new Label();
            typeCmb = new ComboBox();
            dexcriptionTxt = new TextBox();
            SaveBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 83);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 2;
            label2.Text = "Оборудование";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 138);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 3;
            label1.Text = "Тип неисправности";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 196);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 4;
            label3.Text = "Описание";
            // 
            // oborCmb
            // 
            oborCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            oborCmb.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            oborCmb.FormattingEnabled = true;
            oborCmb.Location = new Point(254, 80);
            oborCmb.Name = "oborCmb";
            oborCmb.Size = new Size(268, 36);
            oborCmb.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(175, 9);
            label4.Name = "label4";
            label4.Size = new Size(173, 33);
            label4.TabIndex = 6;
            label4.Text = "Создание заявки";
            // 
            // typeCmb
            // 
            typeCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            typeCmb.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            typeCmb.FormattingEnabled = true;
            typeCmb.Location = new Point(254, 135);
            typeCmb.Name = "typeCmb";
            typeCmb.Size = new Size(268, 36);
            typeCmb.TabIndex = 7;
            // 
            // dexcriptionTxt
            // 
            dexcriptionTxt.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dexcriptionTxt.Location = new Point(254, 193);
            dexcriptionTxt.Multiline = true;
            dexcriptionTxt.Name = "dexcriptionTxt";
            dexcriptionTxt.Size = new Size(268, 119);
            dexcriptionTxt.TabIndex = 8;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(150, 250, 0);
            SaveBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.Location = new Point(100, 361);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(126, 49);
            SaveBtn.TabIndex = 9;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(150, 250, 0);
            exitBtn.DialogResult = DialogResult.Cancel;
            exitBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(293, 361);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(126, 49);
            exitBtn.TabIndex = 10;
            exitBtn.Text = "Назад";
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(exitBtn);
            Controls.Add(SaveBtn);
            Controls.Add(dexcriptionTxt);
            Controls.Add(typeCmb);
            Controls.Add(label4);
            Controls.Add(oborCmb);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "AddForm";
            Text = "Добавление заявки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox oborCmb;
        private Label label4;
        private ComboBox typeCmb;
        private TextBox dexcriptionTxt;
        private Button SaveBtn;
        private Button exitBtn;
    }
}
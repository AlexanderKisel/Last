namespace Last.Forms
{
    partial class EditForm
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
            exitBtn = new Button();
            SaveBtn = new Button();
            descriptionTxt = new TextBox();
            typeCmb = new ComboBox();
            label4 = new Label();
            oborCmb = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            rabCmb = new ComboBox();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(150, 250, 0);
            exitBtn.DialogResult = DialogResult.Cancel;
            exitBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(264, 438);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(126, 49);
            exitBtn.TabIndex = 19;
            exitBtn.Text = "Назад";
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(150, 250, 0);
            SaveBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.Location = new Point(95, 438);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(126, 49);
            SaveBtn.TabIndex = 18;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // descriptionTxt
            // 
            descriptionTxt.Enabled = false;
            descriptionTxt.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTxt.Location = new Point(215, 199);
            descriptionTxt.Multiline = true;
            descriptionTxt.Name = "descriptionTxt";
            descriptionTxt.Size = new Size(268, 119);
            descriptionTxt.TabIndex = 17;
            // 
            // typeCmb
            // 
            typeCmb.Enabled = false;
            typeCmb.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            typeCmb.FormattingEnabled = true;
            typeCmb.Location = new Point(215, 141);
            typeCmb.Name = "typeCmb";
            typeCmb.Size = new Size(268, 36);
            typeCmb.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(136, 15);
            label4.Name = "label4";
            label4.Size = new Size(232, 33);
            label4.TabIndex = 15;
            label4.Text = "Рассмотрение заявки";
            // 
            // oborCmb
            // 
            oborCmb.Enabled = false;
            oborCmb.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            oborCmb.FormattingEnabled = true;
            oborCmb.Location = new Point(215, 86);
            oborCmb.Name = "oborCmb";
            oborCmb.Size = new Size(268, 36);
            oborCmb.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 13;
            label3.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 144);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 12;
            label1.Text = "Тип неисправности";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 11;
            label2.Text = "Оборудование";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(78, 364);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 20;
            label5.Text = "Работник";
            // 
            // rabCmb
            // 
            rabCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            rabCmb.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rabCmb.FormattingEnabled = true;
            rabCmb.Location = new Point(215, 361);
            rabCmb.Name = "rabCmb";
            rabCmb.Size = new Size(268, 36);
            rabCmb.TabIndex = 21;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 533);
            Controls.Add(rabCmb);
            Controls.Add(label5);
            Controls.Add(exitBtn);
            Controls.Add(SaveBtn);
            Controls.Add(descriptionTxt);
            Controls.Add(typeCmb);
            Controls.Add(label4);
            Controls.Add(oborCmb);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "EditForm";
            Text = "Рассмотрение заявки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private Button SaveBtn;
        private TextBox descriptionTxt;
        private ComboBox typeCmb;
        private Label label4;
        private ComboBox oborCmb;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private ComboBox rabCmb;
    }
}
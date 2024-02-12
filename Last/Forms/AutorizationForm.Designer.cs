namespace Last
{
    partial class AutorizationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LoginTxt = new TextBox();
            pswdTxt = new TextBox();
            EnterBtn = new Button();
            exitBtn = new Button();
            pswdcheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 33);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 63);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 119);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // LoginTxt
            // 
            LoginTxt.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginTxt.Location = new Point(119, 63);
            LoginTxt.Name = "LoginTxt";
            LoginTxt.Size = new Size(291, 36);
            LoginTxt.TabIndex = 3;
            // 
            // pswdTxt
            // 
            pswdTxt.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pswdTxt.Location = new Point(119, 116);
            pswdTxt.Name = "pswdTxt";
            pswdTxt.Size = new Size(291, 36);
            pswdTxt.TabIndex = 4;
            pswdTxt.UseSystemPasswordChar = true;
            // 
            // EnterBtn
            // 
            EnterBtn.BackColor = Color.FromArgb(150, 250, 0);
            EnterBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EnterBtn.Location = new Point(54, 234);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(126, 49);
            EnterBtn.TabIndex = 5;
            EnterBtn.Text = "Войти";
            EnterBtn.UseVisualStyleBackColor = false;
            EnterBtn.Click += EnterBtn_Click;
            EnterBtn.MouseEnter += EnterBtn_MouseEnter;
            EnterBtn.MouseLeave += EnterBtn_MouseLeave;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(150, 250, 0);
            exitBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(244, 234);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(126, 49);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Закрыть";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            exitBtn.MouseEnter += exitBtn_MouseEnter;
            exitBtn.MouseLeave += exitBtn_MouseLeave;
            // 
            // pswdcheckBox
            // 
            pswdcheckBox.AutoSize = true;
            pswdcheckBox.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pswdcheckBox.Location = new Point(234, 180);
            pswdcheckBox.Name = "pswdcheckBox";
            pswdcheckBox.Size = new Size(176, 32);
            pswdcheckBox.TabIndex = 7;
            pswdcheckBox.Text = "Показать пароль";
            pswdcheckBox.UseVisualStyleBackColor = true;
            pswdcheckBox.CheckedChanged += pswdcheckBox_CheckedChanged;
            // 
            // AutorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 304);
            Controls.Add(pswdcheckBox);
            Controls.Add(exitBtn);
            Controls.Add(EnterBtn);
            Controls.Add(pswdTxt);
            Controls.Add(LoginTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AutorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LoginTxt;
        private TextBox pswdTxt;
        private Button EnterBtn;
        private Button exitBtn;
        private CheckBox pswdcheckBox;
    }
}

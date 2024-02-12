namespace Last.Forms
{
    partial class MainForm
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
            fioLbl = new Label();
            zayDgv = new DataGridView();
            EnterBtn = new Button();
            editBtn = new Button();
            delBtn = new Button();
            ExpBtn = new Button();
            exitBtn = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            filterCmb = new ComboBox();
            label2 = new Label();
            searchTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)zayDgv).BeginInit();
            SuspendLayout();
            // 
            // fioLbl
            // 
            fioLbl.AutoSize = true;
            fioLbl.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fioLbl.Location = new Point(12, 9);
            fioLbl.Name = "fioLbl";
            fioLbl.Size = new Size(56, 28);
            fioLbl.TabIndex = 2;
            fioLbl.Text = "ФИО";
            // 
            // zayDgv
            // 
            zayDgv.AllowUserToAddRows = false;
            zayDgv.AllowUserToDeleteRows = false;
            zayDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            zayDgv.Location = new Point(12, 40);
            zayDgv.Name = "zayDgv";
            zayDgv.ReadOnly = true;
            zayDgv.RowTemplate.Height = 25;
            zayDgv.Size = new Size(819, 349);
            zayDgv.TabIndex = 3;
            // 
            // EnterBtn
            // 
            EnterBtn.BackColor = Color.FromArgb(150, 250, 0);
            EnterBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EnterBtn.Location = new Point(12, 395);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(159, 79);
            EnterBtn.TabIndex = 6;
            EnterBtn.Text = "Оставить заявку";
            EnterBtn.UseVisualStyleBackColor = false;
            EnterBtn.Click += EnterBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(150, 250, 0);
            editBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.Location = new Point(177, 395);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(159, 79);
            editBtn.TabIndex = 7;
            editBtn.Text = "Рассмотреть заявку";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.FromArgb(150, 250, 0);
            delBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delBtn.Location = new Point(342, 395);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(159, 79);
            delBtn.TabIndex = 8;
            delBtn.Text = "Удалить";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // ExpBtn
            // 
            ExpBtn.BackColor = Color.FromArgb(150, 250, 0);
            ExpBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExpBtn.Location = new Point(507, 395);
            ExpBtn.Name = "ExpBtn";
            ExpBtn.Size = new Size(159, 79);
            ExpBtn.TabIndex = 9;
            ExpBtn.Text = "Экспорт";
            ExpBtn.UseVisualStyleBackColor = false;
            ExpBtn.Click += ExpBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(150, 250, 0);
            exitBtn.DialogResult = DialogResult.Cancel;
            exitBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(672, 395);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(159, 79);
            exitBtn.TabIndex = 10;
            exitBtn.Text = "Выйти из аккаунта";
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(858, 40);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 11;
            label1.Text = "Поиск";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(858, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 147);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сортировка";
            // 
            // filterCmb
            // 
            filterCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            filterCmb.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            filterCmb.FormattingEnabled = true;
            filterCmb.Items.AddRange(new object[] { "-Вернуть-", "В ожидании", "В работе", "Готов" });
            filterCmb.Location = new Point(858, 321);
            filterCmb.Name = "filterCmb";
            filterCmb.Size = new Size(259, 36);
            filterCmb.TabIndex = 13;
            filterCmb.SelectedIndexChanged += filterCmb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(858, 290);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 14;
            label2.Text = "Фильтрация";
            // 
            // searchTxt
            // 
            searchTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchTxt.Location = new Point(924, 40);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(207, 29);
            searchTxt.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 486);
            Controls.Add(searchTxt);
            Controls.Add(label2);
            Controls.Add(filterCmb);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(exitBtn);
            Controls.Add(ExpBtn);
            Controls.Add(delBtn);
            Controls.Add(editBtn);
            Controls.Add(EnterBtn);
            Controls.Add(zayDgv);
            Controls.Add(fioLbl);
            Name = "MainForm";
            Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)zayDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fioLbl;
        private DataGridView zayDgv;
        private Button EnterBtn;
        private Button editBtn;
        private Button delBtn;
        private Button ExpBtn;
        private Button exitBtn;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox filterCmb;
        private Label label2;
        private TextBox searchTxt;
    }
}
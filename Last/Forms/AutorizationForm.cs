using Last.Forms;
using Last.Models;

namespace Last
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromArgb(150, 250, 0);
        }

        private void EnterBtn_MouseEnter(object sender, EventArgs e)
        {
            EnterBtn.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            var login = LoginTxt.Text;
            var password = pswdTxt.Text;

            using (LastContext db = new LastContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
                if (user != null)
                {
                    ForAutoriz.Id = user.IdUser;
                    ForAutoriz.FIO = user.Fio;
                    ForAutoriz.Role = user.RoleId.ToString();
                    MainForm mainForm = new MainForm();
                    Hide();
                    mainForm.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EnterBtn_MouseLeave(object sender, EventArgs e)
        {
            EnterBtn.BackColor = Color.FromArgb(150, 250, 0);
        }

        private void pswdcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(pswdcheckBox.Checked)
            {
                pswdTxt.UseSystemPasswordChar = false;
            }
            else
            {
                pswdTxt.UseSystemPasswordChar = true;
            }
        }
    }
}

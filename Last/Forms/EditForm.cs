using Last.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Last.Forms
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();

            rabCmb.DisplayMember = "Fio";
            using (var db = new LastContext())
            {
                oborCmb.DataSource = db.Oborudovanies.Select(x => x.TitleObor).ToList();
                typeCmb.DataSource = db.Types.Select(x => x.TitleType).ToList();
                rabCmb.DataSource = db.Users.Where(x => x.RoleId == 2).ToList();
            }
            oborCmb.SelectedIndex = (int)ForEdit.OborId;
            typeCmb.SelectedIndex = (int)ForEdit.TypeId;
            descriptionTxt.Text = ForEdit.Descroption;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using(var db = new LastContext())
            {
                Zayavki? update = db.Zayavkis.FirstOrDefault(x => x.IdZayavki == ForEdit.ZayavkiId);

                update.DateStart = ForEdit.DateStart;
                update.OborId = ForEdit.OborId;
                update.TypeId = ForEdit.TypeId;
                update.Description = ForEdit.Descroption;
                update.ClientId = ForEdit.ClientId;
                update.DateStart = DateTime.UtcNow;
                update.DateEnd = ForEdit.DateEnd;
                update.RabId = ((User)(rabCmb.SelectedItem)).IdUser;
                update.StatusId = 2;

                db.Zayavkis.Update(update);
                db.SaveChanges();

                MessageBox.Show("Заявка обработана успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

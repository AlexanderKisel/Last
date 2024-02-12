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
    public partial class AddForm : Form
    {
        List<Int32> obotydovanies = new List<Int32>();
        List<Int32> types = new List<Int32>();
        public AddForm()
        {
            InitializeComponent();

            using (LastContext db = new LastContext())
            {
                oborCmb.DataSource = db.Oborudovanies.Select(x => x.TitleObor).ToList();
                obotydovanies = db.Oborudovanies.Select(x => x.IdObor).ToList();
                typeCmb.DataSource = db.Types.Select(x => x.TitleType).ToList();
                types = db.Types.Select(x => x.IdType).ToList();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var newZayavka = new Zayavki();
            newZayavka.DateStart = DateTime.Now;
            newZayavka.OborId = obotydovanies[oborCmb.SelectedIndex];
            newZayavka.TypeId = types[typeCmb.SelectedIndex];
            newZayavka.Description = dexcriptionTxt.Text;
            newZayavka.ClientId = ForAutoriz.Id;
            newZayavka.StatusId = 1;

            using (var db = new LastContext())
            {
                db.Zayavkis.Add(newZayavka);
                db.SaveChanges();
                MessageBox.Show("Ваша заявка принята!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

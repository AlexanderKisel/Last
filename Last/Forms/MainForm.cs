using Last.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Last.Forms
{
    public partial class MainForm : Form
    {
        DataTable dt = new DataTable();
        public MainForm()
        {
            InitializeComponent();

            zayDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            zayDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            fioLbl.Text = ForAutoriz.FIO;
            switch (ForAutoriz.Role)
            {
                case "1":
                    editBtn.Text = "Рассмотреть заявку";
                    dt.Columns.Add("Номер заявки");
                    dt.Columns.Add("Дата заявки");
                    dt.Columns.Add("Оборудование");
                    dt.Columns.Add("Тип неисправности");
                    dt.Columns.Add("Описание");
                    dt.Columns.Add("Клиент");
                    dt.Columns.Add("Дата начала");
                    dt.Columns.Add("Дата окончания");
                    dt.Columns.Add("Рабочий");
                    dt.Columns.Add("Статус");
                    UpdateDgv();
                    break;
                case "2":
                    delBtn.Visible = false;
                    editBtn.Text = "Заказ готов";
                    dt.Columns.Add("Номер заявки");
                    dt.Columns.Add("Дата заявки");
                    dt.Columns.Add("Оборудование");
                    dt.Columns.Add("Тип неисправности");
                    dt.Columns.Add("Описание");
                    dt.Columns.Add("Дата начала");
                    dt.Columns.Add("Дата окончания");
                    dt.Columns.Add("Статус");
                    UpdateDgvWorker();
                    break;
                case "3":
                    editBtn.Visible = false;
                    delBtn.Visible = false;
                    dt.Columns.Add("Номер заявки");
                    dt.Columns.Add("Дата заявки");
                    dt.Columns.Add("Оборудование");
                    dt.Columns.Add("Тип неисправности");
                    dt.Columns.Add("Описание");
                    dt.Columns.Add("Статус");
                    UpdateDgvClient();
                    break;
            }
        }

        private void UpdateDgv()
        {
            this.Width = 1176;
            this.Height = 525;
            using (LastContext db = new LastContext())
            {
                var zayavkis = db.Zayavkis
                    .Include(x => x.Rab)
                    .Include(x => x.Client)
                    .Include(x => x.Obor)
                    .Include(x => x.Type)
                    .Include(x => x.Status)
                    .ToList();
                dt.Clear();
                foreach (var zayavka in zayavkis)
                {
                    DataRow row = dt.NewRow();
                    row["Номер заявки"] = zayavka.IdZayavki;
                    row["Дата заявки"] = zayavka.DateZayavki;
                    row["Оборудование"] = $"{zayavka.Obor.TitleObor}";
                    row["Тип неисправности"] = $"{zayavka.Type.TitleType}";
                    row["Описание"] = zayavka.Description;
                    row["Клиент"] = $"{zayavka.Client.Fio}";
                    row["Дата начала"] = zayavka.DateStart;
                    row["Дата окончания"] = zayavka.DateEnd;
                    row["Рабочий"] = $"{zayavka.Rab?.Fio}";
                    row["Статус"] = $"{zayavka.Status.TitleStatus}";
                    dt.Rows.Add(row);
                }
                zayDgv.DataSource = dt;
            }
        }
        private void UpdateDgvWorker()
        {
            this.Width = 857;
            this.Height = 525;
            using (LastContext db = new LastContext())
            {
                var zayavkis = db.Zayavkis
                    .Include(x => x.Rab)
                    .Include(x => x.Client)
                    .Include(x => x.Obor)
                    .Include(x => x.Type)
                    .Include(x => x.Status)
                    .ToList();
                dt.Clear();
                foreach (var zayavka in zayavkis)
                {
                    if (ForAutoriz.Id == zayavka.RabId)
                    {
                        DataRow row = dt.NewRow();
                        row["Номер заявки"] = zayavka.IdZayavki;
                        row["Дата заявки"] = zayavka.DateZayavki;
                        row["Оборудование"] = $"{zayavka.Obor.TitleObor}";
                        row["Тип неисправности"] = $"{zayavka.Type.TitleType}";
                        row["Описание"] = zayavka.Description;
                        row["Дата начала"] = zayavka.DateStart;
                        row["Дата окончания"] = zayavka.DateEnd;
                        row["Статус"] = $"{zayavka.Status.TitleStatus}";
                        dt.Rows.Add(row);
                    }
                }
                zayDgv.DataSource = dt;
            }
        }
        private void UpdateDgvClient()
        {
            this.Width = 857;
            this.Height = 525;
            using (LastContext db = new LastContext())
            {
                var zayavkis = db.Zayavkis
                    .Include(x => x.Rab)
                    .Include(x => x.Client)
                    .Include(x => x.Obor)
                    .Include(x => x.Type)
                    .Include(x => x.Status)
                    .ToList();
                dt.Clear();
                foreach (var zayavka in zayavkis)
                {
                    if (ForAutoriz.Id == zayavka.ClientId)
                    {
                        DataRow row = dt.NewRow();
                        row["Номер заявки"] = zayavka.IdZayavki;
                        row["Дата заявки"] = zayavka.DateZayavki;
                        row["Оборудование"] = $"{zayavka.Obor.TitleObor}";
                        row["Тип неисправности"] = $"{zayavka.Type.TitleType}";
                        row["Описание"] = zayavka.Description;
                        row["Статус"] = $"{zayavka.Status.TitleStatus}";
                        dt.Rows.Add(row);
                    }
                }
                zayDgv.DataSource = dt;
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            Hide();
            addForm.ShowDialog();
            Show();
            switch (ForAutoriz.Role)
            {
                case "1": UpdateDgv(); break;
                case "2": UpdateDgvWorker(); break;
                case "3": UpdateDgvClient(); break;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите удалить заявку?", "Внимание", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = new LastContext())
                {
                    var id = Int32.Parse(zayDgv.Rows[zayDgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                    var selected = db.Zayavkis.FirstOrDefault(x => x.IdZayavki == id);
                    if (selected != null)
                    {
                        db.Zayavkis.Remove(selected);
                        db.SaveChanges();
                        UpdateDgv();
                    }
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (editBtn.Text == "Рассмотреть заявку")
            {
                using (var db = new LastContext())
                {
                    var id = Int32.Parse(zayDgv.Rows[zayDgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                    var selected = db.Zayavkis.FirstOrDefault(x => x.IdZayavki == id);

                    if (selected != null)
                    {
                        ForEdit.ZayavkiId = selected.IdZayavki;
                        ForEdit.ZayavkiDate = selected.DateZayavki;
                        ForEdit.OborId = selected.OborId;
                        ForEdit.TypeId = selected.TypeId;
                        ForEdit.Descroption = selected.Description;
                        ForEdit.ClientId = selected.ClientId;
                        ForEdit.DateStart = selected.DateStart;
                        ForEdit.DateEnd = selected.DateEnd;
                        ForEdit.RabId = selected.RabId;
                        ForEdit.StatusId = selected.StatusId;

                        EditForm editForm = new EditForm();
                        Hide();
                        editForm.ShowDialog();
                        Show();
                        UpdateDgv();
                    }
                }
            }
            else if (editBtn.Text == "Заказ готов")
            {
                if (MessageBox.Show("Вы завершили заявку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var db = new LastContext())
                    {
                        var id = Int32.Parse(zayDgv.Rows[zayDgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                        var selected = db.Zayavkis.FirstOrDefault(x => x.IdZayavki == id);
                        Zayavki? update = db.Zayavkis.FirstOrDefault(x => x.IdZayavki == id);
                        if (update != null && selected != null)
                        {
                            update.IdZayavki = selected.IdZayavki;
                            update.DateZayavki = selected.DateZayavki;
                            update.OborId = selected.OborId;
                            update.TypeId = selected.TypeId;
                            update.ClientId = selected.ClientId;
                            update.Description = selected.Description;
                            update.DateStart = selected.DateStart;
                            update.DateEnd = DateTime.UtcNow;
                            update.RabId = selected.RabId;
                            update.StatusId = 3;

                            db.Zayavkis.Update(update);
                            db.SaveChanges();
                            UpdateDgvWorker();
                        }
                    }
                }
            }
        }

        private void filterCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filterCmb.SelectedIndex)
            {
                case 0: filter(0); break;
                case 1: filter(1); break;
                case 2: filter(2); break;
                case 3: filter(3); break;
            }
        }

        private void filter(int status)
        {
            using (LastContext db = new LastContext())
            {
                var zayavkis = db.Zayavkis
                    .Include(x => x.Rab)
                    .Include(x => x.Client)
                    .Include(x => x.Obor)
                    .Include(x => x.Type)
                    .Include(x => x.Status)
                    .ToList();
                dt.Clear();
                foreach (var zayavka in zayavkis)
                {
                    if (status == 0)
                    {
                        UpdateDgv();
                    }
                    if (status == zayavka.Status.IdStatus)
                    {
                        DataRow row = dt.NewRow();
                        row["Номер заявки"] = zayavka.IdZayavki;
                        row["Дата заявки"] = zayavka.DateZayavki;
                        row["Оборудование"] = $"{zayavka.Obor.TitleObor}";
                        row["Тип неисправности"] = $"{zayavka.Type.TitleType}";
                        row["Описание"] = zayavka.Description;
                        row["Клиент"] = $"{zayavka.Client.Fio}";
                        row["Дата начала"] = zayavka.DateStart;
                        row["Дата окончания"] = zayavka.DateEnd;
                        row["Рабочий"] = $"{zayavka.Rab?.Fio}";
                        row["Статус"] = $"{zayavka.Status.TitleStatus}";
                        dt.Rows.Add(row);
                    }
                }
                zayDgv.DataSource = dt;
            }
        }

        private void ExpBtn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            workbook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

            worksheet = workbook.Worksheets.get_Item(1);

            for (int i = 0;i < zayDgv.Rows.Count; i++)
            {
                for (int j = 0; j < zayDgv.Columns.Count; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = zayDgv.Rows[i].Cells[j].Value;
                }
            }

            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}

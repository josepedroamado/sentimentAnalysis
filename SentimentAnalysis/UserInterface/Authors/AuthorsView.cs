using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class AuthorsView : UserControl
    {
        private MainWindow mainWin;

        public AuthorsView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
            LoadTable();
        }

        private void UpdateAuthors()
        {
            //dataGridViewAuthors.DataSource = null;
            //dataGridViewAuthors.Items.Clear();
            //listBoxAuthors.DataSource = mainWin.Data.entitySaver.FetchAll();
            //listBoxAuthors.DisplayMember = "Name";
            //listBoxAuthors.ValueMember = "EntityId";
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAddAuthorView();
        }

        private void BtnDeleteAuthor_Click(object sender, EventArgs e)
        {
            //if (listBoxEntities.SelectedValue != null)
            //{
            //    object selectedId = listBoxEntities.SelectedValue;
            //    string selected = selectedId.ToString();
            //    int selectedFinal = Int32.Parse(selected);
            //    Entity SelectedEntity = mainWin.Data.entitySaver.FetchEntity(selectedFinal);
            //    EntityDeleter deleter = new EntityDeleter(mainWin.Data, SelectedEntity);
            //    UpdateEntities();
            //}
        }

        private void BtnModifyAuthor_Click(object sender, EventArgs e)
        {
            //if (dataGridViewAuthors.SelectedValue != null)
            //{
            //    object selectedId = listBoxAuthors.SelectedValue;
            //    Guid selected = (Guid)selectedId;
            //    mainWin.SwitchToModifyAuthorView(selected);
            //}
        }

        private void LoadTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Usuario", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Apellido", typeof(string));
            table.Columns.Add("% Frases Positivas", typeof(int));
            table.Columns.Add("% Frases Negativas", typeof(int));
            table.Columns.Add("Entidades Mencionadas", typeof(int));
            table.Columns.Add("Promedio Frases Diarias Positivas", typeof(int));

            //List<Alarm> allAlarms = mainWin.Data.alarmSaver.FetchAll();
            //foreach (Alarm alarm in allAlarms)
            //{
            //    string active = "No";
            //    if (alarm.Active)
            //    {
            //        active = "Si";
            //    }

            //    string alarmType = alarm.GetType().Name;
            //    string type = "Negativa";
            //    string sentiment = "Negativo";
            //    string authorNames = "No aplica";
            //    if (alarmType == "PositiveAlarm")
            //    {
            //        type = "Positiva";
            //        sentiment = "Positivo";
            //    }
            //    if (alarmType == "AuthorAlarm")
            //    {
            //        type = "Autores";
            //        AuthorAlarm authorAlarm = (AuthorAlarm)alarm;
            //        if (authorAlarm.PhrasesType == "Positivas")
            //        {
            //            sentiment = "Positivo";
            //        }
            //        AlarmAnalyzer alarmAnalyzer = new AlarmAnalyzer(mainWin.Data);
            //        List<Author> authors = alarmAnalyzer.GetMatchingRelationsAuthors(alarm);
            //        if (authors.Count == 0)
            //        {
            //            authorNames = "Ninguno";
            //        }
            //        else
            //        {
            //            foreach (Author author in authors)
            //            {
            //                authorNames += ", " + author.UserName;
            //            }
            //        }

            //    }

            //    TimeSpan timeSpan = new TimeSpan(alarm.TimeFrame);
            //    string timeFrame = timeSpan.Days + " días " + timeSpan.Hours + " horas";

            //    table.Rows.Add(active, alarm.Entity.Name, type, alarm.RequiredPostQuantity, timeFrame, sentiment, authorNames);
            //}

            dataGridViewAuthors.DataSource = table;
            dataGridViewAuthors.EnableHeadersVisualStyles = false;
            dataGridViewAuthors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 60, 60, 60);

            for (int i = 0; i < dataGridViewAuthors.Columns.Count; i++)
            {
                dataGridViewAuthors.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}

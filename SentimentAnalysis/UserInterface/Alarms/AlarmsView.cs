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
    public partial class AlarmsView : UserControl
    {
        private MainWindow mainWin;

        public AlarmsView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
            LoadTable();
        }

        private void BtnAddAlarm_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAddAlarmView();
        }

        private void LoadTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Activa", typeof(string));
            table.Columns.Add("Entidad", typeof(string));
            table.Columns.Add("Tipo", typeof(string));
            table.Columns.Add("Publicaciones Requeridas", typeof(int));
            table.Columns.Add("Plazo de Tiempo", typeof(string));
            table.Columns.Add("Sentimiento", typeof(string));
            table.Columns.Add("Autores", typeof(string));

            List<Alarm> allAlarms = mainWin.Data.alarmSaver.FetchAll();
            foreach (Alarm alarm in allAlarms)
            {
                string active = "No";
                if (alarm.Active)
                {
                    active = "Si";
                }

                string alarmType = alarm.GetType().Name;
                string type = "Negativa";
                string sentiment = "Negativo";
                string authorNames = "No aplica";
                if (alarmType == "PositiveAlarm")
                {
                    type = "Positiva";
                    sentiment = "Positivo";
                }
                if (alarmType == "AuthorAlarm")
                {
                    type = "Autores";
                    AuthorAlarm authorAlarm = (AuthorAlarm)alarm;
                    if (authorAlarm.PhrasesType == "Positivas")
                    {
                        sentiment = "Positivo";
                    }
                    AlarmAnalyzer alarmAnalyzer = new AlarmAnalyzer(mainWin.Data);
                    List<Author> authors = alarmAnalyzer.GetMatchingRelationsAuthors(alarm);
                    if (authors.Count == 0)
                    {
                        authorNames = "Ninguno";
                    }
                    else
                    {
                        foreach (Author author in authors)
                        {
                            authorNames += ", " + author.UserName;
                        }
                    }

                }

                TimeSpan timeSpan = new TimeSpan(alarm.TimeFrame);
                string timeFrame = timeSpan.Days + " días " + timeSpan.Hours +" horas";

                table.Rows.Add(active, alarm.Entity.Name, type, alarm.RequiredPostQuantity, timeFrame, sentiment, authorNames);
            }

            dataGridViewAlarms.DataSource = table;
            dataGridViewAlarms.EnableHeadersVisualStyles = false;
            dataGridViewAlarms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 60,60,60);

            for (int i = 0; i < dataGridViewAlarms.Columns.Count; i++)
            {
                dataGridViewAlarms.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}

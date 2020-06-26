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
    public partial class AddAlarmView : UserControl
    {
        private MainWindow mainWin;

        public AddAlarmView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
            LoadObjects();
            SetPhrasesUIVisible(false);
        }

        private void BtnCancelAddAlarm_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAlarmsView();
        }
        private void LoadObjects()
        {
            comboBoxEntity.DataSource = null;
            comboBoxEntity.Items.Clear();
            comboBoxEntity.DataSource = mainWin.Data.entitySaver.FetchAll();
            comboBoxEntity.DisplayMember = "Name";
            comboBoxEntity.ValueMember = "EntityId";

            comboBoxAlarmType.DataSource = null;
            comboBoxAlarmType.Items.Clear();
            comboBoxAlarmType.DisplayMember = "Text";
            comboBoxAlarmType.ValueMember = "Value";
            var alarmTypes = new[] {
                new { Text = "Positiva", Value = "Positiva" },
                new { Text = "Negativa", Value = "Negativa" },
                new { Text = "Autores", Value = "Autores" }
            };
            comboBoxAlarmType.DataSource = alarmTypes;

            comboBoxPhrasesType.DataSource = null;
            comboBoxPhrasesType.Items.Clear();
            comboBoxPhrasesType.DisplayMember = "Text";
            comboBoxPhrasesType.ValueMember = "Value";
            var phraseTypes = new[] {
                new { Text = "Positivas", Value = "Positivas" },
                new { Text = "Negativas", Value = "Negativas" }
            };
            comboBoxPhrasesType.DataSource = phraseTypes;
        }
        private void BtnAddAlarm_Click(object sender, EventArgs e)
        {
            try
            {
                Guid selected = (Guid)comboBoxEntity.SelectedValue;
                Entity SelectedEntity = mainWin.Data.entitySaver.Fetch(selected);
                int numberOfPosts = Convert.ToInt32(numericUpDownPosts.Value);
                int alarmTime = Convert.ToInt32(numericUpDownAlarmTime.Value);
                string alarmType = (string)comboBoxAlarmType.SelectedValue;
                string phrasesType = (string)comboBoxPhrasesType.SelectedValue;
                bool hours = radioButtonHours.Checked;
                AlarmAdder adder = new AlarmAdder(mainWin.Data);
                adder.Add(SelectedEntity, numberOfPosts, alarmTime, alarmType, hours, phrasesType);
                mainWin.SwitchToAlarmsView();
            }
            catch (QuantityTooHigh exception)
            {
                labelAlarmEntityException.Visible = true;
                labelAlarmEntityException.Text = "Error: " + exception.Message;
            }
            catch (QuantityTooLow exception)
            {
                labelAlarmEntityException.Visible = true;
                labelAlarmEntityException.Text = "Error: " + exception.Message;
            }
        }

        private void ComboBoxAlarmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string alarmType = (string)comboBoxAlarmType.SelectedValue;
            if (alarmType == "Autores")
            {
                SetPhrasesUIVisible(true);
            }
            else
            {
                SetPhrasesUIVisible(false);
            }
        }

        private void SetPhrasesUIVisible(bool active)
        {
            comboBoxPhrasesType.Visible = active;
            comboBoxPhrasesType.Enabled = active;
            labelPhrasesType.Visible = active;
            labelPhrasesType.Enabled = active;
        }
    }
}

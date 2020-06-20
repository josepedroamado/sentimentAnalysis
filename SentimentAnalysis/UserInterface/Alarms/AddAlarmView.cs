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
        }
        private void BtnAddAlarm_Click(object sender, EventArgs e)
        {
            object selectedId = comboBoxEntity.SelectedValue;
            string selected = selectedId.ToString();
            Guid selectedFinal = Guid.Parse(selected);
            Entity SelectedEntity = mainWin.Data.entitySaver.Fetch(selectedFinal);
            int numberOfPosts = Convert.ToInt32(numericUpDownPosts.Value);
            int alarmTime = Convert.ToInt32(numericUpDownAlarmTime.Value);
            Boolean positive = radioButtonPositive.Checked;
            Boolean hours = radioButtonHours.Checked;
            AlarmAdder adder = new AlarmAdder(mainWin.Data);
            adder.Add(SelectedEntity, numberOfPosts, alarmTime, positive, hours);
            mainWin.SwitchToAlarmsView();
        }

    }
}

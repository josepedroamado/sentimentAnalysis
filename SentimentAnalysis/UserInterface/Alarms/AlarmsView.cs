using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AlarmsView : UserControl
    {
        private MainWindow mainWin;

        public AlarmsView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
            LoadBox();
        }

        private void BtnAddAlarm_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAddAlarmView();
        }
        private void LoadBox()
        {
            listBoxAlarms.Items.Clear();
            listBoxAlarms.DataSource = mainWin.Data.alarmSaver.FetchAll();
            listBoxAlarms.DisplayMember.ToString();
        }
    }
}

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
    public partial class AddAlarmView : UserControl
    {
        private MainWindow mainWin;

        public AddAlarmView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
        }

        private void BtnCancelAddAlarm_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAlarmsView();
        }

        private void BtnAddAlarm_Click(object sender, EventArgs e)
        {

        }
    }
}

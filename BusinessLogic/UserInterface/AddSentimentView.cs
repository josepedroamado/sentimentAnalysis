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
    public partial class AddSentimentView : UserControl
    {
        private MainWindow mainWin;

        public AddSentimentView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
        }

        private void BtnCancelAddSentiment_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToSentimentView();
        }
    }
}

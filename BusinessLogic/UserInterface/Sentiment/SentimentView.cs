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
    public partial class SentimentView : UserControl
    {
        private MainWindow mainWin;

        public SentimentView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
        }

        private void ComboBoxSentimentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddSentiment_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAddSentimentView();
        }
    }
}

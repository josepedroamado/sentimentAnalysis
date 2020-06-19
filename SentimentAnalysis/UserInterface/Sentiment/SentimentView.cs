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
    public partial class SentimentView : UserControl
    {
        private MainWindow mainWin;

        public SentimentView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
            UpdateSentimentsPositive();
        }

        private void ComboBoxSentimentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateSentimentsPositive()
        {
            listBoxSentiment.DataSource = null;
            listBoxSentiment.Items.Clear();
            listBoxSentiment.DataSource = mainWin.Data.sentimentSaver.FetchAllPositiveSentiments();
            listBoxSentiment.DisplayMember = "Text";
            listBoxSentiment.ValueMember = "SentimentId";
        }

        private void BtnAddSentiment_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAddSentimentView();
        }

        private void RadioButtonPositive_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPositive.Checked)
            {
                UpdateSentimentsPositive();
            }
            else
            {
                UpdateSentimentsNegative();
            }
        }
        private void UpdateSentimentsNegative()
        {
            listBoxSentiment.DataSource = null;
            listBoxSentiment.Items.Clear();
            listBoxSentiment.DataSource = mainWin.Data.sentimentSaver.FetchAllNegativeSentiments();
            listBoxSentiment.DisplayMember = "Text";
            listBoxSentiment.ValueMember = "SentimentId";
        }

        private void BtnDeleteSentiment_Click(object sender, EventArgs e)
        {
            if (listBoxSentiment.SelectedValue != null)
            {
                object selectedId = listBoxSentiment.SelectedValue;
                string selected = selectedId.ToString();
                Guid selectedFinal = Guid.Parse(selected);
                Sentiment SelectedSentiment = mainWin.Data.sentimentSaver.FetchSentiment(selectedFinal);
                SentimentDeleter deleter = new SentimentDeleter(mainWin.Data, SelectedSentiment);
                RadioButtonPositive_CheckedChanged(sender, e);
            }
        }
    }
}

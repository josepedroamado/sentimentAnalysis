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
    public partial class ReportsView : UserControl
    {
        private MainWindow mainWin;
        public ReportsView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
            LoadPhrases();
            LoadEntityAndSentimentType();
        }

        private void LoadPhrases()
        {
            comboBoxPhrase.DataSource = null;
            comboBoxPhrase.Items.Clear();
            comboBoxPhrase.DataSource = mainWin.Data.publicationSaver.FetchAll();
            comboBoxPhrase.ValueMember = "PublicationId";
            comboBoxPhrase.DisplayMember = "Phrase";
        }

        private void LoadEntityAndSentimentType()
        {
            Object selectedValue = comboBoxPhrase.SelectedValue;
            if (selectedValue != null)
            {
                Guid publicationId = (Guid)selectedValue;
                textBoxEntity.Clear();
                if (mainWin.Data.relationSaver.Fetch(publicationId).Entity != null)
                {
                    String entityName = mainWin.Data.relationSaver.Fetch(publicationId).Entity.Name;
                    textBoxEntity.Text = entityName;
                }
                else textBoxEntity.Text = "No se ha detectado entidad";
                textBoxSentimentType.Clear();
                if (mainWin.Data.relationSaver.Fetch(publicationId).Sentiment != null)
                {
                    String sentimentType = mainWin.Data.relationSaver.Fetch(publicationId).Sentiment.GetType().Name;
                    if (sentimentType == "PositiveSentiment") textBoxSentimentType.Text = "Positivo";
                    else if (sentimentType == "NegativeSentiment") textBoxSentimentType.Text = "Negativo";
                }
                else textBoxSentimentType.Text = "Neutro";
            }
        }

        private void ComboBoxPhrase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadEntityAndSentimentType();
        }
    }
}

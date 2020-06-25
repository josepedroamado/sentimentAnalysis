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
            LoadEntitySentimentAndAuthorType();
        }

        private void LoadPhrases()
        {
            comboBoxPhrase.DataSource = null;
            comboBoxPhrase.Items.Clear();
            comboBoxPhrase.DataSource = mainWin.Data.publicationSaver.FetchAll();
            comboBoxPhrase.ValueMember = "PublicationId";
            comboBoxPhrase.DisplayMember = "Phrase";
        }

        private void LoadEntitySentimentAndAuthorType()
        {
            Object selectedValue = comboBoxPhrase.SelectedValue;
            if (selectedValue != null &&
                mainWin.Data.publicationSaver.FetchAll().Count > 0 &&
                mainWin.Data.sentimentSaver.FetchAll().Count > 0 &&
                mainWin.Data.relationSaver.FetchAll().Count > 0 && 
                mainWin.Data.authorSaver.FetchAll().Count > 0)
            {
                Guid publicationId = (Guid)selectedValue;

                textBoxAuthor.Clear();
                string authorUsername = mainWin.Data.relationSaver.FetchWithPublication(publicationId).Publication.Author.UserName;
                textBoxAuthor.Text = authorUsername;

                textBoxEntity.Clear();
                string entityName = mainWin.Data.relationSaver.FetchWithPublication(publicationId).Entity.Name;
                textBoxEntity.Text = entityName;

                textBoxSentimentType.Clear();
                string sentimentType = mainWin.Data.relationSaver.FetchWithPublication(publicationId).Sentiment.GetType().Name;
                if (sentimentType == "PositiveSentiment") textBoxSentimentType.Text = "Positivo";
                else if (sentimentType == "NegativeSentiment") textBoxSentimentType.Text = "Negativo";
                else if (sentimentType == "NeutralSentiment") textBoxSentimentType.Text = "Neutro";
            }
        }

        private void ComboBoxPhrase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadEntitySentimentAndAuthorType();
        }
    }
}

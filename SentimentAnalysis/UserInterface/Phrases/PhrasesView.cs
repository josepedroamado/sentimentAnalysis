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
    public partial class PhrasesView : UserControl
    {
        private MainWindow mainWin;
        public PhrasesView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
            LoadAuthors();
            dateTimePickerPhraseDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerPhraseDate.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void LoadAuthors()
        {
            comboBoxPhraseAuthor.DataSource = null;
            comboBoxPhraseAuthor.Items.Clear();
            comboBoxPhraseAuthor.DataSource = mainWin.Data.authorSaver.FetchAll();
            comboBoxPhraseAuthor.DisplayMember = "UserName";
            comboBoxPhraseAuthor.ValueMember = "AuthorId";
            if(mainWin.Data.authorSaver.FetchAll().Count == 0)
            {
                btnAddPhrase.Enabled = false;
                labelPhraseTextException.Visible = true;
                labelPhraseTextException.Text = "Error: No hay autores registrados en el sistema.";
            }
        }

        private void BtnAddPhrase_Click(object sender, EventArgs e)
        {
            try
            {
                Guid selected = (Guid)comboBoxPhraseAuthor.SelectedValue;
                Author SelectedAuthor = mainWin.Data.authorSaver.Fetch(selected);
                string text = textBoxPhraseText.Text;
                DateTime date = dateTimePickerPhraseDate.Value;
                if(SelectedAuthor != null)
                {
                    PublicationAdder adder = new PublicationAdder(mainWin.Data);
                    adder.Add(text, date, SelectedAuthor);
                    this.textBoxPhraseText.Clear();
                }
                else 
                {
                    labelPhraseTextException.Visible = true;
                    labelPhraseTextException.Text = "Error: No ha seleccionado un Autor";
                }
                mainWin.SwitchToPhrasesView();
            }
            catch(TextTooShortException exception)
            {
                labelPhraseTextException.Visible = true;
                labelPhraseTextException.Text = "Error: " + exception.Message;
            }
            catch(TextTooLongException exception)
            {
                labelPhraseTextException.Visible = true;
                labelPhraseTextException.Text = "Error: " + exception.Message;
            }
            catch(ObjectAlreadyExistsException exception)
            {
                labelPhraseTextException.Visible = true;
                labelPhraseTextException.Text = "Error: " + exception.Message;
            }
        }

        private void BtnCancelAddPhrase_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToPhrasesView();
        }
    }
}

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
        }

        private void LoadObjects()
        {
            comboBoxPhraseAuthor.DataSource = null;
            comboBoxPhraseAuthor.Items.Clear();
            comboBoxPhraseAuthor.DataSource = mainWin.Data.authorSaver.FetchAll();
            comboBoxPhraseAuthor.DisplayMember = "UserName";
            comboBoxPhraseAuthor.ValueMember = "AuthorId";
        }

        private void BtnAddPhrase_Click(object sender, EventArgs e)
        {
            try
            {
                Guid selected = (Guid)comboBoxPhraseAuthor.SelectedValue;
                Author SelectedAuthor = mainWin.Data.authorSaver.Fetch(selected);
                String text = textBoxPhraseText.Text;
                DateTime date = dateTimePickerPhraseDate.Value.Date;
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
            }
            catch(TextTooShortException)
            {
                labelPhraseTextException.Visible = true;
                labelPhraseTextException.Text = "Error: La Publicacion que intenta ingresar tiene un texto muy corto o vacio";
            }
        }

        private void BtnCancelAddPhrase_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToPhrasesView();
        }
    }
}

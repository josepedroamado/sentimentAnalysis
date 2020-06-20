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

        private void BtnAddPhrase_Click(object sender, EventArgs e)
        {
            try
            {
                String text = textBoxPhraseText.Text;
                DateTime date = dateTimePickerPhraseDate.Value.Date;
//                PublicationAdder adder = new PublicationAdder(mainWin.Data, text, date);
                this.textBoxPhraseText.Clear();
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

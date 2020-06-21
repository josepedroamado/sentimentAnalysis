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

        private void btnAddSentiment_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean positive = radioButtonPositive.Checked;
                String text = textBoxSentimentText.Text;
                SentimentAdder adder = new SentimentAdder(mainWin.Data);
                adder.Add(text, positive);
                mainWin.SwitchToSentimentView();
            }
            catch (ObjectAlreadyExistsException)
            {
                labelSentimentTextException.Visible = true;
                labelSentimentTextException.Text = "Error: El sentimiento que intenta ingresar ya existe";
            }
            catch (TextTooLongException)
            {
                labelSentimentTextException.Visible = true;
                labelSentimentTextException.Text = "Error: El sentimiento que intenta ingresar tiene un texto muy largo";
            }
            catch (TextTooShortException)
            {
                labelSentimentTextException.Visible = true;
                labelSentimentTextException.Text = "Error: El sentimiento que intenta ingresar tiene un texto muy corto o vacio";
            }
        }
    }
}

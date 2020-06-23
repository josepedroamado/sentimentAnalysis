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
    public partial class AddAuthorView : UserControl
    {
        private MainWindow mainWin;

        public AddAuthorView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
            dateTimePickerAuthorBirthdate.MinDate = DateTimePicker.MinDateTime;
            dateTimePickerAuthorBirthdate.MaxDate = DateTime.Today.AddYears(-13);
            dateTimePickerAuthorBirthdate.MinDate = DateTime.Today.AddYears(-100);
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            String username = textBoxAuthorUsername.Text;
            String name = textBoxAuthorName.Text;
            String lastName = textBoxAuthorLastname.Text;
            DateTime dateOfBirth = dateTimePickerAuthorBirthdate.Value;
            AuthorAdder adder = new AuthorAdder(mainWin.Data);
            try
            {
                adder.Add(name, lastName, username, dateOfBirth);
            }
            catch(TextTooShortException)
            {
                labelAuthorException.Visible = true;
                labelAuthorException.Text = "Error: El texto del nombre/apellido o usuario debe ser mas largo";
            }
            catch (TextTooLongException)
            {
                labelAuthorException.Visible = true;
                labelAuthorException.Text = "Error: El texto del nombre/apellido o usuario debe ser mas corto";
            }
            //capturar excepciones
        }

        private void BtnCancelAddAuthor_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAuthorsView();
        }
    }
}

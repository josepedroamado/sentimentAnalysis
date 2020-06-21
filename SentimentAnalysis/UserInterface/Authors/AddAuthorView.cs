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

        }

        private void BtnCancelAddAuthor_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAuthorsView();
        }
    }
}

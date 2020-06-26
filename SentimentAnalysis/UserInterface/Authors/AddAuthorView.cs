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
        private string selectedAuthor;

        public AddAuthorView(MainWindow main, string selectedAuthor)
        {
            InitializeComponent();
            mainWin = main;
            this.selectedAuthor = selectedAuthor;
            dateTimePickerAuthorBirthdate.MinDate = DateTimePicker.MinDateTime;
            dateTimePickerAuthorBirthdate.MaxDate = DateTime.Today.AddYears(-13);
            dateTimePickerAuthorBirthdate.MinDate = DateTime.Today.AddYears(-100);
            if (selectedAuthor != null)
            {
                Guid authorId = Guid.Parse(selectedAuthor);
                Author author = mainWin.Data.authorSaver.Fetch(authorId);
                textBoxAuthorUsername.Text = author.UserName;
                textBoxAuthorName.Text = author.FirstName;
                textBoxAuthorLastname.Text = author.LastName;
                dateTimePickerAuthorBirthdate.Value = author.BirthDate;
            }
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                String username = textBoxAuthorUsername.Text;
                String name = textBoxAuthorName.Text;
                String lastName = textBoxAuthorLastname.Text;
                DateTime dateOfBirth = dateTimePickerAuthorBirthdate.Value;
                AuthorAdder adder = new AuthorAdder(mainWin.Data);
                if (selectedAuthor != null)
                {
                    adder.Modify(Guid.Parse(selectedAuthor), username, name, lastName, dateOfBirth);
                }
                else
                {
                    adder.Add(name, lastName, username, dateOfBirth);
                }
                mainWin.SwitchToAuthorsView();
            }
            catch (ObjectAlreadyExistsException exception)
            {
                labelAuthorException.Visible = true;
                labelAuthorException.Text = "Error: " + exception.Message;
            }
            catch (TextTooLongException exception)
            {
                labelAuthorException.Visible = true;
                labelAuthorException.Text = "Error: " + exception.Message;
            }
            catch (TextTooShortException exception)
            {
                labelAuthorException.Visible = true;
                labelAuthorException.Text = "Error: " + exception.Message; 
            }
            catch (TooYoungException exception)
            {
                labelAuthorException.Visible = true;
                labelAuthorException.Text = "Error: " + exception.Message;
            }
            catch (TooOldException exception)
            {
                labelAuthorException.Visible = true;
                labelAuthorException.Text = "Error: " + exception.Message;
            }
        }

        private void BtnCancelAddAuthor_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAuthorsView();
        }
    }
}

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
    public partial class AuthorsView : UserControl
    {
        private MainWindow mainWin;

        public AuthorsView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
        }

        private void UpdateAuthors()
        {
            listBoxAuthors.DataSource = null;
            listBoxAuthors.Items.Clear();
            listBoxAuthors.DataSource = mainWin.Data.authorSaver.FetchAll();
            listBoxAuthors.DisplayMember = "UserName";
            listBoxAuthors.ValueMember = "AuthorId";
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAddAuthorView();
        }

        private void BtnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (listBoxAuthors.SelectedValue != null)
            {
                Guid selected = (Guid)listBoxAuthors.SelectedValue;
                Author selectedAuthor = mainWin.Data.authorSaver.Fetch(selected);
                AuthorDeleter deleter = new AuthorDeleter(mainWin.Data);
                deleter.Delete(selectedAuthor);
                UpdateAuthors();
            }
        }

        private void BtnModifyAuthor_Click(object sender, EventArgs e)
        {
            if (listBoxAuthors.SelectedValue != null)
            {
                object selectedId = listBoxAuthors.SelectedValue;
                Guid selected = (Guid)selectedId;
                mainWin.SwitchToModifyAuthorView(selected);
            }
        }
    }
}

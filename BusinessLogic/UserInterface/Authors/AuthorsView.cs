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
            //listBoxAuthors.DataSource = mainWin.Data.entitySaver.FetchAll();
            //listBoxAuthors.DisplayMember = "Name";
            //listBoxAuthors.ValueMember = "EntityId";
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAddAuthorView();
        }

        private void BtnDeleteAuthor_Click(object sender, EventArgs e)
        {
            //if (listBoxEntities.SelectedValue != null)
            //{
            //    object selectedId = listBoxEntities.SelectedValue;
            //    string selected = selectedId.ToString();
            //    int selectedFinal = Int32.Parse(selected);
            //    Entity SelectedEntity = mainWin.Data.entitySaver.FetchEntity(selectedFinal);
            //    EntityDeleter deleter = new EntityDeleter(mainWin.Data, SelectedEntity);
            //    UpdateEntities();
            //}
        }
    }
}

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
    public partial class EntitiesView : UserControl
    {
        private MainWindow mainWin;

        public EntitiesView(MainWindow main)
        {
            InitializeComponent();
            mainWin = main;
            UpdateEntities();
        }
        private void UpdateEntities()
        {
            listBoxEntities.DataSource = null;
            listBoxEntities.Items.Clear();
            listBoxEntities.DataSource = mainWin.Data.entitySaver.FetchAll();
            listBoxEntities.DisplayMember = "Name";
            listBoxEntities.ValueMember = "EntityId";
        }

        private void BtnAddEntity_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAddEntityView();
        }

        private void BtnDeleteEntity_Click(object sender, EventArgs e)
        {
            if(listBoxEntities.SelectedValue != null)
            {
                object selectedId = listBoxEntities.SelectedValue;
                string selected = selectedId.ToString();
                Guid selectedFinal = Guid.Parse(selected);
                Entity SelectedEntity = mainWin.Data.entitySaver.Fetch(selectedFinal);
                EntityDeleter deleter = new EntityDeleter(mainWin.Data);
                deleter.Delete(SelectedEntity);
                UpdateEntities();
            }


        }
    }
}

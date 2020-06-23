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
            LoadTable();
        }

        private void UpdateAuthors()
        {
            //dataGridViewAuthors.DataSource = null;
            //dataGridViewAuthors.Items.Clear();
            //listBoxAuthors.DataSource = mainWin.Data.entitySaver.FetchAll();
            //listBoxAuthors.DisplayMember = "Name";
            //listBoxAuthors.ValueMember = "EntityId";
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAddAuthorView(null);
        }

        private void BtnDeleteAuthor_Click(object sender, EventArgs e)
        {
            Guid authorId = Guid.Parse(GetSelectedAuthorId());
            Author selectedAuthor = mainWin.Data.authorSaver.Fetch(authorId);
            mainWin.Data.authorSaver.Delete(selectedAuthor);
            mainWin.SwitchToAuthorsView();
        }

        private void BtnModifyAuthor_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAddAuthorView(GetSelectedAuthorId());
        }

        private string GetSelectedAuthorId()
        {
            int selectedRow = dataGridViewAuthors.CurrentCell.RowIndex;
            return dataGridViewAuthors.Rows[selectedRow].Cells[0].Value.ToString();
        }

        private void LoadTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(string));
            table.Columns.Add("Usuario", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Apellido", typeof(string));
            table.Columns.Add("% Frases Positivas", typeof(int));
            table.Columns.Add("% Frases Negativas", typeof(int));
            table.Columns.Add("Entidades Mencionadas", typeof(int));
            table.Columns.Add("Promedio Frases Diarias Positivas", typeof(int));

            List<Author> allAuthors = mainWin.Data.authorSaver.FetchAll();
            foreach (Author author in allAuthors)
            {              
                table.Rows.Add(author.AuthorId, author.UserName, author.FirstName, author.LastName, 0, 0, 0, 0);
            }

            dataGridViewAuthors.DataSource = table;
            dataGridViewAuthors.EnableHeadersVisualStyles = false;
            dataGridViewAuthors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 60, 60, 60);

            for (int i = 0; i < dataGridViewAuthors.Columns.Count; i++)
            {
                dataGridViewAuthors.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridViewAuthors.Columns[0].Visible = false;
        }
    }
}

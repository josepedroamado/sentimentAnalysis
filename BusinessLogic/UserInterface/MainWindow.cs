using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            HomeView view = new HomeView();
            panelView.Controls.Add(view);
        }

        private void BtnSentimentMenu_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            SentimentView view = new SentimentView();
            panelView.Controls.Add(view);
        }

        private void BtnEntities_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            EntitiesView view = new EntitiesView();
            panelView.Controls.Add(view);
        }

        private void BtnPhrases_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            PhrasesView view = new PhrasesView();
            panelView.Controls.Add(view);
        }

        private void BtnAlarms_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            AlarmsView view = new AlarmsView();
            panelView.Controls.Add(view);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            ReportsView view = new ReportsView();
            panelView.Controls.Add(view);
        }

        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            HomeView view = new HomeView();
            panelView.Controls.Add(view);
        }
    }
}

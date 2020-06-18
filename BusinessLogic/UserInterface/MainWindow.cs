using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class MainWindow : Form
    {
        public SystemData Data {get; set;}
        public MainWindow(SystemData aSystem)
        {
            InitializeComponent();
            this.Data = aSystem;
            HomeView view = new HomeView();
            panelView.Controls.Add(view);
        }

        public void SwitchToSentimentView()
        {
            panelView.Controls.Clear();
            SentimentView view = new SentimentView(this);
            panelView.Controls.Add(view);
        }

        public void SwitchToAddSentimentView()
        {
            panelView.Controls.Clear();
            AddSentimentView view = new AddSentimentView(this);
            panelView.Controls.Add(view);
        }

        public void SwitchToEntitiesView()
        {
            panelView.Controls.Clear();
            EntitiesView view = new EntitiesView(this);
            panelView.Controls.Add(view);
        }

        public void SwitchToAddEntityView()
        {
            panelView.Controls.Clear();
            AddEntityView view = new AddEntityView(this);
            panelView.Controls.Add(view);
        }

        public void SwitchToAlarmsView()
        {
            panelView.Controls.Clear();
            AlarmsView view = new AlarmsView(this);
            panelView.Controls.Add(view);
        }

        public void SwitchToAddAlarmView()
        {
            panelView.Controls.Clear();
            AddAlarmView view = new AddAlarmView(this);
            panelView.Controls.Add(view);
        }

        public void SwitchToReportsView()
        {
            panelView.Controls.Clear();
            ReportsView view = new ReportsView(this);
            panelView.Controls.Add(view);
        }

        private void BtnSentimentView_Click(object sender, EventArgs e)
        {
            SwitchToSentimentView();
        }

        private void BtnEntitiesView_Click(object sender, EventArgs e)
        {
            SwitchToEntitiesView();
        }

        private void BtnPhrasesView_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            PhrasesView view = new PhrasesView(this);
            panelView.Controls.Add(view);
        }
        public void SwitchToPhrasesView()
        {
            panelView.Controls.Clear();
            PhrasesView view = new PhrasesView(this);
            panelView.Controls.Add(view);
        }

        private void BtnAlarmsView_Click(object sender, EventArgs e)
        {
            SwitchToAlarmsView();
        }

        private void BtnReportsView_Click(object sender, EventArgs e)
        {
            SwitchToReportsView();
        }

        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            HomeView view = new HomeView();
            panelView.Controls.Add(view);
        }
    }
}

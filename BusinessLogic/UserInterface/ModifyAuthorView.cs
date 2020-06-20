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
    public partial class ModifyAuthorView : UserControl
    {
        private MainWindow mainWin;

        public ModifyAuthorView(MainWindow main, Guid selectedAuthor)
        {
            InitializeComponent();
            mainWin = main;
            //load UI with author data
            
        }

        private void BtnCancelModifyAuthor_Click(object sender, EventArgs e)
        {
            mainWin.SwitchToAuthorsView();
        }

        private void BtnModifyAuthor_Click(object sender, EventArgs e)
        {

        }
    }
}

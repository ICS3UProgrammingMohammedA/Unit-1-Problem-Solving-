using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerClubsMo
{
    public partial class frmSoccerClubs : Form
    {
        public frmSoccerClubs()
        {
            InitializeComponent();
        }


        private void lblTeamName_Click(object sender, EventArgs e)
        {
            this.lblTeamName.Text = "Manchester City";
        }

        private void mniTeamName2_Click(object sender, EventArgs e)
        {
            this.lblTeamName.Text = "Manchester United";
        }

        private void mniTeamName3_Click(object sender, EventArgs e)
        {
            this.lblTeamName.Text = "Real Madrid";
        }

        private void mniTeamName4_Click(object sender, EventArgs e)
        {
            this.lblTeamName.Text = "Barcelona";
        }
    }
}
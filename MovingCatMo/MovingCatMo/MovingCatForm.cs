/*
 * Created by: Mohammed alnajeh
 * Created on: 2018-10-03
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Name of Program
 * This program...
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatMo
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            //when you press the menu item of cat 1 it displays the cat 1
            this.picCat.Image = Properties.Resources.Cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            //when you press the menu item of cat 2 it displays the second image which is cat 2
            this.picCat.Image = Properties.Resources.Cat2;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When exit is clicked the program closses
            this.Close();        }
    }
}

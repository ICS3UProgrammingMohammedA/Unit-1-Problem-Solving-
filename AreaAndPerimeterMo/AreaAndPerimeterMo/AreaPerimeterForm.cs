/*
 * Created by: Mohammed alnajeh
 * Created on: 2018-09-19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Name of Program
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

namespace AreaAndPerimeterMo
{
    public partial class frmAreaPerimeter : Form
    {
        public frmAreaPerimeter()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //when exit is clicked the program closes
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double length;
            double width;
            double area;
            double perimeter;

            // convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            //this is the formula to solve the equation
            area = length * width;
           perimeter = length + length + width + width;

            this.lblAreaAnswer.Text = Convert.ToString(area) + " squared meters";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + "meters";

            //this is to show the hidden labels
            this.lblArea.Show();
            this.lblPerimeter.Show();
            this.lblPerimeterAnswer.Show();
            this.lblAreaAnswer.Show();

        }

        private void frmAreaPerimeter_Load(object sender, EventArgs e)
        {
//this is to hide the labels before getting the answer.
            this.lblPerimeter.Hide();
            this.lblArea.Hide();
            this.lblPerimeterAnswer.Hide();
            this.lblAreaAnswer.Hide();

        }
    }
}

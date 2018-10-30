/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-10-02
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Name of Program
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

namespace PizzaCostMo
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variable 
            double diameter, subtotal, total, Tax;

            //convert the diameter to a double
            diameter = (double)nudDiameter.Value;

            //the formulas
            subtotal = 0.99 + 0.75 + 0.5 * diameter;
            total = subtotal * 0.13 + subtotal;
            Tax = subtotal * 0.13;

            lblAnswer.Text = string.Format("${0:0.00}", subtotal);
            lblTotalAnswer.Text = string.Format("${0:0.00}", total);
            lblTaxAnswer.Text = string.Format("${0:0.00}", Tax);
        }
    }
}

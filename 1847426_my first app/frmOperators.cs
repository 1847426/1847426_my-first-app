using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1847426_my_first_app
{
    public partial class frmOperators : Form
    {
        public frmOperators()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);


            double Disc = Math.Pow(b, 2) - 4 * a * c;

            double res = (-b + Math.Sqrt(Disc)) / (2 * a);
            double res2 = (-b - Math.Sqrt(Disc)) / (2 * a);

            //Display results
            LblRes.Text = "x1:\t" + Convert.ToString(res);
            LblRes.Text = LblRes.Text + "\n\n" + "x2:\t" + Convert.ToString(res2);

        }
    }
}

﻿using System;
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
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;
            }

            if (chkDonut.Checked == true)
            {
                msg = msg + " " + chkDonut.Text;
            }

            if (chkBrownie.Checked == true)
            {
                msg = msg + " " + chkBrownie.Text;
            }



            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " selected ");
            }
            else //length is zero
            {
                MessageBox.Show("Nothing selected");
            }

        }
    }
}


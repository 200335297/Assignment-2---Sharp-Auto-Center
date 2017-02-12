/*
 * App name :- SharpAutoForm
 * Author's name :- Gowtham Talluri
 * Student ID :- 200335297
 * App Creation Date :- 2017-02-12
 * APP description :- "This program calculates the amount due on a New or Used Vehicle"
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

namespace Assignment_2_Sharp_Auto_Center
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // 1. Instantiate the next form
            sharpAutoForm sharp = new sharpAutoForm();

            // 2. pass a reference to the current form to the next form
            sharp.previousForm = this;

            this.SplashFormTimer.Enabled = false;
            sharp.Show();
            this.Hide();
        }
    }
}

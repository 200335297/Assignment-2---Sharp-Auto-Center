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
    public partial class sharpAuoForm : Form
    {
        //constants
        public const double StereoSystem = 425.76, LeatherInterior = 987.41,
            ComputerNavigation = 1741.23, Standard = 0.0, Pearlized = 345.72,
            CustomizedDetailing = 599.99, TaxeRate = 13.0;

        private double _val = 0.0;
    

        private void _CalculateClicked(object sender, EventArgs e)
        {
            if (Isnumberandnegative(BasePriceTextBox.Text))
            {
                textBox2.Text = (this._val + Convert.ToDouble(BasePriceTextBox.Text)).ToString();
            }


        }

        private bool Isnumberandnegative(string value)
        {
            double _value = 0.0;
            if (Double.TryParse(value, out _value))
            {
                if (_value > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }


        }

        private void Exit_ApplicationClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RadioandCheckboxButtonClicked(object sender, EventArgs e)
        {
            this._val = 0.0;

            if (checkBox1.Checked)
            {
                this._val += StereoSystem;
            }
            if(checkBox2.Checked)
            {
                this._val += LeatherInterior;
            }
            if (checkBox3.Checked)
            {
                this._val += ComputerNavigation;
            }
            if (radioButton1.Checked)
            {
                this._val += Standard;
            }
            if (radioButton2.Checked)
            {
                this._val += Pearlized;
            }
            if (radioButton3.Checked)
            {
                this._val += CustomizedDetailing;
            }

            textBox3.Text = this._val.ToString();


        }


        //variables
        DialogResult result;
        public sharpAuoForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fontButton_Clicked(object sender, EventArgs e)
        {
            

            result = SharpFormFontDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
               BasePriceTextBox.Font = new Font(SharpFormFontDialog.Font.FontFamily, SharpFormFontDialog.Font.Size, SharpFormFontDialog.Font.Style);
                AmountDueTextBox.Font = new Font(SharpFormFontDialog.Font.FontFamily, SharpFormFontDialog.Font.Size, SharpFormFontDialog.Font.Style);
            }
        }

        private void Color_clicked(object sender, EventArgs e)
        {
            result=SharpcolorDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                BasePriceTextBox.BackColor = SharpcolorDialog.Color;
                AmountDueTextBox.BackColor = SharpcolorDialog.Color;
            }
        }
    }
}

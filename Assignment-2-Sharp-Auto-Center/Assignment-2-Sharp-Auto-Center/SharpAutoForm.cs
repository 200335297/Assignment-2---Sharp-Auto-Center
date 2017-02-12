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
    public partial class sharpAutoForm : Form
    {

        //variables
        DialogResult result;
        public sharpAutoForm()
        {
            InitializeComponent();
        }

        //constants
        public const double StereoSystem = 425.76, LeatherInterior = 987.41,
            ComputerNavigation = 1741.23, Standard = 0.0, Pearlized = 345.72,
            CustomizedDetailing = 599.99, TaxeRate = 0.13;

        private double _val = 0.0;
    

        private void _CalculateClicked(object sender, EventArgs e)
        {
            if (Isnumberandnegative(BasePriceTextBox.Text))
            {
                textBox2.Text = (this._val + Convert.ToDouble(BasePriceTextBox.Text)).ToString();
                textBox4.Text = System.Math.Round((Convert.ToDouble(textBox2.Text) * TaxeRate), 2).ToString();

                textBox6.Text = System.Math.Round((Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox4.Text)),2).ToString();

                if (Isnumberandnegative(textBox5.Text))
                {
                    AmountDueTextBox.Text = System.Math.Round((Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox5.Text)),2).ToString();
                }else
                {
                    this.messagefunction("Incoorect Trade allowance value", "Error");
                }
            }else
            {
                this.messagefunction("Incoorect Base price Value", "Error");
            }


        }


        private bool Isnumberandnegative(string value)
        {
            double _value = 0.0;
            if (Double.TryParse(value, out _value))
            {
                if (_value >= 0)
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

        private void _ClickClearfunction(object sender, EventArgs e)
        {
            BasePriceTextBox.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox5.Text = "0";
            AmountDueTextBox.Text = String.Empty;
            this._checkboxclear();
            radioButton1.Checked = true;

 }
        private void _checkboxclear()
        {
            foreach (Control uncheck in groupBox1.Controls)
            {
                if (uncheck is CheckBox)
                {
                    CheckBox uncheck1 = uncheck as CheckBox;
                    uncheck1.Checked = false;
                    
                }
            }
                
        }

        private void messagefunction(string message, string val)
        {
            MessageBox.Show(message, val);
        }

        private void AboutButtonClicked(object sender, EventArgs e)
        {
            this.messagefunction("SharpAutoForm used to calculate", "About");
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

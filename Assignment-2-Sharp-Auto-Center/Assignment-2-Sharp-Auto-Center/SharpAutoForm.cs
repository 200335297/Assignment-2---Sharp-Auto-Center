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
    public partial class sharpAutoForm : Form
    {

        //variables
        public DialogResult result;

        //constants
        public const double StereoSystem = 425.76, LeatherInterior = 987.41,
            ComputerNavigation = 1741.23, Standard = 0.0, Pearlized = 345.72,
            CustomizedDetailing = 599.99, TaxeRate = 0.13;

        //private value variable
        private double _val = 0.0;

        //create a reference to the previous form
        public Form previousForm;

        //default constructor
        public sharpAutoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler calculate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    this.messagefunction("Incorrect Trade allowance value", "Error");
                 
                    textBox5.Text = "0";
                }
            }else
            {
                this.messagefunction("Incorrect Base price Value", "Error");
               this._ClickClearfunction(sender, e);
            }


        }

        /// <summary>
        /// To check if user entered string or negative umber
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// This method clears the sharpautoform app and resets the variables
        /// </summary>

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
        

        private void sharpAutoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           result = MessageBox.Show("Are You Sure?", "Confirm",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.previousForm.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }


        /// <summary>
        /// Event Handler for exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitbuttonClicked(object sender, EventArgs e)
        {
            this.previousForm.Close();
        }
        /// <summary>
        /// clears all varaibles and sets to default
        /// </summary>
      
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
        
        //message function
        private void messagefunction(string message, string val)
        {
            MessageBox.Show(message, val);
        }

        /// <summary>
        /// Event Handler for about button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutButtonClicked(object sender, EventArgs e)
        {
            this.messagefunction("SharpAutoForm used to calculate", "About");
        }

        /// <summary>
        /// Event Handler for checkbox and radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Event Handler for font button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      private void fontButton_Clicked(object sender, EventArgs e)
        {
            

            result = SharpFormFontDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
               BasePriceTextBox.Font = new Font(SharpFormFontDialog.Font.FontFamily, SharpFormFontDialog.Font.Size, SharpFormFontDialog.Font.Style);
                AmountDueTextBox.Font = new Font(SharpFormFontDialog.Font.FontFamily, SharpFormFontDialog.Font.Size, SharpFormFontDialog.Font.Style);
            }
        }

        /// <summary>
        /// Event Handler for color button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

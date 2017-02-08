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

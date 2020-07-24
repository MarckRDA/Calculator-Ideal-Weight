using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealWeight
{
    public partial class CalcIdealWeight : Form
    {
        RadioButton rbnSelected = null;
        public CalcIdealWeight()
        {
            InitializeComponent();
           
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                rbnSelected = rb;
                SetIdealWeight();
            }

        }

        private void SetIdealWeight()
        {
            try
            {
                double height = Convert.ToDouble(txtHeight.Text);
                double idealWeight;

                if (rbnSelected.Text.Equals("Male"))
                    idealWeight = (height - 100) * 0.9;
                else
                    idealWeight = (height - 100) * 0.85;
                lbIdealWeight.Text = idealWeight.ToString("N");
            }
            catch(Exception e)
            {
                MessageBox.Show("Select the gender and insert the height correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if(txtHeight.Text != String.Empty)
            {
                SetIdealWeight();
            }
               
        }

        
    }
}

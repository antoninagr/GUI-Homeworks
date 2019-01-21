using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigureMyAuto
{
    public partial class Form1 : Form
    {
        double CarPrice = 0;
        double ExtrasPrice = 0;
        int AllExtrasDiscount = 0;
        int CashDiscount = 0;
        int Discount = 0;
        double TotalPrice = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void rbAudi_CheckedChanged(object sender, EventArgs e)
        {
            CarPrice = 67800;
            
            pbCars.Image = ConfigureMyAuto.Properties.Resources.Audi;
            if (rbAudi.Enabled == true)
            {
                tbPrice.Text = CarPrice.ToString();
            }
        }

        private void rbMercedes_CheckedChanged(object sender, EventArgs e)
        {
            CarPrice = 50000;
            pbCars.Image = ConfigureMyAuto.Properties.Resources.Mercedes;
            if (rbMercedes.Enabled == true)
            {
                tbPrice.Text = CarPrice.ToString();
            }

        }

        private void rbBMW_CheckedChanged(object sender, EventArgs e)
        {
            CarPrice = 70000;
            pbCars.Image = ConfigureMyAuto.Properties.Resources.BMW;
            if (rbBMW.Enabled == true)
            {
                tbPrice.Text = CarPrice.ToString();
            }
        }

        private void cbCard_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCard.Checked)
            {
                cbCheck.Checked = false;
                cbCash.Checked = false;

            }
        }

        private void cbCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCheck.Checked)
            {
                cbCard.Checked = false;
                cbCash.Checked = false;
            }
        }

        private void cbCash_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCash.Checked)
            {
                cbCheck.Checked = false;
                cbCard.Checked = false;
            }
            if (cbCash.Checked)
            {
                CashDiscount += 5;
            }
            else
            {
                CashDiscount -= 5;
            }
        }
        private void ExtrasDiscount()
        {
            if (cbABS.Checked && cbChains.Checked && cbFogLights.Checked)
            {
                AllExtrasDiscount += 10;
            }
            else
            {
                AllExtrasDiscount = 0;
            }
        }
        private void cbABS_CheckedChanged(object sender, EventArgs e)
        {
            ExtrasDiscount();
            if (cbABS.Checked)
            {
                ExtrasPrice += 2500;
            }
            else
            {
                ExtrasPrice -= 2500;
            }
        }

        private void cbFogLights_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFogLights.Checked)
            {
                ExtrasPrice += 500;
            }
            else
            {
                ExtrasPrice -= 500;
            }
            ExtrasDiscount();
        }

        private void cbChains_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChains.Checked)
            {
                ExtrasPrice += 50;
            }
            else
            {
                ExtrasPrice -= 50;
            }
            ExtrasDiscount();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Discount = AllExtrasDiscount + CashDiscount;
            TotalPrice = (ExtrasPrice + CarPrice) - (ExtrasPrice + CarPrice) * Discount / 100;
            tbPrice.Text = (ExtrasPrice + CarPrice).ToString();
            tBDisc.Text = Discount.ToString();
            tbTotalPrice.Text = TotalPrice.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbTotalPrice.Clear();
            tbPrice.Clear();
            tBDisc.Clear();
        }

       
    }
}

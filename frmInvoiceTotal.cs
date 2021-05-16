/*
 Terry Dennison 
 January 2021
 Invoice Total Applicaion to calcualte the amount, determine the discount amount, and calculate the total after discount
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

namespace InvoiceTotalNS
{
    public partial class frmInvoiceTotal2fClass : Form
	{
		public frmInvoiceTotal2fClass()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
            //Changes entered value from string to decimal variable
            decimal invoiceSubtotal = Convert.ToDecimal(txtSubtotal.Text);

            decimal discountPercent = 0m;
            if (invoiceSubtotal >= 500)
            {
                //20% discount for orders 500 or less
                discountPercent = .2m;
            }
            else if (invoiceSubtotal >= 250 && invoiceSubtotal < 500)
            {
                //15% discount for orders between 250 and 499
                discountPercent = .15m;
            }
            else if (invoiceSubtotal >= 100 && invoiceSubtotal < 250)
            {
                //10% discount for orders between 100 and 249
                discountPercent = .1m;
            }

            //calcualtes the discount amount and total
            decimal discountAmount = invoiceSubtotal * discountPercent;
            decimal invoiceTotal = invoiceSubtotal - discountAmount;

            //converts formats of numbers and currency
            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtSubtotal.Focus();


        }

        private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

    }
}
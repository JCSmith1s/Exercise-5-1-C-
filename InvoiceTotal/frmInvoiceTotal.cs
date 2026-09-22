namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text.ToUpper();
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPct = 0m;

            if (customerType == "R")
            {
                if (subtotal < 100)
                    discountPct = .0m;
                else if (subtotal >= 100 && subtotal < 250)
                    discountPct = .1m;
                else if (subtotal >= 250 && subtotal < 500)
                    discountPct = .25m;
                else if (subtotal >= 500)
                    discountPct = .3m;
            }
            else if (customerType == "C")
            {
                discountPct = .2m;
            }
            else if (customerType == "T")
            { if (subtotal < 500)
                    discountPct = .4m;
                else if (subtotal >= 500)
                    discountPct = .5m;
            }
            else
            {
                discountPct = .1m;
            }

            decimal discountAmt = subtotal * discountPct;
            decimal invoiceTotal = subtotal - discountAmt;

            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
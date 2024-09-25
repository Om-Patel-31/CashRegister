using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        int numOfCandles = 0;
        int numOfCream = 0;
        int numOfSoap = 0;
        double priceOfCandles = 27.50;
        double priceOfCream = 18.50;
        double priceOfSoap = 8.95;
        int itemsPurchased = 0;
        double subtotal = 0;
        double tax = 0.13;
        double taxAmount = 0;
        double total = 0;
        double change = 0;
        double amountTendered = 0;
        string receiptTitle = "&";
        double totalPriceOfCandles = 0;
        double totalPriceOfCream = 0;
        double totalPriceOfSoap = 0;
        SoundPlayer cr_printing = new SoundPlayer(Properties.Resources.cash_register_printing);
        SoundPlayer cr_printing_end = new SoundPlayer(Properties.Resources.receiptover);

        public Form1()
        {
            InitializeComponent();  
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfCandles = Convert.ToInt32(candlesInput.Text);
                numOfCream = Convert.ToInt32(creamInput.Text);
                numOfSoap = Convert.ToInt32(soapInput.Text);

                itemsPurchased = numOfCandles + numOfCream + numOfSoap;

                subtotal = Convert.ToDouble((priceOfCandles * numOfCandles) + (priceOfCream * numOfCream) + (priceOfSoap * numOfSoap));
                taxAmount = subtotal * tax;
                total = subtotal + taxAmount;

                subtotalOutputLabel.Text = $"{subtotal.ToString("C")}";
                taxOutputLabel.Text = $"{taxAmount.ToString("C")}";
                totalOutputLabel.Text = $"{total.ToString("C")}";

                changeButton.Enabled = true;
            }
            catch
            {
                outputLabel.Text = $"\n\n\n\n\n\n\n           INVALID INPUT!";
                subtotalOutputLabel.Text = $"";
                taxOutputLabel.Text = $"";
                totalOutputLabel.Text = $"";

                if (numOfCandles.GetType() != typeof(Int32))
                {
                    outputLabel.Text += $"\n\n\n\n\n\n\n           INVALID INPUT! AMOUNT OF CANDLES ARE NOT A VALID NUMBER!";
                }
                else if (numOfCream.GetType() != typeof(Int32))
                {
                    outputLabel.Text += $"\n\n\n\n\n\n\n           INVALID INPUT! AMOUNT OF CREAM IS NOT A VALID NUMBER!";
                }
                else if (numOfSoap.GetType() != typeof(Int32))
                {
                    outputLabel.Text += $"\n\n\n\n\n\n\n           INVALID INPUT! AMOUNT OF SOAP IS NOT A VALID NUMBER!";
                }
                else
                {
                    outputLabel.Text += $"";
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                amountTendered = Convert.ToDouble(amountInput.Text);
                change = amountTendered - total;

                changeOutputLabel.Text = $"{change.ToString("C")}";

                outputLabelTitle.Text = "";
                outputLabelTitle2.Text = "";
                outputLabelTitle3.Text = "";

                recieptButton.Enabled = true;
            }
            catch
            {
                changeOutputLabel.Text = $"";
            }
            if (amountTendered < total)
            {
                outputLabel.TextAlign = ContentAlignment.TopCenter;
                outputLabel.Text = "\n\n\n\n\n\n\nPAY THE CORRECT AMOUNT! THE AMOUNT YOU HAVE IS LESS THAN THE TOTAL AMOUNT";
                changeOutputLabel.Text = "";
                recieptButton.Enabled = false;
            }
            if (amountTendered > total)
            {
                outputLabel.Text = "";
            }
        }

        private void recieptButton_Click(object sender, EventArgs e)
        {
            totalPriceOfCandles = priceOfCandles * numOfCandles;
            totalPriceOfCream = priceOfCream * numOfCream;
            totalPriceOfSoap = priceOfSoap * numOfSoap;

            outputLabelTitle.Text = $"Bath";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabelTitle2.Text = $"{receiptTitle}&Body";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabelTitle3.Text = $"Works®️";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabel.Text = $"\n\n\n\n\n\n\n";
            Refresh();
            Thread.Sleep(1000);
            outputLabel.Text += $"      1067 Ontario St, \n       " +
                $"   Stratford, \n   " +
                $"    ON N5A 6W6\n\n";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabel.Text += $"    {DateTime.Now.ToShortDateString()}        {DateTime.Now.ToString("t")}";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabel.Text += $"\n\n3_WICK_CANDLES @{numOfCandles}    {totalPriceOfCandles.ToString("C")}";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabel.Text += $"\nBODY_CREAM     @{numOfCream}    {totalPriceOfCream.ToString("C")}";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabel.Text += $"\nHAND_SOAP      @{numOfSoap}    {totalPriceOfSoap.ToString("C")}";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabel.Text += $"\n\nSUBTOTAL             {subtotal.ToString("C")}";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabel.Text += $"\nHST                  {taxAmount.ToString("C")}";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabel.Text += $"\n\nTOTAL                {total.ToString("C")}";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabel.Text += $"\n\nCHANGE               {change.ToString("C")}";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            outputLabel.Text += $"\n\n     HAVE A FANTASTIC DAY!";
            cr_printing.Play();
            Refresh();
            Thread.Sleep(2000);
            cr_printing.Play();
            neworderButton.Enabled = true;
        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            cr_printing_end.Play();
            Thread.Sleep(2000);
            candlesInput.Text = "";
            creamInput.Text = "";
            soapInput.Text = "";
            subtotalOutputLabel.Text = "";
            taxOutputLabel.Text = "";
            totalOutputLabel.Text = "";
            amountInput.Text = "";
            changeOutputLabel.Text = "";
            outputLabel.Text = "";
            outputLabelTitle.Text = "";
            outputLabelTitle2.Text = "";
            outputLabelTitle3.Text = "";
        }
    }
}

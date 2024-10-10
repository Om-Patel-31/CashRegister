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
        // Variables to store item quantities and prices
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

        // Sound players for receipt printing sound effects
        SoundPlayer cr_printing = new SoundPlayer(Properties.Resources.cash_register_printing);
        SoundPlayer cr_printing_end = new SoundPlayer(Properties.Resources.receiptover);

        // Constructor initializing form components
        public Form1()
        {
            InitializeComponent();
        }

        // Calculates the subtotal, tax, and total when the "Calculate" button is clicked
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Converting input quantities and calculating the total number of items purchased
                numOfCandles = Convert.ToInt32(candlesInput.Text);
                numOfCream = Convert.ToInt32(creamInput.Text);
                numOfSoap = Convert.ToInt32(soapInput.Text);
                itemsPurchased = numOfCandles + numOfCream + numOfSoap;

                // Calculating subtotal, tax, and total
                subtotal = Convert.ToDouble((priceOfCandles * numOfCandles) + (priceOfCream * numOfCream) + (priceOfSoap * numOfSoap));
                taxAmount = subtotal * tax;
                total = subtotal + taxAmount;

                // Displaying results on labels
                subtotalOutputLabel.Text = $"{subtotal.ToString("C")}";
                taxOutputLabel.Text = $"{taxAmount.ToString("C")}";
                totalOutputLabel.Text = $"{total.ToString("C")}";

                // Enabling change calculation and clearing the output label
                changeButton.Enabled = true;
                outputLabel.Text = "";
            }
            catch
            {
                // Handling invalid input and displaying error messages
                outputLabel.Text = $"\n\n\n\n\n\n\n           INVALID INPUT!";
                subtotalOutputLabel.Text = $"";
                taxOutputLabel.Text = $"";
                totalOutputLabel.Text = $"";
                // Additional error messages based on specific input errors
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
            }
        }

        // Calculates change when the "Change" button is clicked
        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Converting amount tendered and calculating change
                amountTendered = Convert.ToDouble(amountInput.Text);
                change = amountTendered - total;

                // Displaying the calculated change
                changeOutputLabel.Text = $"{change.ToString("C")}";

                // Enabling receipt generation
                recieptButton.Enabled = true;
            }
            catch
            {
                // Handling invalid input for amount tendered
                changeOutputLabel.Text = $"";
            }

            // Validating if the amount tendered is less than the total and displaying a warning
            if (amountTendered < total)
            {
                outputLabel.TextAlign = ContentAlignment.TopCenter;
                outputLabel.Text = "\n\n\n\n\n\n\nPAY THE CORRECT AMOUNT! THE AMOUNT YOU HAVE IS LESS THAN THE TOTAL AMOUNT";
                changeOutputLabel.Text = "";
                recieptButton.Enabled = false;
            }
            // Clear any warning messages if the correct amount is entered
            if (amountTendered > total)
            {
                outputLabel.Text = "";
            }
        }

        // Generates a receipt when the "Receipt" button is clicked
        private void recieptButton_Click(object sender, EventArgs e)
        {
            // Calculating the total price for each item
            totalPriceOfCandles = priceOfCandles * numOfCandles;
            totalPriceOfCream = priceOfCream * numOfCream;
            totalPriceOfSoap = priceOfSoap * numOfSoap;

            // Various receipt formats based on which items are purchased
            // Plays receipt printing sound and displays receipt details in steps
            if (numOfCandles > 0 && numOfCream > 0 && numOfSoap > 0)
            {
                outputLabelTitle.Text = $"Bath";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabelTitle2.Text = $"{receiptTitle}&Body";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabelTitle3.Text = $"Works®️";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text = $"\n\n\n\n\n\n\n";
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"      1067 Ontario St, \n       " +
                    $"   Stratford, \n   " +
                    $"    ON N5A 6W6\n\n";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"    {DateTime.Now.ToShortDateString()}        {DateTime.Now.ToString("t")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\n\n3_WICK_CANDLES @{numOfCandles}    {totalPriceOfCandles.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\nBODY_CREAM     @{numOfCream}    {totalPriceOfCream.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\nHAND_SOAP      @{numOfSoap}    {totalPriceOfSoap.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\n\nSUBTOTAL             {subtotal.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\nHST                  {taxAmount.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\n\nTOTAL                {total.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\n\nCHANGE               {change.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\n\n     HAVE A FANTASTIC DAY!";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                cr_printing.Play();
                neworderButton.Enabled = true;
            }

            // Case: Both candles and cream are purchased, but no soap
            else if (numOfCandles > 0 && numOfCream > 0 && numOfSoap == 0)
            {
                // Display receipt title with a "Bath" store theme
                outputLabelTitle.Text = $"Bath";
                cr_printing.Play();  // Play a sound to simulate printing
                Refresh();
                Thread.Sleep(1000);  // Delay to simulate printing time

                // Continue printing the second part of the store name
                outputLabelTitle2.Text = $"{receiptTitle}&Body";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Final part of the store name
                outputLabelTitle3.Text = $"Works®️";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Clear space for printing receipt body
                outputLabel.Text = $"\n\n\n\n\n\n\n";
                Refresh();
                Thread.Sleep(1000);

                // Print store address
                outputLabel.Text += $"      1067 Ontario St, \n       Stratford, \n   ON N5A 6W6\n\n";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print date and time of purchase
                outputLabel.Text += $"    {DateTime.Now.ToShortDateString()}        {DateTime.Now.ToString("t")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print purchased items (candles and cream)
                outputLabel.Text += $"\n\n3_WICK_CANDLES @{numOfCandles}    {totalPriceOfCandles.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\nBODY_CREAM     @{numOfCream}    {totalPriceOfCream.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print subtotal and tax details
                outputLabel.Text += $"\n\nSUBTOTAL             {subtotal.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\nHST                  {taxAmount.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print total price and change
                outputLabel.Text += $"\n\nTOTAL                {total.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\n\nCHANGE               {change.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print a thank you message
                outputLabel.Text += $"\n\n     HAVE A FANTASTIC DAY!";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                cr_printing.Play();  // Final print sound
                neworderButton.Enabled = true;  // Enable the "new order" button for next customer
            }

            // Case: Candles and soap are purchased, but no cream
            else if (numOfCandles > 0 && numOfCream == 0 && numOfSoap > 0)
            {
                // Similar sequence of printing receipt for candles and soap
                outputLabelTitle.Text = $"Bath";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabelTitle2.Text = $"{receiptTitle}&Body";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabelTitle3.Text = $"Works®️";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text = $"\n\n\n\n\n\n\n";
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"      1067 Ontario St, \n       Stratford, \n   ON N5A 6W6\n\n";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"    {DateTime.Now.ToShortDateString()}        {DateTime.Now.ToString("t")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print candle and soap items
                outputLabel.Text += $"\n\n3_WICK_CANDLES @{numOfCandles}    {totalPriceOfCandles.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\nHAND_SOAP      @{numOfSoap}    {totalPriceOfSoap.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print subtotal, tax, total, and change
                outputLabel.Text += $"\n\nSUBTOTAL             {subtotal.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\nHST                  {taxAmount.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"\n\nTOTAL                {total.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\n\nCHANGE               {change.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"\n\n     HAVE A FANTASTIC DAY!";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                cr_printing.Play();
                neworderButton.Enabled = true;
            }

            // Case: Cream and soap are purchased, but no candles
            else if (numOfCandles == 0 && numOfCream > 0 && numOfSoap > 0)
            {
                // Similar sequence of printing receipt for cream and soap
                outputLabelTitle.Text = $"Bath";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabelTitle2.Text = $"{receiptTitle}&Body";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabelTitle3.Text = $"Works®️";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text = $"\n\n\n\n\n\n\n";
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"      1067 Ontario St, \n       Stratford, \n   ON N5A 6W6\n\n";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"    {DateTime.Now.ToShortDateString()}        {DateTime.Now.ToString("t")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print cream and soap items
                outputLabel.Text += $"\nBODY_CREAM     @{numOfCream}    {totalPriceOfCream.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\nHAND_SOAP      @{numOfSoap}    {totalPriceOfSoap.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print subtotal, tax, total, and change
                outputLabel.Text += $"\n\nSUBTOTAL             {subtotal.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\nHST                  {taxAmount.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"\n\nTOTAL                {total.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\n\nCHANGE               {change.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"\n\n     HAVE A FANTASTIC DAY!";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                cr_printing.Play();
                neworderButton.Enabled = true;
            }
            // Case: Only candles are purchased, no cream or soap
            else if (numOfCandles > 0 && numOfCream == 0 && numOfSoap == 0)
            {
                // Similar sequence of printing receipt for candles
                outputLabelTitle.Text = $"Bath";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabelTitle2.Text = $"{receiptTitle}&Body";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabelTitle3.Text = $"Works®️";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text = $"\n\n\n\n\n\n\n";
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"      1067 Ontario St, \n       Stratford, \n   ON N5A 6W6\n\n";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"    {DateTime.Now.ToShortDateString()}        {DateTime.Now.ToString("t")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print only the candle item
                outputLabel.Text += $"\n3_WICK_CANDLES @{numOfCandles}    {totalPriceOfCandles.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                // Print subtotal, tax, total, and change
                outputLabel.Text += $"\n\nSUBTOTAL             {subtotal.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\nHST                  {taxAmount.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"\n\nTOTAL                {total.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                outputLabel.Text += $"\n\nCHANGE               {change.ToString("C")}";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);

                outputLabel.Text += $"\n\n     HAVE A FANTASTIC DAY!";
                cr_printing.Play();
                Refresh();
                Thread.Sleep(1000);
                cr_printing.Play();
                neworderButton.Enabled = true;
            }
        }
    }
}

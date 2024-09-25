namespace CashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titlelogo = new System.Windows.Forms.Label();
            this.titlestripe = new System.Windows.Forms.Label();
            this.candlesLabel = new System.Windows.Forms.Label();
            this.creamLabel = new System.Windows.Forms.Label();
            this.soapLabel = new System.Windows.Forms.Label();
            this.candlesInput = new System.Windows.Forms.TextBox();
            this.creamInput = new System.Windows.Forms.TextBox();
            this.soapInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.neworderButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subtotalButton = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.subtotalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutputLabel = new System.Windows.Forms.Label();
            this.recieptButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.outputLabelTitle3 = new System.Windows.Forms.Label();
            this.outputLabelTitle2 = new System.Windows.Forms.Label();
            this.outputLabelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelogo
            // 
            this.titlelogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titlelogo.Font = new System.Drawing.Font("Courier New", 13F);
            this.titlelogo.Image = global::CashRegister.Properties.Resources.bathandbodyworkslogo_removebg_preview_copy;
            this.titlelogo.Location = new System.Drawing.Point(559, 9);
            this.titlelogo.Name = "titlelogo";
            this.titlelogo.Size = new System.Drawing.Size(195, 179);
            this.titlelogo.TabIndex = 1;
            // 
            // titlestripe
            // 
            this.titlestripe.Image = global::CashRegister.Properties.Resources.bluecheckssmall__1___1_;
            this.titlestripe.Location = new System.Drawing.Point(-41, -34);
            this.titlestripe.Name = "titlestripe";
            this.titlestripe.Size = new System.Drawing.Size(1479, 232);
            this.titlestripe.TabIndex = 0;
            // 
            // candlesLabel
            // 
            this.candlesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.candlesLabel.ForeColor = System.Drawing.Color.White;
            this.candlesLabel.Location = new System.Drawing.Point(17, 259);
            this.candlesLabel.Name = "candlesLabel";
            this.candlesLabel.Size = new System.Drawing.Size(346, 29);
            this.candlesLabel.TabIndex = 4;
            this.candlesLabel.Text = "Number of 3-Wick Candles";
            // 
            // creamLabel
            // 
            this.creamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.creamLabel.ForeColor = System.Drawing.Color.White;
            this.creamLabel.Location = new System.Drawing.Point(17, 313);
            this.creamLabel.Name = "creamLabel";
            this.creamLabel.Size = new System.Drawing.Size(323, 29);
            this.creamLabel.TabIndex = 5;
            this.creamLabel.Text = "Number of Body Cream";
            // 
            // soapLabel
            // 
            this.soapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.soapLabel.ForeColor = System.Drawing.Color.White;
            this.soapLabel.Location = new System.Drawing.Point(17, 370);
            this.soapLabel.Name = "soapLabel";
            this.soapLabel.Size = new System.Drawing.Size(323, 29);
            this.soapLabel.TabIndex = 6;
            this.soapLabel.Text = "Number of Hand Soap";
            // 
            // candlesInput
            // 
            this.candlesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.candlesInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.candlesInput.Location = new System.Drawing.Point(383, 257);
            this.candlesInput.Name = "candlesInput";
            this.candlesInput.Size = new System.Drawing.Size(49, 30);
            this.candlesInput.TabIndex = 7;
            // 
            // creamInput
            // 
            this.creamInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.creamInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.creamInput.Location = new System.Drawing.Point(383, 311);
            this.creamInput.Name = "creamInput";
            this.creamInput.Size = new System.Drawing.Size(49, 30);
            this.creamInput.TabIndex = 8;
            // 
            // soapInput
            // 
            this.soapInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.soapInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.soapInput.Location = new System.Drawing.Point(383, 368);
            this.soapInput.Name = "soapInput";
            this.soapInput.Size = new System.Drawing.Size(49, 30);
            this.soapInput.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(145, 420);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(170, 36);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // neworderButton
            // 
            this.neworderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.neworderButton.Enabled = false;
            this.neworderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.neworderButton.ForeColor = System.Drawing.Color.White;
            this.neworderButton.Location = new System.Drawing.Point(1029, 757);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(140, 45);
            this.neworderButton.TabIndex = 11;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = false;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(17, 585);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(64, 26);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.taxLabel.ForeColor = System.Drawing.Color.White;
            this.taxLabel.Location = new System.Drawing.Point(17, 529);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(50, 26);
            this.taxLabel.TabIndex = 13;
            this.taxLabel.Text = "Tax";
            // 
            // subtotalButton
            // 
            this.subtotalButton.AutoSize = true;
            this.subtotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.subtotalButton.ForeColor = System.Drawing.Color.White;
            this.subtotalButton.Location = new System.Drawing.Point(17, 475);
            this.subtotalButton.Name = "subtotalButton";
            this.subtotalButton.Size = new System.Drawing.Size(100, 26);
            this.subtotalButton.TabIndex = 12;
            this.subtotalButton.Text = "Subtotal";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.amountLabel.ForeColor = System.Drawing.Color.White;
            this.amountLabel.Location = new System.Drawing.Point(17, 635);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(200, 26);
            this.amountLabel.TabIndex = 16;
            this.amountLabel.Text = "Amount Tendered";
            // 
            // amountInput
            // 
            this.amountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.amountInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.amountInput.Location = new System.Drawing.Point(383, 631);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(102, 30);
            this.amountInput.TabIndex = 17;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(130, 680);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(246, 36);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(410, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(667, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 20;
            // 
            // subtotalOutputLabel
            // 
            this.subtotalOutputLabel.Font = new System.Drawing.Font("Courier New", 13F);
            this.subtotalOutputLabel.ForeColor = System.Drawing.Color.White;
            this.subtotalOutputLabel.Location = new System.Drawing.Point(214, 475);
            this.subtotalOutputLabel.Name = "subtotalOutputLabel";
            this.subtotalOutputLabel.Size = new System.Drawing.Size(278, 29);
            this.subtotalOutputLabel.TabIndex = 21;
            this.subtotalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.Font = new System.Drawing.Font("Courier New", 13F);
            this.taxOutputLabel.ForeColor = System.Drawing.Color.White;
            this.taxOutputLabel.Location = new System.Drawing.Point(214, 529);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(278, 29);
            this.taxOutputLabel.TabIndex = 22;
            this.taxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.Font = new System.Drawing.Font("Courier New", 13F);
            this.totalOutputLabel.ForeColor = System.Drawing.Color.White;
            this.totalOutputLabel.Location = new System.Drawing.Point(214, 586);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(278, 29);
            this.totalOutputLabel.TabIndex = 23;
            this.totalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(17, 734);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(94, 26);
            this.changeLabel.TabIndex = 24;
            this.changeLabel.Text = "Change";
            // 
            // changeOutputLabel
            // 
            this.changeOutputLabel.Font = new System.Drawing.Font("Courier New", 13F);
            this.changeOutputLabel.ForeColor = System.Drawing.Color.White;
            this.changeOutputLabel.Location = new System.Drawing.Point(371, 735);
            this.changeOutputLabel.Name = "changeOutputLabel";
            this.changeOutputLabel.Size = new System.Drawing.Size(114, 29);
            this.changeOutputLabel.TabIndex = 25;
            this.changeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recieptButton
            // 
            this.recieptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.recieptButton.Enabled = false;
            this.recieptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.recieptButton.ForeColor = System.Drawing.Color.White;
            this.recieptButton.Location = new System.Drawing.Point(172, 771);
            this.recieptButton.Name = "recieptButton";
            this.recieptButton.Size = new System.Drawing.Size(168, 36);
            this.recieptButton.TabIndex = 26;
            this.recieptButton.Text = "Print Reciept";
            this.recieptButton.UseVisualStyleBackColor = false;
            this.recieptButton.Click += new System.EventHandler(this.recieptButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 12F);
            this.outputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.outputLabel.Location = new System.Drawing.Point(538, 206);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(485, 601);
            this.outputLabel.TabIndex = 28;
            // 
            // xLabel
            // 
            this.xLabel.BackColor = System.Drawing.Color.White;
            this.xLabel.Font = new System.Drawing.Font("Helvetica Light", 18F);
            this.xLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.xLabel.Location = new System.Drawing.Point(657, 206);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(185, 55);
            this.xLabel.TabIndex = 29;
            this.xLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel
            // 
            this.yLabel.BackColor = System.Drawing.Color.White;
            this.yLabel.Font = new System.Drawing.Font("Helvetica Light", 14F);
            this.yLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.yLabel.Location = new System.Drawing.Point(670, 241);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(177, 55);
            this.yLabel.TabIndex = 30;
            this.yLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabelTitle3
            // 
            this.outputLabelTitle3.BackColor = System.Drawing.Color.White;
            this.outputLabelTitle3.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabelTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.outputLabelTitle3.Location = new System.Drawing.Point(684, 286);
            this.outputLabelTitle3.Name = "outputLabelTitle3";
            this.outputLabelTitle3.Size = new System.Drawing.Size(177, 55);
            this.outputLabelTitle3.TabIndex = 31;
            this.outputLabelTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabelTitle2
            // 
            this.outputLabelTitle2.BackColor = System.Drawing.Color.White;
            this.outputLabelTitle2.Font = new System.Drawing.Font("Helvetica Light", 16F);
            this.outputLabelTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.outputLabelTitle2.Location = new System.Drawing.Point(673, 245);
            this.outputLabelTitle2.Name = "outputLabelTitle2";
            this.outputLabelTitle2.Size = new System.Drawing.Size(177, 55);
            this.outputLabelTitle2.TabIndex = 32;
            this.outputLabelTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabelTitle
            // 
            this.outputLabelTitle.BackColor = System.Drawing.Color.White;
            this.outputLabelTitle.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(1)))), ((int)(((byte)(141)))));
            this.outputLabelTitle.Location = new System.Drawing.Point(657, 206);
            this.outputLabelTitle.Name = "outputLabelTitle";
            this.outputLabelTitle.Size = new System.Drawing.Size(185, 55);
            this.outputLabelTitle.TabIndex = 33;
            this.outputLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1174, 814);
            this.Controls.Add(this.outputLabelTitle);
            this.Controls.Add(this.outputLabelTitle2);
            this.Controls.Add(this.outputLabelTitle3);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.recieptButton);
            this.Controls.Add(this.changeOutputLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.subtotalOutputLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalButton);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.soapInput);
            this.Controls.Add(this.creamInput);
            this.Controls.Add(this.candlesInput);
            this.Controls.Add(this.soapLabel);
            this.Controls.Add(this.creamLabel);
            this.Controls.Add(this.candlesLabel);
            this.Controls.Add(this.titlelogo);
            this.Controls.Add(this.titlestripe);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bath&Body Works";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlestripe;
        private System.Windows.Forms.Label titlelogo;
        private System.Windows.Forms.Label candlesLabel;
        private System.Windows.Forms.Label creamLabel;
        private System.Windows.Forms.Label soapLabel;
        private System.Windows.Forms.TextBox candlesInput;
        private System.Windows.Forms.TextBox creamInput;
        private System.Windows.Forms.TextBox soapInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subtotalButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label subtotalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutputLabel;
        private System.Windows.Forms.Button recieptButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label outputLabelTitle3;
        private System.Windows.Forms.Label outputLabelTitle2;
        private System.Windows.Forms.Label outputLabelTitle;
    }
}


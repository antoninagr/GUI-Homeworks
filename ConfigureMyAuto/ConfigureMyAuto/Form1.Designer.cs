namespace ConfigureMyAuto
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
            this.rbAudi = new System.Windows.Forms.RadioButton();
            this.rbMercedes = new System.Windows.Forms.RadioButton();
            this.rbBMW = new System.Windows.Forms.RadioButton();
            this.pbCars = new System.Windows.Forms.PictureBox();
            this.cbABS = new System.Windows.Forms.CheckBox();
            this.cbFogLights = new System.Windows.Forms.CheckBox();
            this.cbChains = new System.Windows.Forms.CheckBox();
            this.cbCard = new System.Windows.Forms.CheckBox();
            this.cbCheck = new System.Windows.Forms.CheckBox();
            this.cbCash = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.tBDisc = new System.Windows.Forms.TextBox();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCars)).BeginInit();
            this.SuspendLayout();
            // 
            // rbAudi
            // 
            this.rbAudi.AutoSize = true;
            this.rbAudi.Location = new System.Drawing.Point(12, 12);
            this.rbAudi.Name = "rbAudi";
            this.rbAudi.Size = new System.Drawing.Size(46, 17);
            this.rbAudi.TabIndex = 0;
            this.rbAudi.TabStop = true;
            this.rbAudi.Text = "Audi";
            this.rbAudi.UseVisualStyleBackColor = true;
            this.rbAudi.CheckedChanged += new System.EventHandler(this.rbAudi_CheckedChanged);
            // 
            // rbMercedes
            // 
            this.rbMercedes.AutoSize = true;
            this.rbMercedes.Location = new System.Drawing.Point(12, 35);
            this.rbMercedes.Name = "rbMercedes";
            this.rbMercedes.Size = new System.Drawing.Size(72, 17);
            this.rbMercedes.TabIndex = 1;
            this.rbMercedes.TabStop = true;
            this.rbMercedes.Text = "Mercedes";
            this.rbMercedes.UseVisualStyleBackColor = true;
            this.rbMercedes.CheckedChanged += new System.EventHandler(this.rbMercedes_CheckedChanged);
            // 
            // rbBMW
            // 
            this.rbBMW.AutoSize = true;
            this.rbBMW.Location = new System.Drawing.Point(12, 58);
            this.rbBMW.Name = "rbBMW";
            this.rbBMW.Size = new System.Drawing.Size(52, 17);
            this.rbBMW.TabIndex = 2;
            this.rbBMW.TabStop = true;
            this.rbBMW.Text = "BMW";
            this.rbBMW.UseVisualStyleBackColor = true;
            this.rbBMW.CheckedChanged += new System.EventHandler(this.rbBMW_CheckedChanged);
            // 
            // pbCars
            // 
            this.pbCars.Image = global::ConfigureMyAuto.Properties.Resources.Mercedes;
            this.pbCars.Location = new System.Drawing.Point(213, 12);
            this.pbCars.Name = "pbCars";
            this.pbCars.Size = new System.Drawing.Size(274, 173);
            this.pbCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCars.TabIndex = 3;
            this.pbCars.TabStop = false;
            // 
            // cbABS
            // 
            this.cbABS.AutoSize = true;
            this.cbABS.Location = new System.Drawing.Point(12, 168);
            this.cbABS.Name = "cbABS";
            this.cbABS.Size = new System.Drawing.Size(47, 17);
            this.cbABS.TabIndex = 4;
            this.cbABS.Text = "ABS";
            this.cbABS.UseVisualStyleBackColor = true;
            this.cbABS.CheckedChanged += new System.EventHandler(this.cbABS_CheckedChanged);
            // 
            // cbFogLights
            // 
            this.cbFogLights.AutoSize = true;
            this.cbFogLights.Location = new System.Drawing.Point(12, 192);
            this.cbFogLights.Name = "cbFogLights";
            this.cbFogLights.Size = new System.Drawing.Size(110, 17);
            this.cbFogLights.TabIndex = 5;
            this.cbFogLights.Text = "Extra lights for fog";
            this.cbFogLights.UseVisualStyleBackColor = true;
            this.cbFogLights.CheckedChanged += new System.EventHandler(this.cbFogLights_CheckedChanged);
            // 
            // cbChains
            // 
            this.cbChains.AutoSize = true;
            this.cbChains.Location = new System.Drawing.Point(12, 215);
            this.cbChains.Name = "cbChains";
            this.cbChains.Size = new System.Drawing.Size(58, 17);
            this.cbChains.TabIndex = 6;
            this.cbChains.Text = "Chains";
            this.cbChains.UseVisualStyleBackColor = true;
            this.cbChains.CheckedChanged += new System.EventHandler(this.cbChains_CheckedChanged);
            // 
            // cbCard
            // 
            this.cbCard.AutoSize = true;
            this.cbCard.Location = new System.Drawing.Point(185, 207);
            this.cbCard.Name = "cbCard";
            this.cbCard.Size = new System.Drawing.Size(78, 17);
            this.cbCard.TabIndex = 7;
            this.cbCard.Text = "Credit Card";
            this.cbCard.UseVisualStyleBackColor = true;
            this.cbCard.CheckedChanged += new System.EventHandler(this.cbCard_CheckedChanged);
            // 
            // cbCheck
            // 
            this.cbCheck.AutoSize = true;
            this.cbCheck.Location = new System.Drawing.Point(185, 230);
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Size = new System.Drawing.Size(57, 17);
            this.cbCheck.TabIndex = 8;
            this.cbCheck.Text = "Check";
            this.cbCheck.UseVisualStyleBackColor = true;
            this.cbCheck.CheckedChanged += new System.EventHandler(this.cbCheck_CheckedChanged);
            // 
            // cbCash
            // 
            this.cbCash.AutoSize = true;
            this.cbCash.Location = new System.Drawing.Point(185, 253);
            this.cbCash.Name = "cbCash";
            this.cbCash.Size = new System.Drawing.Size(50, 17);
            this.cbCash.TabIndex = 9;
            this.cbCash.Text = "Cash";
            this.cbCash.UseVisualStyleBackColor = true;
            this.cbCash.CheckedChanged += new System.EventHandler(this.cbCash_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(149, 296);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 38);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(397, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(297, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(394, 211);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 13;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(397, 215);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 14;
            // 
            // tbDiscount
            // 
            this.tbDiscount.BackColor = System.Drawing.SystemColors.Menu;
            this.tbDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDiscount.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscount.Location = new System.Drawing.Point(294, 236);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(83, 26);
            this.tbDiscount.TabIndex = 15;
            this.tbDiscount.Text = "Discount";
            // 
            // tBDisc
            // 
            this.tBDisc.Location = new System.Drawing.Point(397, 241);
            this.tBDisc.Name = "tBDisc";
            this.tBDisc.Size = new System.Drawing.Size(100, 20);
            this.tBDisc.TabIndex = 16;
            // 
            // tbtotal
            // 
            this.tbtotal.BackColor = System.Drawing.SystemColors.Menu;
            this.tbtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbtotal.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.Location = new System.Drawing.Point(294, 267);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(100, 26);
            this.tbtotal.TabIndex = 17;
            this.tbtotal.Text = "Total Price";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(397, 268);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.tbTotalPrice.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 353);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.tBDisc);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cbCash);
            this.Controls.Add(this.cbCheck);
            this.Controls.Add(this.cbCard);
            this.Controls.Add(this.cbChains);
            this.Controls.Add(this.cbFogLights);
            this.Controls.Add(this.cbABS);
            this.Controls.Add(this.pbCars);
            this.Controls.Add(this.rbBMW);
            this.Controls.Add(this.rbMercedes);
            this.Controls.Add(this.rbAudi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAudi;
        private System.Windows.Forms.RadioButton rbMercedes;
        private System.Windows.Forms.RadioButton rbBMW;
        private System.Windows.Forms.PictureBox pbCars;
        private System.Windows.Forms.CheckBox cbABS;
        private System.Windows.Forms.CheckBox cbFogLights;
        private System.Windows.Forms.CheckBox cbChains;
        private System.Windows.Forms.CheckBox cbCard;
        private System.Windows.Forms.CheckBox cbCheck;
        private System.Windows.Forms.CheckBox cbCash;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.TextBox tBDisc;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.TextBox tbTotalPrice;
        
    }
}


namespace PizzaCostMo
{
    partial class frmPizzaCost
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
            this.lblEnterDiameter = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAnswer = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterDiameter
            // 
            this.lblEnterDiameter.AutoSize = true;
            this.lblEnterDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDiameter.Location = new System.Drawing.Point(9, 67);
            this.lblEnterDiameter.Name = "lblEnterDiameter";
            this.lblEnterDiameter.Size = new System.Drawing.Size(417, 25);
            this.lblEnterDiameter.TabIndex = 1;
            this.lblEnterDiameter.Text = "Enter the diameter of the pizza ( in inches)";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(200, 219);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(97, 25);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Subtotal:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(323, 219);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(91, 25);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Subtotal";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(191, 138);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 36);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudDiameter
            // 
            this.nudDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiameter.Location = new System.Drawing.Point(432, 69);
            this.nudDiameter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDiameter.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(107, 26);
            this.nudDiameter.TabIndex = 6;
            this.nudDiameter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(213, 272);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total =";
            // 
            // lblTotalAnswer
            // 
            this.lblTotalAnswer.AutoSize = true;
            this.lblTotalAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAnswer.Location = new System.Drawing.Point(324, 272);
            this.lblTotalAnswer.Name = "lblTotalAnswer";
            this.lblTotalAnswer.Size = new System.Drawing.Size(93, 24);
            this.lblTotalAnswer.TabIndex = 8;
            this.lblTotalAnswer.Text = "Total Cost";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(213, 322);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 25);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "Tax =";
            // 
            // lblTaxAnswer
            // 
            this.lblTaxAnswer.AutoSize = true;
            this.lblTaxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAnswer.Location = new System.Drawing.Point(334, 322);
            this.lblTaxAnswer.Name = "lblTaxAnswer";
            this.lblTaxAnswer.Size = new System.Drawing.Size(54, 25);
            this.lblTaxAnswer.TabIndex = 10;
            this.lblTaxAnswer.Text = "HST";
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 370);
            this.Controls.Add(this.lblTaxAnswer);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotalAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.nudDiameter);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblEnterDiameter);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost Mo";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEnterDiameter;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAnswer;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxAnswer;
    }
}


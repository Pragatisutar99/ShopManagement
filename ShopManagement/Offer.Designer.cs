namespace ShopManagement
{
    partial class Offer
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
            this.lblOfferForm = new System.Windows.Forms.Label();
            this.lblOfferinformation = new System.Windows.Forms.Label();
            this.lblOriginalPriceOf = new System.Windows.Forms.Label();
            this.lblDiscountinPercentage = new System.Windows.Forms.Label();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.btnClaculateNewPrice = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscountinPercentage = new System.Windows.Forms.TextBox();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOfferForm
            // 
            this.lblOfferForm.AutoSize = true;
            this.lblOfferForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferForm.Location = new System.Drawing.Point(536, 34);
            this.lblOfferForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOfferForm.Name = "lblOfferForm";
            this.lblOfferForm.Size = new System.Drawing.Size(115, 25);
            this.lblOfferForm.TabIndex = 0;
            this.lblOfferForm.Text = "Offer Form";
            // 
            // lblOfferinformation
            // 
            this.lblOfferinformation.AutoSize = true;
            this.lblOfferinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferinformation.Location = new System.Drawing.Point(190, 126);
            this.lblOfferinformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOfferinformation.Name = "lblOfferinformation";
            this.lblOfferinformation.Size = new System.Drawing.Size(173, 25);
            this.lblOfferinformation.TabIndex = 1;
            this.lblOfferinformation.Text = "Offer Information";
            // 
            // lblOriginalPriceOf
            // 
            this.lblOriginalPriceOf.AutoSize = true;
            this.lblOriginalPriceOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalPriceOf.Location = new System.Drawing.Point(190, 220);
            this.lblOriginalPriceOf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOriginalPriceOf.Name = "lblOriginalPriceOf";
            this.lblOriginalPriceOf.Size = new System.Drawing.Size(172, 25);
            this.lblOriginalPriceOf.TabIndex = 2;
            this.lblOriginalPriceOf.Text = "Original Price of ";
            this.lblOriginalPriceOf.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDiscountinPercentage
            // 
            this.lblDiscountinPercentage.AutoSize = true;
            this.lblDiscountinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountinPercentage.Location = new System.Drawing.Point(190, 314);
            this.lblDiscountinPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountinPercentage.Name = "lblDiscountinPercentage";
            this.lblDiscountinPercentage.Size = new System.Drawing.Size(235, 25);
            this.lblDiscountinPercentage.TabIndex = 3;
            this.lblDiscountinPercentage.Text = "Discount in Percentage";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPrice.Location = new System.Drawing.Point(190, 431);
            this.lblNewPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(109, 25);
            this.lblNewPrice.TabIndex = 4;
            this.lblNewPrice.Text = "New Price";
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePrice.Location = new System.Drawing.Point(312, 568);
            this.btnUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(152, 35);
            this.btnUpdatePrice.TabIndex = 5;
            this.btnUpdatePrice.Text = "Updated Price";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // btnClaculateNewPrice
            // 
            this.btnClaculateNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaculateNewPrice.Location = new System.Drawing.Point(669, 568);
            this.btnClaculateNewPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClaculateNewPrice.Name = "btnClaculateNewPrice";
            this.btnClaculateNewPrice.Size = new System.Drawing.Size(158, 35);
            this.btnClaculateNewPrice.TabIndex = 6;
            this.btnClaculateNewPrice.Text = "Calculate New Price";
            this.btnClaculateNewPrice.UseVisualStyleBackColor = true;
            this.btnClaculateNewPrice.Click += new System.EventHandler(this.btnClaculateNewPrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(711, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDiscountinPercentage
            // 
            this.txtDiscountinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountinPercentage.Location = new System.Drawing.Point(540, 314);
            this.txtDiscountinPercentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscountinPercentage.Name = "txtDiscountinPercentage";
            this.txtDiscountinPercentage.Size = new System.Drawing.Size(148, 30);
            this.txtDiscountinPercentage.TabIndex = 9;
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPrice.Location = new System.Drawing.Point(540, 420);
            this.txtNewPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(148, 30);
            this.txtNewPrice.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(734, 325);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(734, 431);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Rs";
            // 
            // Offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 752);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.txtDiscountinPercentage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClaculateNewPrice);
            this.Controls.Add(this.btnUpdatePrice);
            this.Controls.Add(this.lblNewPrice);
            this.Controls.Add(this.lblDiscountinPercentage);
            this.Controls.Add(this.lblOriginalPriceOf);
            this.Controls.Add(this.lblOfferinformation);
            this.Controls.Add(this.lblOfferForm);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Offer";
            this.Text = "Offer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOfferForm;
        private System.Windows.Forms.Label lblOfferinformation;
        private System.Windows.Forms.Label lblOriginalPriceOf;
        private System.Windows.Forms.Label lblDiscountinPercentage;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Button btnClaculateNewPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscountinPercentage;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
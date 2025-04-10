namespace TicketVendorMachine
{
    partial class SelectPaymentForm
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFare = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(50, 103);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(113, 103);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.lblFare.Location = new System.Drawing.Point(198, 103);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(28, 13);
            this.lblFare.TabIndex = 2;
            this.lblFare.Text = "Cost";
            this.lblFare.Click += new System.EventHandler(this.lblFare_Click);
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(53, 206);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(168, 21);
            this.cbPaymentMethod.TabIndex = 3;
            this.cbPaymentMethod.Text = "SelectPaymentMethod";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(53, 289);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "button1";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // SelectPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.lblFare);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "SelectPaymentForm";
            this.Text = "SelectPaymentForm";
            this.Load += new System.EventHandler(this.SelectPaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFare;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Button btnPay;
    }
}
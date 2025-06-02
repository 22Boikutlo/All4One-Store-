namespace MyStore
{
    partial class frmDelivery
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.lblOrderDescription = new System.Windows.Forms.Label();
            this.txtDeliveryProdName = new System.Windows.Forms.TextBox();
            this.txtOrderOwner = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(21, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 42);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(252, 352);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(103, 42);
            this.btnDelivery.TabIndex = 24;
            this.btnDelivery.Text = "Confrim Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblOrderPrice.Location = new System.Drawing.Point(18, 175);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(90, 17);
            this.lblOrderPrice.TabIndex = 23;
            this.lblOrderPrice.Text = "Order Owner";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(172, 262);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.ReadOnly = true;
            this.txtDeliveryAddress.Size = new System.Drawing.Size(183, 22);
            this.txtDeliveryAddress.TabIndex = 22;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(172, 214);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.ReadOnly = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(183, 22);
            this.txtDeliveryDate.TabIndex = 21;
            // 
            // lblOrderDescription
            // 
            this.lblOrderDescription.AutoSize = true;
            this.lblOrderDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblOrderDescription.Location = new System.Drawing.Point(18, 267);
            this.lblOrderDescription.Name = "lblOrderDescription";
            this.lblOrderDescription.Size = new System.Drawing.Size(115, 17);
            this.lblOrderDescription.TabIndex = 20;
            this.lblOrderDescription.Text = "Delivery Address";
            // 
            // txtDeliveryProdName
            // 
            this.txtDeliveryProdName.Location = new System.Drawing.Point(172, 124);
            this.txtDeliveryProdName.Name = "txtDeliveryProdName";
            this.txtDeliveryProdName.ReadOnly = true;
            this.txtDeliveryProdName.Size = new System.Drawing.Size(183, 22);
            this.txtDeliveryProdName.TabIndex = 19;
            // 
            // txtOrderOwner
            // 
            this.txtOrderOwner.Location = new System.Drawing.Point(172, 170);
            this.txtOrderOwner.Name = "txtOrderOwner";
            this.txtOrderOwner.ReadOnly = true;
            this.txtOrderOwner.Size = new System.Drawing.Size(183, 22);
            this.txtOrderOwner.TabIndex = 18;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblOrderDate.Location = new System.Drawing.Point(18, 216);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(93, 17);
            this.lblOrderDate.TabIndex = 17;
            this.lblOrderDate.Text = "Delivery Date";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblProductName.Location = new System.Drawing.Point(18, 126);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 17);
            this.lblProductName.TabIndex = 16;
            this.lblProductName.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Delivery Summary";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(172, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(183, 22);
            this.txtUserName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome ";
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 423);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.txtDeliveryAddress);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.lblOrderDescription);
            this.Controls.Add(this.txtDeliveryProdName);
            this.Controls.Add(this.txtOrderOwner);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "frmDelivery";
            this.Text = "Delivery Information";
            this.Load += new System.EventHandler(this.frmDelivery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.Label lblOrderDescription;
        private System.Windows.Forms.TextBox txtDeliveryProdName;
        private System.Windows.Forms.TextBox txtOrderOwner;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
    }
}
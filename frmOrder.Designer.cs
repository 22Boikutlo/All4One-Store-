namespace MyStore
{
    partial class frmOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblOrderDescription = new System.Windows.Forms.Label();
            this.txtOrderDescription = new System.Windows.Forms.TextBox();
            this.txtOrderProductName = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(168, 75);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(183, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Summary";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblProductName.Location = new System.Drawing.Point(14, 120);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 17);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name";
            // 
            // lblOrderDescription
            // 
            this.lblOrderDescription.AutoSize = true;
            this.lblOrderDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblOrderDescription.Location = new System.Drawing.Point(14, 165);
            this.lblOrderDescription.Name = "lblOrderDescription";
            this.lblOrderDescription.Size = new System.Drawing.Size(120, 17);
            this.lblOrderDescription.TabIndex = 4;
            this.lblOrderDescription.Text = "Order Description";
            // 
            // txtOrderDescription
            // 
            this.txtOrderDescription.Location = new System.Drawing.Point(168, 165);
            this.txtOrderDescription.Name = "txtOrderDescription";
            this.txtOrderDescription.ReadOnly = true;
            this.txtOrderDescription.Size = new System.Drawing.Size(183, 22);
            this.txtOrderDescription.TabIndex = 5;
            // 
            // txtOrderProductName
            // 
            this.txtOrderProductName.Location = new System.Drawing.Point(168, 120);
            this.txtOrderProductName.Name = "txtOrderProductName";
            this.txtOrderProductName.ReadOnly = true;
            this.txtOrderProductName.Size = new System.Drawing.Size(183, 22);
            this.txtOrderProductName.TabIndex = 6;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(168, 210);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(183, 22);
            this.txtOrderDate.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDate.Location = new System.Drawing.Point(14, 210);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Order Date";
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Location = new System.Drawing.Point(168, 300);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.ReadOnly = true;
            this.txtOrderPrice.Size = new System.Drawing.Size(183, 22);
            this.txtOrderPrice.TabIndex = 9;
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblOrderPrice.Location = new System.Drawing.Point(14, 300);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(81, 17);
            this.lblOrderPrice.TabIndex = 10;
            this.lblOrderPrice.Text = "Order Price";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(248, 351);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(103, 42);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.Order_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(17, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 42);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(14, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Order Size";
            // 
            // txtOrderSize
            // 
            this.txtOrderSize.Location = new System.Drawing.Point(167, 255);
            this.txtOrderSize.Name = "txtOrderSize";
            this.txtOrderSize.ReadOnly = true;
            this.txtOrderSize.Size = new System.Drawing.Size(183, 22);
            this.txtOrderSize.TabIndex = 13;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderSize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.txtOrderPrice);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtOrderProductName);
            this.Controls.Add(this.txtOrderDescription);
            this.Controls.Add(this.lblOrderDescription);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "frmOrder";
            this.Text = "ORDER INFORMATION";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblOrderDescription;
        private System.Windows.Forms.TextBox txtOrderDescription;
        private System.Windows.Forms.TextBox txtOrderProductName;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderSize;
    }
}
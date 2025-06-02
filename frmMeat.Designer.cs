namespace MyStore
{
    partial class frmMeat
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
            this.btnBeef = new System.Windows.Forms.Button();
            this.btnMutton = new System.Windows.Forms.Button();
            this.btnChicken = new System.Windows.Forms.Button();
            this.btnPork = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeef
            // 
            this.btnBeef.Location = new System.Drawing.Point(432, 245);
            this.btnBeef.Name = "btnBeef";
            this.btnBeef.Size = new System.Drawing.Size(199, 39);
            this.btnBeef.TabIndex = 7;
            this.btnBeef.Text = "Beef";
            this.btnBeef.UseVisualStyleBackColor = true;
            this.btnBeef.Click += new System.EventHandler(this.btnBeef_Click);
            // 
            // btnMutton
            // 
            this.btnMutton.Location = new System.Drawing.Point(170, 245);
            this.btnMutton.Name = "btnMutton";
            this.btnMutton.Size = new System.Drawing.Size(199, 39);
            this.btnMutton.TabIndex = 6;
            this.btnMutton.Text = "Mutton";
            this.btnMutton.UseVisualStyleBackColor = true;
            // 
            // btnChicken
            // 
            this.btnChicken.Location = new System.Drawing.Point(430, 167);
            this.btnChicken.Name = "btnChicken";
            this.btnChicken.Size = new System.Drawing.Size(199, 39);
            this.btnChicken.TabIndex = 5;
            this.btnChicken.Text = "Chicken";
            this.btnChicken.UseVisualStyleBackColor = true;
            // 
            // btnPork
            // 
            this.btnPork.Location = new System.Drawing.Point(170, 167);
            this.btnPork.Name = "btnPork";
            this.btnPork.Size = new System.Drawing.Size(199, 39);
            this.btnPork.TabIndex = 4;
            this.btnPork.Text = "Pork";
            this.btnPork.UseVisualStyleBackColor = true;
            this.btnPork.Click += new System.EventHandler(this.btnPork_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(199, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Meat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBeef);
            this.Controls.Add(this.btnMutton);
            this.Controls.Add(this.btnChicken);
            this.Controls.Add(this.btnPork);
            this.Name = "frmMeat";
            this.Text = "frmMeat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeef;
        private System.Windows.Forms.Button btnMutton;
        private System.Windows.Forms.Button btnChicken;
        private System.Windows.Forms.Button btnPork;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}
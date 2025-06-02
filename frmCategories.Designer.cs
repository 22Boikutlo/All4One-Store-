namespace MyStore
{
    partial class frmCategories
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
            this.btnMeat = new System.Windows.Forms.Button();
            this.btnFruit = new System.Windows.Forms.Button();
            this.btnVegetable = new System.Windows.Forms.Button();
            this.btnHomeLife = new System.Windows.Forms.Button();
            this.btnElectronics = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnApparel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMeat
            // 
            this.btnMeat.Location = new System.Drawing.Point(42, 88);
            this.btnMeat.Name = "btnMeat";
            this.btnMeat.Size = new System.Drawing.Size(199, 39);
            this.btnMeat.TabIndex = 0;
            this.btnMeat.Text = "Meat";
            this.btnMeat.UseVisualStyleBackColor = true;
            this.btnMeat.Click += new System.EventHandler(this.btnMeat_Click);
            // 
            // btnFruit
            // 
            this.btnFruit.Location = new System.Drawing.Point(302, 88);
            this.btnFruit.Name = "btnFruit";
            this.btnFruit.Size = new System.Drawing.Size(199, 39);
            this.btnFruit.TabIndex = 1;
            this.btnFruit.Text = "Fruit";
            this.btnFruit.UseVisualStyleBackColor = true;
            // 
            // btnVegetable
            // 
            this.btnVegetable.Location = new System.Drawing.Point(42, 166);
            this.btnVegetable.Name = "btnVegetable";
            this.btnVegetable.Size = new System.Drawing.Size(199, 39);
            this.btnVegetable.TabIndex = 2;
            this.btnVegetable.Text = "Vegetable";
            this.btnVegetable.UseVisualStyleBackColor = true;
            // 
            // btnHomeLife
            // 
            this.btnHomeLife.Location = new System.Drawing.Point(304, 166);
            this.btnHomeLife.Name = "btnHomeLife";
            this.btnHomeLife.Size = new System.Drawing.Size(199, 39);
            this.btnHomeLife.TabIndex = 3;
            this.btnHomeLife.Text = "Home and Lifestyle";
            this.btnHomeLife.UseVisualStyleBackColor = true;
            // 
            // btnElectronics
            // 
            this.btnElectronics.Location = new System.Drawing.Point(42, 244);
            this.btnElectronics.Name = "btnElectronics";
            this.btnElectronics.Size = new System.Drawing.Size(199, 39);
            this.btnElectronics.TabIndex = 4;
            this.btnElectronics.Text = "Electronics and  Accessories";
            this.btnElectronics.UseVisualStyleBackColor = true;
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(304, 244);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(199, 39);
            this.btnFood.TabIndex = 5;
            this.btnFood.Text = "Food and Beverages";
            this.btnFood.UseVisualStyleBackColor = true;
            // 
            // btnApparel
            // 
            this.btnApparel.Location = new System.Drawing.Point(562, 88);
            this.btnApparel.Name = "btnApparel";
            this.btnApparel.Size = new System.Drawing.Size(199, 39);
            this.btnApparel.TabIndex = 6;
            this.btnApparel.Text = "Personal Care and Apparel";
            this.btnApparel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categories";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(42, 377);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApparel);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.btnElectronics);
            this.Controls.Add(this.btnHomeLife);
            this.Controls.Add(this.btnVegetable);
            this.Controls.Add(this.btnFruit);
            this.Controls.Add(this.btnMeat);
            this.Name = "frmCategories";
            this.Text = "Categories Page";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMeat;
        private System.Windows.Forms.Button btnFruit;
        private System.Windows.Forms.Button btnVegetable;
        private System.Windows.Forms.Button btnHomeLife;
        private System.Windows.Forms.Button btnElectronics;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnApparel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}
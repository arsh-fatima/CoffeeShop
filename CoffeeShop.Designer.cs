namespace CoffeeShopSC
{
    partial class CoffeeShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeShop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BUY = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.viewCoffee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.viewCoffee);
            this.panel1.Controls.Add(this.BUY);
            this.panel1.Controls.Add(this.ADD);
            this.panel1.Controls.Add(this.mainLabel);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 518);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BUY
            // 
            this.BUY.BackColor = System.Drawing.Color.Bisque;
            this.BUY.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUY.Location = new System.Drawing.Point(165, 287);
            this.BUY.Name = "BUY";
            this.BUY.Size = new System.Drawing.Size(188, 66);
            this.BUY.TabIndex = 2;
            this.BUY.Text = "Buy Coffee";
            this.BUY.UseVisualStyleBackColor = false;
            this.BUY.Click += new System.EventHandler(this.BUY_Click);
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.Bisque;
            this.ADD.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.Location = new System.Drawing.Point(165, 199);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(188, 66);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "Add Coffee";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Bisque;
            this.mainLabel.Font = new System.Drawing.Font("Lucida Handwriting", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mainLabel.Location = new System.Drawing.Point(28, 101);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(479, 45);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Welcome to Coffee Shop!";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLabel.Click += new System.EventHandler(this.mainLabel_Click);
            // 
            // viewCoffee
            // 
            this.viewCoffee.BackColor = System.Drawing.Color.Bisque;
            this.viewCoffee.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCoffee.Location = new System.Drawing.Point(165, 380);
            this.viewCoffee.Name = "viewCoffee";
            this.viewCoffee.Size = new System.Drawing.Size(188, 66);
            this.viewCoffee.TabIndex = 3;
            this.viewCoffee.Text = "View Coffee";
            this.viewCoffee.UseVisualStyleBackColor = false;
            this.viewCoffee.Click += new System.EventHandler(this.viewCoffee_Click);
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 507);
            this.Controls.Add(this.panel1);
            this.Name = "CoffeeShop";
            this.Text = "CoffeeShop";
            this.Load += new System.EventHandler(this.CoffeeShop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button BUY;
        private System.Windows.Forms.Button viewCoffee;
    }
}


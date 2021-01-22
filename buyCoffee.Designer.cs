namespace CoffeeShopSC
{
    partial class buyCoffee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buyCoffee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.boughtCoffee = new System.Windows.Forms.TextBox();
            this.textBuyCoffee = new System.Windows.Forms.TextBox();
            this.BuyCoff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.boughtCoffee);
            this.panel1.Controls.Add(this.textBuyCoffee);
            this.panel1.Controls.Add(this.BuyCoff);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 452);
            this.panel1.TabIndex = 0;
            // 
            // boughtCoffee
            // 
            this.boughtCoffee.BackColor = System.Drawing.Color.Bisque;
            this.boughtCoffee.Location = new System.Drawing.Point(84, 264);
            this.boughtCoffee.Multiline = true;
            this.boughtCoffee.Name = "boughtCoffee";
            this.boughtCoffee.Size = new System.Drawing.Size(346, 38);
            this.boughtCoffee.TabIndex = 5;
            this.boughtCoffee.TextChanged += new System.EventHandler(this.boughtCoffee_TextChanged);
            // 
            // textBuyCoffee
            // 
            this.textBuyCoffee.BackColor = System.Drawing.Color.Bisque;
            this.textBuyCoffee.Location = new System.Drawing.Point(84, 195);
            this.textBuyCoffee.Multiline = true;
            this.textBuyCoffee.Name = "textBuyCoffee";
            this.textBuyCoffee.Size = new System.Drawing.Size(346, 38);
            this.textBuyCoffee.TabIndex = 4;
            this.textBuyCoffee.TextChanged += new System.EventHandler(this.textBuyCoffee_TextChanged);
            // 
            // BuyCoff
            // 
            this.BuyCoff.BackColor = System.Drawing.Color.Bisque;
            this.BuyCoff.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyCoff.Location = new System.Drawing.Point(160, 61);
            this.BuyCoff.Name = "BuyCoff";
            this.BuyCoff.Size = new System.Drawing.Size(188, 66);
            this.BuyCoff.TabIndex = 3;
            this.BuyCoff.Text = "Buy Coffee";
            this.BuyCoff.UseVisualStyleBackColor = false;
            this.BuyCoff.Click += new System.EventHandler(this.BuyCoff_Click);
            // 
            // buyCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.panel1);
            this.Name = "buyCoffee";
            this.Text = "buyCoffee";
            this.Load += new System.EventHandler(this.buyCoffee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BuyCoff;
        private System.Windows.Forms.TextBox textBuyCoffee;
        private System.Windows.Forms.TextBox boughtCoffee;
    }
}
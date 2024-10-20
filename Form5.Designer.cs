namespace MangInasal
{
    partial class Form5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productname = new System.Windows.Forms.Label();
            this.productdesc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.productid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(63, 283);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(230, 15);
            this.productname.TabIndex = 1;
            this.productname.Text = "Product Name";
            this.productname.Click += new System.EventHandler(this.productname_Click);
            // 
            // productdesc
            // 
            this.productdesc.Location = new System.Drawing.Point(392, 50);
            this.productdesc.Name = "productdesc";
            this.productdesc.Size = new System.Drawing.Size(550, 114);
            this.productdesc.TabIndex = 2;
            this.productdesc.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(473, 233);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 5;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(614, 231);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button1_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(712, 231);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(628, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "done";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(392, 176);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(215, 22);
            this.price.TabIndex = 12;
            this.price.Text = "label5";
            this.price.Click += new System.EventHandler(this.pprice_Click);
            // 
            // productid
            // 
            this.productid.AutoSize = true;
            this.productid.Location = new System.Drawing.Point(2, -2);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(35, 13);
            this.productid.TabIndex = 13;
            this.productid.Text = "label1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 397);
            this.Controls.Add(this.productid);
            this.Controls.Add(this.price);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productdesc);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label productname;
        public System.Windows.Forms.Label productdesc;
        public System.Windows.Forms.Label price;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label productid;
    }
}
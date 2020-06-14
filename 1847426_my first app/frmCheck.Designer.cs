namespace _1847426_my_first_app
{
    partial class frmCheck
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.chkDonut = new System.Windows.Forms.CheckBox();
            this.chkBrownie = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(217, 230);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(59, 67);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkBrownie);
            this.panel1.Controls.Add(this.chkDonut);
            this.panel1.Controls.Add(this.chkCoffee);
            this.panel1.Location = new System.Drawing.Point(59, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 93);
            this.panel1.TabIndex = 2;
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(47, 15);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(57, 17);
            this.chkCoffee.TabIndex = 0;
            this.chkCoffee.Text = "Coffee";
            this.chkCoffee.UseVisualStyleBackColor = true;
            // 
            // chkDonut
            // 
            this.chkDonut.AutoSize = true;
            this.chkDonut.Location = new System.Drawing.Point(47, 38);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(55, 17);
            this.chkDonut.TabIndex = 1;
            this.chkDonut.Text = "Donut";
            this.chkDonut.UseVisualStyleBackColor = true;
            // 
            // chkBrownie
            // 
            this.chkBrownie.AutoSize = true;
            this.chkBrownie.Location = new System.Drawing.Point(47, 62);
            this.chkBrownie.Name = "chkBrownie";
            this.chkBrownie.Size = new System.Drawing.Size(64, 17);
            this.chkBrownie.TabIndex = 2;
            this.chkBrownie.Text = "Brownie";
            this.chkBrownie.UseVisualStyleBackColor = true;
            this.chkBrownie.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCheck";
            this.Text = "frmCheck";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkBrownie;
        private System.Windows.Forms.CheckBox chkDonut;
        private System.Windows.Forms.CheckBox chkCoffee;
    }
}
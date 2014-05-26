namespace Client
{
    partial class Form1
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
            this.ipadres = new System.Windows.Forms.TextBox();
            this.poort = new System.Windows.Forms.TextBox();
            this.invoer = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.naam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipadres
            // 
            this.ipadres.Location = new System.Drawing.Point(13, 37);
            this.ipadres.Name = "ipadres";
            this.ipadres.Size = new System.Drawing.Size(100, 20);
            this.ipadres.TabIndex = 0;
            this.ipadres.Text = "ip";
            this.ipadres.TextChanged += new System.EventHandler(this.ip_TextChanged);
            // 
            // poort
            // 
            this.poort.Location = new System.Drawing.Point(13, 63);
            this.poort.Name = "poort";
            this.poort.Size = new System.Drawing.Size(100, 20);
            this.poort.TabIndex = 1;
            this.poort.Text = "port";
            // 
            // invoer
            // 
            this.invoer.Location = new System.Drawing.Point(12, 229);
            this.invoer.Name = "invoer";
            this.invoer.Size = new System.Drawing.Size(100, 20);
            this.invoer.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(119, 229);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(131, 60);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // naam
            // 
            this.naam.Location = new System.Drawing.Point(12, 11);
            this.naam.Name = "naam";
            this.naam.Size = new System.Drawing.Size(100, 20);
            this.naam.TabIndex = 5;
            this.naam.Text = "naam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.naam);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.invoer);
            this.Controls.Add(this.poort);
            this.Controls.Add(this.ipadres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipadres;
        private System.Windows.Forms.TextBox poort;
        private System.Windows.Forms.TextBox invoer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox naam;
    }
}


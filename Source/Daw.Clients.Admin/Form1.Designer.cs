namespace Daw.Clients.Admin
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
            this.btnOpenSecretClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenSecretClient
            // 
            this.btnOpenSecretClient.Location = new System.Drawing.Point(99, 45);
            this.btnOpenSecretClient.Name = "btnOpenSecretClient";
            this.btnOpenSecretClient.Size = new System.Drawing.Size(175, 31);
            this.btnOpenSecretClient.TabIndex = 0;
            this.btnOpenSecretClient.Text = "Open SecretClient";
            this.btnOpenSecretClient.UseVisualStyleBackColor = true;
            this.btnOpenSecretClient.Click += new System.EventHandler(this.btnOpenSecretClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 361);
            this.Controls.Add(this.btnOpenSecretClient);
            this.Name = "Form1";
            this.Text = "Clients Tester";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSecretClient;
    }
}


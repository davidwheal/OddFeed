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
            this.btnOpenEngineClient = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvFeeds = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenSecretClient
            // 
            this.btnOpenSecretClient.Location = new System.Drawing.Point(282, 427);
            this.btnOpenSecretClient.Name = "btnOpenSecretClient";
            this.btnOpenSecretClient.Size = new System.Drawing.Size(175, 31);
            this.btnOpenSecretClient.TabIndex = 0;
            this.btnOpenSecretClient.Text = "Open SecretClient";
            this.btnOpenSecretClient.UseVisualStyleBackColor = true;
            this.btnOpenSecretClient.Click += new System.EventHandler(this.btnOpenSecretClient_Click);
            // 
            // btnOpenEngineClient
            // 
            this.btnOpenEngineClient.Location = new System.Drawing.Point(26, 19);
            this.btnOpenEngineClient.Name = "btnOpenEngineClient";
            this.btnOpenEngineClient.Size = new System.Drawing.Size(75, 31);
            this.btnOpenEngineClient.TabIndex = 1;
            this.btnOpenEngineClient.Text = "Refresh";
            this.btnOpenEngineClient.UseVisualStyleBackColor = true;
            this.btnOpenEngineClient.Click += new System.EventHandler(this.btnOpenEngineClient_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dgvFeeds);
            this.tabPage1.Controls.Add(this.btnOpenEngineClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1079, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Feeds";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Events";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvFeeds
            // 
            this.dgvFeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeeds.Location = new System.Drawing.Point(122, 19);
            this.dgvFeeds.Name = "dgvFeeds";
            this.dgvFeeds.RowTemplate.Height = 24;
            this.dgvFeeds.Size = new System.Drawing.Size(595, 233);
            this.dgvFeeds.TabIndex = 2;
            this.dgvFeeds.SelectionChanged += new System.EventHandler(this.dgvFeeds_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 470);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOpenSecretClient);
            this.Name = "Form1";
            this.Text = "Feed Administration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSecretClient;
        private System.Windows.Forms.Button btnOpenEngineClient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvFeeds;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
    }
}


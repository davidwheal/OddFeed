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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFeeds = new System.Windows.Forms.TabPage();
            this.btnRefreshFeeds = new System.Windows.Forms.Button();
            this.btnGoToEvents = new System.Windows.Forms.Button();
            this.dgvFeeds = new System.Windows.Forms.DataGridView();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.btnMarkets = new System.Windows.Forms.Button();
            this.txtFeedKey = new System.Windows.Forms.TextBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.tabMarkets = new System.Windows.Forms.TabPage();
            this.txtFeedKey1 = new System.Windows.Forms.TextBox();
            this.dgvMarkets = new System.Windows.Forms.DataGridView();
            this.txtEventKey = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabFeeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeds)).BeginInit();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.tabMarkets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenSecretClient
            // 
            this.btnOpenSecretClient.Location = new System.Drawing.Point(12, 560);
            this.btnOpenSecretClient.Name = "btnOpenSecretClient";
            this.btnOpenSecretClient.Size = new System.Drawing.Size(175, 31);
            this.btnOpenSecretClient.TabIndex = 0;
            this.btnOpenSecretClient.Text = "Open SecretClient";
            this.btnOpenSecretClient.UseVisualStyleBackColor = true;
            this.btnOpenSecretClient.Click += new System.EventHandler(this.btnOpenSecretClient_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFeeds);
            this.tabControl1.Controls.Add(this.tabEvents);
            this.tabControl1.Controls.Add(this.tabMarkets);
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 530);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabFeeds
            // 
            this.tabFeeds.Controls.Add(this.btnRefreshFeeds);
            this.tabFeeds.Controls.Add(this.btnGoToEvents);
            this.tabFeeds.Controls.Add(this.dgvFeeds);
            this.tabFeeds.Location = new System.Drawing.Point(4, 25);
            this.tabFeeds.Name = "tabFeeds";
            this.tabFeeds.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeeds.Size = new System.Drawing.Size(1079, 501);
            this.tabFeeds.TabIndex = 0;
            this.tabFeeds.Text = "Feeds";
            this.tabFeeds.UseVisualStyleBackColor = true;
            this.tabFeeds.Click += new System.EventHandler(this.tabFeeds_Click);
            // 
            // btnRefreshFeeds
            // 
            this.btnRefreshFeeds.Location = new System.Drawing.Point(34, 20);
            this.btnRefreshFeeds.Name = "btnRefreshFeeds";
            this.btnRefreshFeeds.Size = new System.Drawing.Size(82, 38);
            this.btnRefreshFeeds.TabIndex = 4;
            this.btnRefreshFeeds.Text = "Refresh";
            this.btnRefreshFeeds.UseVisualStyleBackColor = true;
            this.btnRefreshFeeds.Click += new System.EventHandler(this.btnRefreshFeeds_Click);
            // 
            // btnGoToEvents
            // 
            this.btnGoToEvents.Location = new System.Drawing.Point(685, 296);
            this.btnGoToEvents.Name = "btnGoToEvents";
            this.btnGoToEvents.Size = new System.Drawing.Size(138, 31);
            this.btnGoToEvents.TabIndex = 3;
            this.btnGoToEvents.Text = "Events >";
            this.btnGoToEvents.UseVisualStyleBackColor = true;
            this.btnGoToEvents.Click += new System.EventHandler(this.btnGoToEvents_Click);
            // 
            // dgvFeeds
            // 
            this.dgvFeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeeds.Location = new System.Drawing.Point(143, 20);
            this.dgvFeeds.Name = "dgvFeeds";
            this.dgvFeeds.RowTemplate.Height = 24;
            this.dgvFeeds.Size = new System.Drawing.Size(503, 307);
            this.dgvFeeds.TabIndex = 2;
            this.dgvFeeds.SelectionChanged += new System.EventHandler(this.dgvFeeds_SelectionChanged);
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.btnMarkets);
            this.tabEvents.Controls.Add(this.txtFeedKey);
            this.tabEvents.Controls.Add(this.dgvEvents);
            this.tabEvents.Location = new System.Drawing.Point(4, 25);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(1079, 501);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            this.tabEvents.Enter += new System.EventHandler(this.tabEvents_Enter);
            // 
            // btnMarkets
            // 
            this.btnMarkets.Enabled = false;
            this.btnMarkets.Location = new System.Drawing.Point(855, 231);
            this.btnMarkets.Name = "btnMarkets";
            this.btnMarkets.Size = new System.Drawing.Size(144, 31);
            this.btnMarkets.TabIndex = 2;
            this.btnMarkets.Text = "Markets >>";
            this.btnMarkets.UseVisualStyleBackColor = true;
            this.btnMarkets.Click += new System.EventHandler(this.btnMarkets_Click);
            // 
            // txtFeedKey
            // 
            this.txtFeedKey.Location = new System.Drawing.Point(121, 26);
            this.txtFeedKey.Name = "txtFeedKey";
            this.txtFeedKey.Size = new System.Drawing.Size(321, 22);
            this.txtFeedKey.TabIndex = 1;
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(85, 68);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(721, 381);
            this.dgvEvents.TabIndex = 0;
            this.dgvEvents.SelectionChanged += new System.EventHandler(this.dgvEvents_SelectionChanged);
            // 
            // tabMarkets
            // 
            this.tabMarkets.Controls.Add(this.txtFeedKey1);
            this.tabMarkets.Controls.Add(this.dgvMarkets);
            this.tabMarkets.Controls.Add(this.txtEventKey);
            this.tabMarkets.Location = new System.Drawing.Point(4, 25);
            this.tabMarkets.Name = "tabMarkets";
            this.tabMarkets.Size = new System.Drawing.Size(1079, 501);
            this.tabMarkets.TabIndex = 2;
            this.tabMarkets.Text = "Markets";
            this.tabMarkets.UseVisualStyleBackColor = true;
            this.tabMarkets.Enter += new System.EventHandler(this.tabMarkets_Enter);
            // 
            // txtFeedKey1
            // 
            this.txtFeedKey1.Location = new System.Drawing.Point(507, 31);
            this.txtFeedKey1.Name = "txtFeedKey1";
            this.txtFeedKey1.Size = new System.Drawing.Size(321, 22);
            this.txtFeedKey1.TabIndex = 3;
            // 
            // dgvMarkets
            // 
            this.dgvMarkets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkets.Location = new System.Drawing.Point(153, 81);
            this.dgvMarkets.Name = "dgvMarkets";
            this.dgvMarkets.RowTemplate.Height = 24;
            this.dgvMarkets.Size = new System.Drawing.Size(721, 381);
            this.dgvMarkets.TabIndex = 3;
            this.dgvMarkets.SelectionChanged += new System.EventHandler(this.dgvMarkets_SelectionChanged);
            // 
            // txtEventKey
            // 
            this.txtEventKey.Location = new System.Drawing.Point(82, 31);
            this.txtEventKey.Name = "txtEventKey";
            this.txtEventKey.Size = new System.Drawing.Size(321, 22);
            this.txtEventKey.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 603);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOpenSecretClient);
            this.Name = "Form1";
            this.Text = "Feed Administration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFeeds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeds)).EndInit();
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.tabMarkets.ResumeLayout(false);
            this.tabMarkets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSecretClient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFeeds;
        private System.Windows.Forms.DataGridView dgvFeeds;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.Button btnGoToEvents;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button btnRefreshFeeds;
        private System.Windows.Forms.TextBox txtFeedKey;
        private System.Windows.Forms.TabPage tabMarkets;
        private System.Windows.Forms.DataGridView dgvMarkets;
        private System.Windows.Forms.TextBox txtEventKey;
        private System.Windows.Forms.Button btnMarkets;
        private System.Windows.Forms.TextBox txtFeedKey1;
    }
}


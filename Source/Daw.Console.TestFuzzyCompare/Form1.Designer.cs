namespace Daw.Console.TestFuzzyCompare
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
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(161, 53);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(719, 20);
            this.txtS1.TabIndex = 0;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(161, 96);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(719, 20);
            this.txtS2.TabIndex = 1;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(183, 190);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(125, 38);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(451, 186);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(145, 20);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 489);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtResult;
    }
}


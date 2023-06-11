namespace FlowerDatabasePrj
{
    partial class MainPage
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
            this.btnShowFlowers = new System.Windows.Forms.Button();
            this.tblFlowers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblFlowers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowFlowers
            // 
            this.btnShowFlowers.Location = new System.Drawing.Point(30, 45);
            this.btnShowFlowers.Name = "btnShowFlowers";
            this.btnShowFlowers.Size = new System.Drawing.Size(109, 23);
            this.btnShowFlowers.TabIndex = 0;
            this.btnShowFlowers.Text = "Show flowers";
            this.btnShowFlowers.UseVisualStyleBackColor = true;
            this.btnShowFlowers.Click += new System.EventHandler(this.btnShowFlowers_Click);
            // 
            // tblFlowers
            // 
            this.tblFlowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFlowers.Location = new System.Drawing.Point(166, 45);
            this.tblFlowers.Name = "tblFlowers";
            this.tblFlowers.Size = new System.Drawing.Size(343, 393);
            this.tblFlowers.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.tblFlowers);
            this.Controls.Add(this.btnShowFlowers);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFlowers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowFlowers;
        private System.Windows.Forms.DataGridView tblFlowers;
    }
}
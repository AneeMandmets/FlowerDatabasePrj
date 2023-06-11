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
            this.btnShowTypes = new System.Windows.Forms.Button();
            this.lblPickType = new System.Windows.Forms.Label();
            this.cbTypes = new System.Windows.Forms.ComboBox();
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
            this.tblFlowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblFlowers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblFlowers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblFlowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFlowers.Location = new System.Drawing.Point(166, 45);
            this.tblFlowers.Name = "tblFlowers";
            this.tblFlowers.ReadOnly = true;
            this.tblFlowers.Size = new System.Drawing.Size(343, 376);
            this.tblFlowers.TabIndex = 1;
            // 
            // btnShowTypes
            // 
            this.btnShowTypes.Location = new System.Drawing.Point(30, 76);
            this.btnShowTypes.Name = "btnShowTypes";
            this.btnShowTypes.Size = new System.Drawing.Size(109, 23);
            this.btnShowTypes.TabIndex = 2;
            this.btnShowTypes.Text = "Show types";
            this.btnShowTypes.UseVisualStyleBackColor = true;
            this.btnShowTypes.Click += new System.EventHandler(this.btnShowTypes_Click);
            // 
            // lblPickType
            // 
            this.lblPickType.AutoSize = true;
            this.lblPickType.Location = new System.Drawing.Point(30, 117);
            this.lblPickType.Name = "lblPickType";
            this.lblPickType.Size = new System.Drawing.Size(57, 13);
            this.lblPickType.TabIndex = 3;
            this.lblPickType.Text = "Pick type: ";
            // 
            // cbTypes
            // 
            this.cbTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(33, 134);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(121, 21);
            this.cbTypes.TabIndex = 4;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.lblPickType);
            this.Controls.Add(this.btnShowTypes);
            this.Controls.Add(this.tblFlowers);
            this.Controls.Add(this.btnShowFlowers);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFlowers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowFlowers;
        private System.Windows.Forms.DataGridView tblFlowers;
        private System.Windows.Forms.Button btnShowTypes;
        private System.Windows.Forms.Label lblPickType;
        private System.Windows.Forms.ComboBox cbTypes;
    }
}
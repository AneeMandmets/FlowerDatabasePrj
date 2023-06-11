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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAddFlower = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
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
            this.cbTypes.SelectedValueChanged += new System.EventHandler(this.cbTypes_SelectedValueChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 174);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Insert name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(33, 190);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 6;
            // 
            // btnAddFlower
            // 
            this.btnAddFlower.Location = new System.Drawing.Point(33, 216);
            this.btnAddFlower.Name = "btnAddFlower";
            this.btnAddFlower.Size = new System.Drawing.Size(106, 23);
            this.btnAddFlower.TabIndex = 7;
            this.btnAddFlower.Text = "Add flower";
            this.btnAddFlower.UseVisualStyleBackColor = true;
            this.btnAddFlower.Click += new System.EventHandler(this.btnAddFlower_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.Enabled = false;
            this.btnAddType.Location = new System.Drawing.Point(33, 246);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(106, 23);
            this.btnAddType.TabIndex = 8;
            this.btnAddType.Text = "Add type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.btnAddFlower);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAddFlower;
        private System.Windows.Forms.Button btnAddType;
    }
}
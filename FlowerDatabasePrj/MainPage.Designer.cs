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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShowFlowers = new System.Windows.Forms.Button();
            this.tblFlowers = new System.Windows.Forms.DataGridView();
            this.btnShowTypes = new System.Windows.Forms.Button();
            this.lblPickType = new System.Windows.Forms.Label();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAddFlower = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblFlowers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowFlowers
            // 
            this.btnShowFlowers.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFlowers.Location = new System.Drawing.Point(30, 45);
            this.btnShowFlowers.Name = "btnShowFlowers";
            this.btnShowFlowers.Size = new System.Drawing.Size(109, 29);
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
            this.tblFlowers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblFlowers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblFlowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblFlowers.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblFlowers.Location = new System.Drawing.Point(188, 45);
            this.tblFlowers.Name = "tblFlowers";
            this.tblFlowers.ReadOnly = true;
            this.tblFlowers.Size = new System.Drawing.Size(343, 376);
            this.tblFlowers.TabIndex = 1;
            this.tblFlowers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblFlowers_RowHeaderMouseClick);
            // 
            // btnShowTypes
            // 
            this.btnShowTypes.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTypes.Location = new System.Drawing.Point(30, 80);
            this.btnShowTypes.Name = "btnShowTypes";
            this.btnShowTypes.Size = new System.Drawing.Size(109, 29);
            this.btnShowTypes.TabIndex = 2;
            this.btnShowTypes.Text = "Show types";
            this.btnShowTypes.UseVisualStyleBackColor = true;
            this.btnShowTypes.Click += new System.EventHandler(this.btnShowTypes_Click);
            // 
            // lblPickType
            // 
            this.lblPickType.AutoSize = true;
            this.lblPickType.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickType.Location = new System.Drawing.Point(27, 121);
            this.lblPickType.Name = "lblPickType";
            this.lblPickType.Size = new System.Drawing.Size(85, 18);
            this.lblPickType.TabIndex = 3;
            this.lblPickType.Text = "Pick type: ";
            // 
            // cbTypes
            // 
            this.cbTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTypes.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(30, 142);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(121, 26);
            this.cbTypes.TabIndex = 4;
            this.cbTypes.SelectedValueChanged += new System.EventHandler(this.cbTypes_SelectedValueChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(27, 189);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 18);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Insert name:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(30, 210);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 26);
            this.tbName.TabIndex = 6;
            // 
            // btnAddFlower
            // 
            this.btnAddFlower.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlower.Location = new System.Drawing.Point(30, 255);
            this.btnAddFlower.Name = "btnAddFlower";
            this.btnAddFlower.Size = new System.Drawing.Size(109, 29);
            this.btnAddFlower.TabIndex = 7;
            this.btnAddFlower.Text = "Add flower";
            this.btnAddFlower.UseVisualStyleBackColor = true;
            this.btnAddFlower.Click += new System.EventHandler(this.btnAddFlower_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.Enabled = false;
            this.btnAddType.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.Location = new System.Drawing.Point(30, 290);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(109, 29);
            this.btnAddType.TabIndex = 8;
            this.btnAddType.Text = "Add type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(30, 325);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 29);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(27, 441);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 18);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(90, 441);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 26);
            this.txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(246, 439);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(348, 443);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(57, 18);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "Count: ";
            // 
            // lblChange
            // 
            this.lblChange.Enabled = false;
            this.lblChange.Font = new System.Drawing.Font("Comic Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(30, 360);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(109, 29);
            this.lblChange.TabIndex = 14;
            this.lblChange.Text = "Change";
            this.lblChange.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(565, 485);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRemove);
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
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button lblChange;
    }
}
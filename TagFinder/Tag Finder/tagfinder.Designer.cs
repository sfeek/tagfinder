namespace Tag_Finder
{
    partial class frmtagfinder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTags = new System.Windows.Forms.TextBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnChooseRoot = new System.Windows.Forms.Button();
            this.lblStart1 = new System.Windows.Forms.Label();
            this.txtCurrentPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(99, 12);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(671, 27);
            this.txtTags.TabIndex = 0;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(7, 15);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(86, 20);
            this.lblTags.TabIndex = 1;
            this.lblTags.Text = "Search Tags";
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(16, 64);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(754, 369);
            this.rtbResults.TabIndex = 2;
            this.rtbResults.TabStop = false;
            this.rtbResults.Text = "";
            this.rtbResults.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbResults_LinkClicked_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(267, 499);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(415, 65);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnChooseRoot
            // 
            this.btnChooseRoot.Location = new System.Drawing.Point(47, 499);
            this.btnChooseRoot.Name = "btnChooseRoot";
            this.btnChooseRoot.Size = new System.Drawing.Size(178, 65);
            this.btnChooseRoot.TabIndex = 2;
            this.btnChooseRoot.Text = "Choose Start Path";
            this.btnChooseRoot.UseVisualStyleBackColor = true;
            this.btnChooseRoot.Click += new System.EventHandler(this.btnChooseRoot_Click);
            // 
            // lblStart1
            // 
            this.lblStart1.AutoSize = true;
            this.lblStart1.Location = new System.Drawing.Point(16, 442);
            this.lblStart1.Name = "lblStart1";
            this.lblStart1.Size = new System.Drawing.Size(127, 20);
            this.lblStart1.TabIndex = 5;
            this.lblStart1.Text = "Current Start Path:";
            // 
            // txtCurrentPath
            // 
            this.txtCurrentPath.Location = new System.Drawing.Point(148, 439);
            this.txtCurrentPath.Name = "txtCurrentPath";
            this.txtCurrentPath.Size = new System.Drawing.Size(622, 27);
            this.txtCurrentPath.TabIndex = 1;
            // 
            // frmtagfinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 576);
            this.Controls.Add(this.txtCurrentPath);
            this.Controls.Add(this.lblStart1);
            this.Controls.Add(this.btnChooseRoot);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.txtTags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmtagfinder";
            this.Text = "Tag Finder v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTags;
        private Label lblTags;
        private RichTextBox rtbResults;
        private Button btnSearch;
        private Button btnChooseRoot;
        private Label lblStart1;
        private TextBox txtCurrentPath;
    }
}
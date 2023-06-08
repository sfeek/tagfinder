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
            txtTags = new TextBox();
            lblTags = new Label();
            rtbResults = new RichTextBox();
            btnSearch = new Button();
            btnChooseRoot = new Button();
            lblStart1 = new Label();
            txtCurrentPath = new TextBox();
            SuspendLayout();
            // 
            // txtTags
            // 
            txtTags.Location = new Point(99, 12);
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(671, 27);
            txtTags.TabIndex = 0;
            // 
            // lblTags
            // 
            lblTags.AutoSize = true;
            lblTags.Location = new Point(7, 15);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(86, 20);
            lblTags.TabIndex = 1;
            lblTags.Text = "Search Tags";
            // 
            // rtbResults
            // 
            rtbResults.Location = new Point(16, 64);
            rtbResults.Name = "rtbResults";
            rtbResults.ReadOnly = true;
            rtbResults.Size = new Size(754, 369);
            rtbResults.TabIndex = 2;
            rtbResults.TabStop = false;
            rtbResults.Text = "";
            rtbResults.LinkClicked += rtbResults_LinkClicked;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(267, 499);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(415, 65);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnChooseRoot
            // 
            btnChooseRoot.Location = new Point(47, 499);
            btnChooseRoot.Name = "btnChooseRoot";
            btnChooseRoot.Size = new Size(178, 65);
            btnChooseRoot.TabIndex = 2;
            btnChooseRoot.Text = "Choose Start Path";
            btnChooseRoot.UseVisualStyleBackColor = true;
            btnChooseRoot.Click += btnChooseRoot_Click;
            // 
            // lblStart1
            // 
            lblStart1.AutoSize = true;
            lblStart1.Location = new Point(16, 443);
            lblStart1.Name = "lblStart1";
            lblStart1.Size = new Size(127, 20);
            lblStart1.TabIndex = 5;
            lblStart1.Text = "Current Start Path:";
            // 
            // txtCurrentPath
            // 
            txtCurrentPath.Location = new Point(149, 439);
            txtCurrentPath.Name = "txtCurrentPath";
            txtCurrentPath.Size = new Size(622, 27);
            txtCurrentPath.TabIndex = 1;
            // 
            // frmtagfinder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 576);
            Controls.Add(txtCurrentPath);
            Controls.Add(lblStart1);
            Controls.Add(btnChooseRoot);
            Controls.Add(btnSearch);
            Controls.Add(rtbResults);
            Controls.Add(lblTags);
            Controls.Add(txtTags);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmtagfinder";
            Text = "Folder Tag Finder v1.1";
            ResumeLayout(false);
            PerformLayout();
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
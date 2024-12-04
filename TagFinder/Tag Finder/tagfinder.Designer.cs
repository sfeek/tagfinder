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
            txtTags.Location = new Point(87, 9);
            txtTags.Margin = new Padding(3, 2, 3, 2);
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(588, 23);
            txtTags.TabIndex = 0;
            // 
            // lblTags
            // 
            lblTags.AutoSize = true;
            lblTags.Location = new Point(6, 11);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(69, 15);
            lblTags.TabIndex = 1;
            lblTags.Text = "Search Tags";
            // 
            // rtbResults
            // 
            rtbResults.Location = new Point(14, 48);
            rtbResults.Margin = new Padding(3, 2, 3, 2);
            rtbResults.Name = "rtbResults";
            rtbResults.ReadOnly = true;
            rtbResults.Size = new Size(660, 278);
            rtbResults.TabIndex = 2;
            rtbResults.TabStop = false;
            rtbResults.Text = "";
            rtbResults.LinkClicked += rtbResults_LinkClicked;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(234, 374);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(363, 49);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnChooseRoot
            // 
            btnChooseRoot.Location = new Point(41, 374);
            btnChooseRoot.Margin = new Padding(3, 2, 3, 2);
            btnChooseRoot.Name = "btnChooseRoot";
            btnChooseRoot.Size = new Size(156, 49);
            btnChooseRoot.TabIndex = 2;
            btnChooseRoot.Text = "Choose Start Path";
            btnChooseRoot.UseVisualStyleBackColor = true;
            btnChooseRoot.Click += btnChooseRoot_Click;
            // 
            // lblStart1
            // 
            lblStart1.AutoSize = true;
            lblStart1.Location = new Point(14, 332);
            lblStart1.Name = "lblStart1";
            lblStart1.Size = new Size(104, 15);
            lblStart1.TabIndex = 5;
            lblStart1.Text = "Current Start Path:";
            // 
            // txtCurrentPath
            // 
            txtCurrentPath.Location = new Point(130, 329);
            txtCurrentPath.Margin = new Padding(3, 2, 3, 2);
            txtCurrentPath.Name = "txtCurrentPath";
            txtCurrentPath.Size = new Size(545, 23);
            txtCurrentPath.TabIndex = 1;
            // 
            // frmtagfinder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 432);
            Controls.Add(txtCurrentPath);
            Controls.Add(lblStart1);
            Controls.Add(btnChooseRoot);
            Controls.Add(btnSearch);
            Controls.Add(rtbResults);
            Controls.Add(lblTags);
            Controls.Add(txtTags);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmtagfinder";
            Text = "Folder Tag Finder v2.0";
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
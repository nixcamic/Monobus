namespace Monobus
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbComics = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            tbComicSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            btnOpenLink = new System.Windows.Forms.Button();
            btnDownload = new System.Windows.Forms.Button();
            tbDesc = new System.Windows.Forms.RichTextBox();
            btnClear = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            pbCover = new System.Windows.Forms.PictureBox();
            lvDownloads = new System.Windows.Forms.ListView();
            Title = new System.Windows.Forms.ColumnHeader();
            Status = new System.Windows.Forms.ColumnHeader();
            Progress = new System.Windows.Forms.ColumnHeader();
            ID = new System.Windows.Forms.ColumnHeader();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            Cancel = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            clearDownloads = new System.Windows.Forms.ToolStripMenuItem();
            btnLastPage = new System.Windows.Forms.Button();
            btnNextPage = new System.Windows.Forms.Button();
            cmsComics = new System.Windows.Forms.ContextMenuStrip(components);
            search = new System.Windows.Forms.ToolStripMenuItem();
            validate = new System.Windows.Forms.ToolStripMenuItem();
            validateMF = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbCover).BeginInit();
            contextMenuStrip1.SuspendLayout();
            cmsComics.SuspendLayout();
            SuspendLayout();
            // 
            // lbComics
            // 
            lbComics.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbComics.FormattingEnabled = true;
            lbComics.ItemHeight = 15;
            lbComics.Location = new System.Drawing.Point(10, 130);
            lbComics.Margin = new System.Windows.Forms.Padding(2);
            lbComics.Name = "lbComics";
            lbComics.Size = new System.Drawing.Size(468, 214);
            lbComics.TabIndex = 2;
            lbComics.SelectedIndexChanged += lbComics_SelectedIndexChanged;
            lbComics.MouseDown += lbComics_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 17);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(277, 15);
            label1.TabIndex = 1;
            label1.Text = "Search for a comic (leave blank for recently added):";
            // 
            // tbComicSearch
            // 
            tbComicSearch.Location = new System.Drawing.Point(10, 39);
            tbComicSearch.Margin = new System.Windows.Forms.Padding(2);
            tbComicSearch.Name = "tbComicSearch";
            tbComicSearch.Size = new System.Drawing.Size(251, 23);
            tbComicSearch.TabIndex = 0;
            tbComicSearch.KeyDown += tbComicSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(266, 36);
            btnSearch.Margin = new System.Windows.Forms.Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(65, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnOpenLink
            // 
            btnOpenLink.Location = new System.Drawing.Point(10, 98);
            btnOpenLink.Margin = new System.Windows.Forms.Padding(2);
            btnOpenLink.Name = "btnOpenLink";
            btnOpenLink.Size = new System.Drawing.Size(82, 27);
            btnOpenLink.TabIndex = 4;
            btnOpenLink.Text = "Open Link";
            btnOpenLink.UseVisualStyleBackColor = true;
            btnOpenLink.Click += btnOpenLink_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new System.Drawing.Point(97, 98);
            btnDownload.Margin = new System.Windows.Forms.Padding(2);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new System.Drawing.Size(118, 27);
            btnDownload.TabIndex = 5;
            btnDownload.Text = "Download Comic";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_ClickAsync;
            // 
            // tbDesc
            // 
            tbDesc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbDesc.Location = new System.Drawing.Point(10, 350);
            tbDesc.Margin = new System.Windows.Forms.Padding(2);
            tbDesc.Name = "tbDesc";
            tbDesc.ReadOnly = true;
            tbDesc.Size = new System.Drawing.Size(468, 118);
            tbDesc.TabIndex = 6;
            tbDesc.Text = "";
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(337, 36);
            btnClear.Margin = new System.Windows.Forms.Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(68, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button2
            // 
            button2.Image = Monobus.Properties.Resources.downloads_32px;
            button2.Location = new System.Drawing.Point(688, 12);
            button2.Margin = new System.Windows.Forms.Padding(2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(46, 48);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Image = Monobus.Properties.Resources.settings_32px;
            button1.Location = new System.Drawing.Point(637, 12);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(46, 48);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pbCover
            // 
            pbCover.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pbCover.Location = new System.Drawing.Point(484, 130);
            pbCover.Margin = new System.Windows.Forms.Padding(2);
            pbCover.Name = "pbCover";
            pbCover.Size = new System.Drawing.Size(250, 337);
            pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbCover.TabIndex = 3;
            pbCover.TabStop = false;
            // 
            // lvDownloads
            // 
            lvDownloads.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvDownloads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Title, Status, Progress, ID });
            lvDownloads.Location = new System.Drawing.Point(10, 473);
            lvDownloads.Margin = new System.Windows.Forms.Padding(2);
            lvDownloads.Name = "lvDownloads";
            lvDownloads.Scrollable = false;
            lvDownloads.Size = new System.Drawing.Size(723, 184);
            lvDownloads.TabIndex = 14;
            lvDownloads.UseCompatibleStateImageBehavior = false;
            lvDownloads.View = System.Windows.Forms.View.Details;
            lvDownloads.MouseClick += lvDownloads_MouseClick;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.Width = 306;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 131;
            // 
            // Progress
            // 
            Progress.Text = "Progress";
            Progress.Width = 177;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Cancel, toolStripSeparator1, clearDownloads });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(164, 54);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // Cancel
            // 
            Cancel.Name = "Cancel";
            Cancel.Size = new System.Drawing.Size(163, 22);
            Cancel.Text = "Cancel";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // clearDownloads
            // 
            clearDownloads.Name = "clearDownloads";
            clearDownloads.Size = new System.Drawing.Size(163, 22);
            clearDownloads.Text = "Clear Downloads";
            // 
            // btnLastPage
            // 
            btnLastPage.Enabled = false;
            btnLastPage.Location = new System.Drawing.Point(418, 98);
            btnLastPage.Margin = new System.Windows.Forms.Padding(2);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new System.Drawing.Size(27, 27);
            btnLastPage.TabIndex = 15;
            btnLastPage.Text = "<";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Enabled = false;
            btnNextPage.Location = new System.Drawing.Point(450, 98);
            btnNextPage.Margin = new System.Windows.Forms.Padding(2);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new System.Drawing.Size(27, 27);
            btnNextPage.TabIndex = 16;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // cmsComics
            // 
            cmsComics.ImageScalingSize = new System.Drawing.Size(20, 20);
            cmsComics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { search, validate, validateMF });
            cmsComics.Name = "cmsComics";
            cmsComics.Size = new System.Drawing.Size(184, 70);
            cmsComics.Opening += cmsComics_Opening;
            cmsComics.ItemClicked += cmsComics_ItemClicked;
            // 
            // search
            // 
            search.Name = "search";
            search.Size = new System.Drawing.Size(183, 22);
            search.Text = "Find more like this";
            // 
            // validate
            // 
            validate.Name = "validate";
            validate.Size = new System.Drawing.Size(183, 22);
            validate.Text = "Verify MEGA Link";
            validate.Click += validate_Click;
            // 
            // validateMF
            // 
            validateMF.Name = "validateMF";
            validateMF.Size = new System.Drawing.Size(183, 22);
            validateMF.Text = "Verify MediaFire Link";
            validateMF.Click += verifyMediafireLinkToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(743, 665);
            Controls.Add(btnNextPage);
            Controls.Add(btnLastPage);
            Controls.Add(lvDownloads);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(tbDesc);
            Controls.Add(btnDownload);
            Controls.Add(btnOpenLink);
            Controls.Add(pbCover);
            Controls.Add(btnSearch);
            Controls.Add(tbComicSearch);
            Controls.Add(label1);
            Controls.Add(lbComics);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCover).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            cmsComics.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbComics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComicSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Button btnOpenLink;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RichTextBox tbDesc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvDownloads;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Progress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearDownloads;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.ContextMenuStrip cmsComics;
        private System.Windows.Forms.ToolStripMenuItem search;
        private System.Windows.Forms.ToolStripMenuItem validate;
        private System.Windows.Forms.ToolStripMenuItem validateMF;
        private System.Windows.Forms.ColumnHeader ID;
    }
}


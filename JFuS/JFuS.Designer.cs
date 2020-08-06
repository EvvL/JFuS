namespace JFuS
{
    partial class JFuS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JFuS));
            this.fileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationPanel = new System.Windows.Forms.Panel();
            this.directory = new System.Windows.Forms.ComboBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.selectDirectory = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchText = new System.Windows.Forms.TextBox();
            this.settings = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.results = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.dirWatcher = new System.IO.FileSystemWatcher();
            this.regexToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.totalStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.foundStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileContextMenu.SuspendLayout();
            this.locationPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dirWatcher)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileContextMenu
            // 
            this.fileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenuItem,
            this.cutMenuItem});
            this.fileContextMenu.Name = "fileContextMenu";
            this.fileContextMenu.Size = new System.Drawing.Size(145, 48);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyMenuItem.Text = "&Copy";
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutMenuItem.Text = "Cu&t";
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // locationPanel
            // 
            this.locationPanel.Controls.Add(this.directory);
            this.locationPanel.Controls.Add(this.directoryLabel);
            this.locationPanel.Controls.Add(this.selectDirectory);
            this.locationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationPanel.Location = new System.Drawing.Point(0, 0);
            this.locationPanel.Name = "locationPanel";
            this.locationPanel.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.locationPanel.Size = new System.Drawing.Size(784, 28);
            this.locationPanel.TabIndex = 4;
            // 
            // directory
            // 
            this.directory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.directory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.directory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directory.FormattingEnabled = true;
            this.directory.Location = new System.Drawing.Point(82, 4);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(669, 21);
            this.directory.TabIndex = 1;
            this.directory.TextChanged += new System.EventHandler(this.directory_TextChanged);
            this.directory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.directory_KeyDown);
            // 
            // directoryLabel
            // 
            this.directoryLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.directoryLabel.Location = new System.Drawing.Point(0, 4);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(82, 20);
            this.directoryLabel.TabIndex = 0;
            this.directoryLabel.Text = "Directory";
            this.directoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectDirectory
            // 
            this.selectDirectory.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectDirectory.FlatAppearance.BorderSize = 0;
            this.selectDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectDirectory.Location = new System.Drawing.Point(751, 4);
            this.selectDirectory.Name = "selectDirectory";
            this.selectDirectory.Size = new System.Drawing.Size(29, 20);
            this.selectDirectory.TabIndex = 4;
            this.selectDirectory.Text = "...";
            this.selectDirectory.UseVisualStyleBackColor = true;
            this.selectDirectory.Click += new System.EventHandler(this.selectDirectory_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchText);
            this.searchPanel.Controls.Add(this.settings);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 28);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.searchPanel.Size = new System.Drawing.Size(784, 28);
            this.searchPanel.TabIndex = 5;
            // 
            // searchText
            // 
            this.searchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchText.Enabled = false;
            this.searchText.Location = new System.Drawing.Point(82, 4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(669, 20);
            this.searchText.TabIndex = 2;
            this.searchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyDown);
            // 
            // settings
            // 
            this.settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Image = global::JFuS.Properties.Resources.setting_tools;
            this.settings.Location = new System.Drawing.Point(751, 4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(29, 20);
            this.settings.TabIndex = 5;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchLabel.Enabled = false;
            this.searchLabel.Location = new System.Drawing.Point(0, 4);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(82, 20);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search Regex";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regexToolTip.SetToolTip(this.searchLabel, resources.GetString("searchLabel.ToolTip"));
            this.searchLabel.DoubleClick += new System.EventHandler(this.searchLabel_DoubleClick);
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Select the location to search";
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // results
            // 
            this.results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader});
            this.results.ContextMenuStrip = this.fileContextMenu;
            this.results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results.FullRowSelect = true;
            this.results.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.results.HideSelection = false;
            this.results.LargeImageList = this.icons;
            this.results.Location = new System.Drawing.Point(0, 56);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(784, 383);
            this.results.SmallImageList = this.icons;
            this.results.TabIndex = 3;
            this.results.UseCompatibleStateImageBehavior = false;
            this.results.View = System.Windows.Forms.View.Details;
            this.results.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.results_ItemDrag);
            this.results.SelectedIndexChanged += new System.EventHandler(this.results_SelectedIndexChanged);
            this.results.DoubleClick += new System.EventHandler(this.results_DoubleClick);
            this.results.Resize += new System.EventHandler(this.results_Resize);
            // 
            // nameHeader
            // 
            this.nameHeader.Tag = "1";
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 719;
            // 
            // icons
            // 
            this.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.icons.ImageSize = new System.Drawing.Size(16, 16);
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dirWatcher
            // 
            this.dirWatcher.EnableRaisingEvents = true;
            this.dirWatcher.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.dirWatcher.SynchronizingObject = this;
            this.dirWatcher.Changed += new System.IO.FileSystemEventHandler(this.dirWatcher_Changed);
            this.dirWatcher.Created += new System.IO.FileSystemEventHandler(this.dirWatcher_Changed);
            this.dirWatcher.Deleted += new System.IO.FileSystemEventHandler(this.dirWatcher_Changed);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalStatus,
            this.foundStatus,
            this.selectedStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // totalStatus
            // 
            this.totalStatus.Name = "totalStatus";
            this.totalStatus.Size = new System.Drawing.Size(19, 17);
            this.totalStatus.Text = "    ";
            // 
            // foundStatus
            // 
            this.foundStatus.Name = "foundStatus";
            this.foundStatus.Size = new System.Drawing.Size(19, 17);
            this.foundStatus.Text = "    ";
            // 
            // selectedStatus
            // 
            this.selectedStatus.Name = "selectedStatus";
            this.selectedStatus.Size = new System.Drawing.Size(19, 17);
            this.selectedStatus.Text = "    ";
            // 
            // JFuS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.results);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.locationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JFuS";
            this.Text = "JFuS";
            this.SizeChanged += new System.EventHandler(this.JFuS_SizeChanged);
            this.fileContextMenu.ResumeLayout(false);
            this.locationPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dirWatcher)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip fileContextMenu;
        private System.Windows.Forms.Panel locationPanel;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Button selectDirectory;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ComboBox directory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ListView results;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.IO.FileSystemWatcher dirWatcher;
        private System.Windows.Forms.ToolTip regexToolTip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel totalStatus;
        private System.Windows.Forms.ToolStripStatusLabel foundStatus;
        private System.Windows.Forms.ToolStripStatusLabel selectedStatus;
    }
}


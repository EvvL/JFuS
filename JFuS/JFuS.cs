﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace JFuS
{
    public partial class JFuS : Form
    {
        public JFuS()
        {
            InitializeComponent();
            Size = Properties.Settings.Default.windowSize;


            LoadSettings();

            directory.Text = Properties.Settings.Default.lastDirectory;
            directory_TextChanged(null, null);
        }

        #region Directory functions

        private void selectDirectory_Click(object sender, EventArgs e)
        {
            if ( folderBrowser.ShowDialog() == DialogResult.OK )
                directory.Text = folderBrowser.SelectedPath;
        }

        private void directory_TextChanged(object sender, EventArgs e)
        {
            var validDir = Directory.Exists(directory.Text);

            directory.BackColor = (validDir) ? SystemColors.Window : Color.Pink;

            searchText.Enabled = validDir;
            searchLabel.Enabled = validDir;

            if ( validDir )
            {
                dirWatcher.Path = directory.Text;

                Properties.Settings.Default.lastDirectory = directory.Text;
                Properties.Settings.Default.Save();
            }
        }

        #endregion

        #region Search Functions

        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void dirWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            Search();
        }

        private void Search()
        {
            results.BeginUpdate();
            results.Items.Clear();

            results.BackColor = Color.White;

            var RXOptions = RegexOptions.Compiled;
            if (ignoreCase)
                RXOptions |= RegexOptions.IgnoreCase;

            Regex regex;

            try
            {
                regex = new Regex(searchText.Text, RXOptions);

                var total = 0;
                var found = 0;
                foreach (var file in Directory.GetFiles(directory.Text))
                {
                    total++;

                    var fileInfo = new FileInfo(file);

                    var result = regex.Match(fileInfo.Name);
                    if (result.Success)
                    {
                        var item = new ListViewItem(fileInfo.Name);

                        var iconForFile = SystemIcons.WinLogo;

                        if (!icons.Images.ContainsKey(fileInfo.Extension))
                        {
                            iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(fileInfo.FullName);
                            icons.Images.Add(fileInfo.Extension, iconForFile);
                        }

                        item.ImageKey = fileInfo.Extension;
                        item.Tag = fileInfo.FullName;

                        results.Items.Add(item);

                        found++;
                    }
                }

                totalStatus.Text = $"{total} Searched";
                foundStatus.Text = $"{found} Found";

                dirWatcher.EnableRaisingEvents = true;
            }
            catch (ArgumentException)
            {
                dirWatcher.EnableRaisingEvents = false;

                results.BackColor = Color.Pink;
                results.Items.Add("Invalid Regex");
            }

            results.EndUpdate();
        }

        private void searchLabel_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference");
        }

        #endregion

        #region Settings

        bool searchSubDirectories = false;
        bool ignoreCase = false;

        private void LoadSettings()
        {
            searchSubDirectories = Properties.Settings.Default.searchSubDirectories;
            ignoreCase = Properties.Settings.Default.ignoreCase;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            var settingsDialog = new Settings();

            if (settingsDialog.ShowDialog() == DialogResult.OK)
            {
                LoadSettings();
            }
        }

        private void JFuS_SizeChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.windowSize = Size;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region Result Functions

        private bool Resizing = false;
        private void results_Resize(object sender, EventArgs e)
        {
            if (!Resizing)
            {
                Resizing = true;

                if (sender is ListView listView)
                {
                    float totalColumnWidth = 0;

                    for (var i = 0; i < listView.Columns.Count; i++)
                        totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                    for (var i = 0; i < listView.Columns.Count; i++)
                    {
                        var colPercentage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                        listView.Columns[i].Width = (int)(colPercentage * listView.ClientRectangle.Width);
                    }
                }
            }

            Resizing = false;
        }

        private void results_DoubleClick(object sender, EventArgs e)
        {
            if ( results.SelectedItems.Count != 0 )
            {
                var item = results.SelectedItems[0];
                var filePath = item.Tag as String;
                Process.Start(filePath);
            }
        }

        private void results_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (results.SelectedItems.Count != 0)
            {
                var files = results.SelectedItems.Cast<ListViewItem>().Select(i => i.Tag as String).ToArray();

                DoDragDrop(new DataObject(DataFormats.FileDrop, files), DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            if (results.SelectedItems.Count != 0)
            {
                results.BeginUpdate();

                foreach (var item in results.Items.Cast<ListViewItem>())
                    item.ForeColor = SystemColors.ControlText;

                results.EndUpdate();

                var files = results.SelectedItems.Cast<ListViewItem>().Select(i => i.Tag as String).ToArray();
                Clipboard.SetDataObject(new DataObject(DataFormats.FileDrop, files));
            }
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            if (results.SelectedItems.Count != 0)
            {
                results.BeginUpdate();

                foreach (var item in results.Items.Cast<ListViewItem>())
                    item.ForeColor = (item.Selected) ? SystemColors.GrayText : SystemColors.ControlText;

                results.EndUpdate();

                var files = results.SelectedItems.Cast<ListViewItem>().Select(i => i.Tag as String).ToArray();

                var data = new DataObject();
                data.SetData("FileDrop", files);
                data.SetData("Preferred DropEffect", DragDropEffects.Move);

                Clipboard.SetDataObject(data, true);
            }
        }

        #endregion

        private void results_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStatus.Text = $"{results.SelectedItems.Count} selected";
        }
    }
}
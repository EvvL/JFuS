using System;
using System.Windows.Forms;

namespace JFuS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            searchSubDirectories.Checked = Properties.Settings.Default.searchSubDirectories;
            ignoreCase.Checked = Properties.Settings.Default.ignoreCase;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.searchSubDirectories = searchSubDirectories.Checked;
            Properties.Settings.Default.ignoreCase = ignoreCase.Checked;

            Properties.Settings.Default.Save();

            DialogResult = DialogResult.OK;
        }
    }
}

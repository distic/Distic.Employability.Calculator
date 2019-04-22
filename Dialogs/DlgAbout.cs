using System.Diagnostics;
using System.Windows.Forms;

namespace Distic.Employability.Calculator.Dialogs
{
    public partial class DlgAbout : Form
    {
        public DlgAbout()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #region --- Links ---

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Properties.Resources.GitHubLink);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Properties.Resources.DisticLink);
        }

        #endregion
    }
}

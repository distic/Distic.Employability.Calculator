using Distic.Employability.Calculator.UserControls;
using System;
using System.Media;
using System.Windows.Forms;

namespace Distic.Employability.Calculator.Dialogs
{
    public partial class DlgMain : Form
    {
        private ECOutputFramePost EcOutputFramePost { get; set; }

        public DlgMain()
        {
            InitializeComponent();
        }

        #region Misc

        #region --- Menu Item Clickable ---

        private void MenuItem4_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItem3_Click(object sender, EventArgs e)
        {
            new DlgAbout().ShowDialog();
        }

        private void MenuItem8_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }

        private void MenuItem6_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void MenuItem10_Click(object sender, System.EventArgs e)
        {
            var dlgWindowSize = new DlgWindowSize(Size);

            if (dlgWindowSize.ShowDialog() == DialogResult.OK)
            {
                Size = dlgWindowSize.NewSize;
            }
        }

        #endregion

        #endregion

        #region --- Logic Code ---

        private void EcBtnPoor_Click(object sender, System.EventArgs e)
        {
            ecOutputFrame1.InsertEcValue(ecBtnPoor.ECValue);
        }

        private void EcBtnPrivate_Click(object sender, System.EventArgs e)
        {
            ecOutputFrame1.InsertEcValue(ecBtnPrivate.ECValue);
        }

        private void EcBtnPublic_Click(object sender, System.EventArgs e)
        {
            ecOutputFrame1.InsertEcValue(ecBtnPublic.ECValue);
        }

        private void EcBtnRefugee_Click(object sender, System.EventArgs e)
        {
            ecOutputFrame1.InsertEcValue(ecBtnRefugee.ECValue);
        }

        private void EcBtnForeignLanguage_Click(object sender, System.EventArgs e)
        {
            ecOutputFrame1.InsertEcValue(ecBtnForeignLanguage.ECValue);
        }

        private void EcBtnRich_Click(object sender, System.EventArgs e)
        {
            ecOutputFrame1.InsertEcValue(ecBtnRich.ECValue);
        }

        private void EcBtnNational_Click(object sender, System.EventArgs e)
        {
            ecOutputFrame1.InsertEcValue(ecBtnNational.ECValue);
        }

        private void EcBtnArabic_Click(object sender, System.EventArgs e)
        {
            ecOutputFrame1.InsertEcValue(ecBtnArabic.ECValue);
        }

        private void EcBtnAdd_Click(object sender, System.EventArgs e)
        {
            ecOutputFrame1.InsertEcValue(ecBtnAdd.ECValue);
        }

        private void EcBtnSubtract_Click(object sender, System.EventArgs e)
        {
            ecOutputFrame1.ResetOutput();
            ecOutputFrame1.Show();
            this.Controls.Remove(EcOutputFramePost);
            EcOutputFramePost = null;
        }

        private void EcBtnResult_Click(object sender, System.EventArgs e)
        {
            var result = ecOutputFrame1.TryGetResult();

            if (result)
            {
                EcOutputFramePost = new ECOutputFramePost(ecOutputFrame1.ExtractCurrentOutput, ecOutputFrame1.GetText)
                {
                    Size = ecOutputFrame1.Size,
                    Location = ecOutputFrame1.Location
                };

                ecOutputFrame1.Hide();
                this.Controls.Add(EcOutputFramePost);
                SystemSounds.Beep.Play();
            }
        }

        #endregion

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

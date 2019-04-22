using Distic.Employability.Calculator.Utilities;
using System.Windows.Forms;
using static Distic.Employability.Calculator.Utilities.ECCPU;

namespace Distic.Employability.Calculator.CustomControls
{
    public class ECOutputFrame : Panel
    {
        #region --- Properties ---

        private Label gLabel { get; set; }

        private ECCPU gEcCpu { get; set; }

        #endregion

        public ECOutputFrame()
        {
            gEcCpu = new ECCPU();

            BackColor = BackColor = Properties.Settings.Default.ECOutputFrameBackColor;

            gLabel = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Text = ""
            };

            Controls.Add(gLabel);
        }

        public void ResetOutput()
        {
            gLabel.Text = string.Empty;
            gEcCpu.Reset();
        }

        public string ExtractCurrentOutput
        {
            get
            {
                return gEcCpu.ExtractCurrentOutput();
            }
        }

        public void InsertEcValue(ECValues ecValue)
        {
            gEcCpu.InsertEcValue(ecValue);
            gLabel.Text = gEcCpu.ExtractCurrentOutput();
        }

        public string GetText
        {
            get
            {
                return gLabel.Text;
            }
        }

        public bool TryGetResult()
        {
            var result = gEcCpu.TryGetResult();

            if (!string.IsNullOrEmpty(result))
            {
                gLabel.Text = result;
                return true;
            }

            return false;
        }
    }
}

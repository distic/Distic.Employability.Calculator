using System.Drawing;
using System.Windows.Forms;
using static Distic.Employability.Calculator.Utilities.ECCPU;

namespace Distic.Employability.Calculator.CustomControls
{
    public class ECButton : Label
    {
        public enum ForeColorInvert
        {
            Black,
            White
        }

        private ForeColorInvert gLabelForeColor { get; set; }

        public ECValues ECValue { get; set; }

        #region --- User Properties ---

        public ForeColorInvert LabelForeColor
        {
            get
            {
                return gLabelForeColor;
            }

            set
            {
                switch (gLabelForeColor)
                {
                    case ForeColorInvert.White:
                        ForeColor = Color.Black;
                        gLabelForeColor = value;
                        break;

                    case ForeColorInvert.Black:
                        ForeColor = Color.White;
                        gLabelForeColor = value;
                        break;
                }
            }
        }

        #endregion

        public ECButton()
        {
            TextAlign = ContentAlignment.MiddleCenter;
            BackColor = Properties.Settings.Default.ECButtonBackColor;
            ForeColor = Properties.Settings.Default.ECButtonForeColor;
            Size = Properties.Settings.Default.ECButtonRectSize;
            LabelForeColor = ForeColorInvert.Black;

            MouseDown += ECButton_MouseDown;
            MouseUp += ECButton_MouseUp;
            MouseHover += ECButton_MouseHover;
            MouseLeave += ECButton_MouseLeave;
        }

        private void ECButton_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = Properties.Settings.Default.ECButtonBackColor;
        }

        private void ECButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.Black;
        }

        private void ECButton_MouseHover(object sender, System.EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void ECButton_MouseLeave(object sender, System.EventArgs e)
        {
            BorderStyle = BorderStyle.None;
            BackColor = Properties.Settings.Default.ECButtonBackColor;
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Distic.Employability.Calculator.Dialogs
{
    public partial class DlgWindowSize : Form
    {
        private Size gParentWindowSize { get; set; }

        public Size NewSize { get; set; }

        public DlgWindowSize(Size size)
        {
            gParentWindowSize = size;
            InitializeComponent();
        }

        private void DlgWindowSize_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = gParentWindowSize.Width;
            numericUpDown2.Value = gParentWindowSize.Height;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            NewSize = new Size((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Close();
        }
    }
}

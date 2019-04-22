using System.Windows.Forms;

namespace Distic.Employability.Calculator.UserControls
{
    public partial class ECOutputFramePost : UserControl
    {
        public ECOutputFramePost(string userInputResult, string endResult)
        {
            InitializeComponent();

            label1.Text = userInputResult;
            label2.Text = endResult;
        }
    }
}

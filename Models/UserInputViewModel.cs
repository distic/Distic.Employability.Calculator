using static Distic.Employability.Calculator.Utilities.ECCPU;

namespace Distic.Employability.Calculator.Models
{
    public class UserInputViewModel
    {
        public ECValues EcValue1 { get; set; }

        public ECValues EcValue2 { get; set; }

        public ECValues EcValue3 { get; set; }

        public ECValues EcValue4 { get; set; }

        public string Result { get; set; }
    }
}

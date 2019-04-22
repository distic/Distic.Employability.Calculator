using Distic.Employability.Calculator.Dialogs;
using Distic.Employability.Calculator.Utilities;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Distic.Employability.Calculator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (!File.Exists(Properties.Resources.JsonFilename))
            {
                MessageBox.Show(Properties.Resources.TrainerFileCannotBeFound, Properties.Resources.MessageFromProgrammerDude, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                using (var sr = new StreamReader(Properties.Resources.JsonFilename))
                {
                    var json = sr.ReadToEnd();
                    var finalObject = JsonConvert.DeserializeObject<Models.TrainerViewModel>(json);

                    if (finalObject == null)
                    {
                        MessageBox.Show(Properties.Resources.FileCannotBeRead, Properties.Resources.MessageFromProgrammerDude, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    ECCPU.gTrainerViewModel = finalObject;
                }

                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new DlgMain());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.MessageFromProgrammerDude, MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
    }
}

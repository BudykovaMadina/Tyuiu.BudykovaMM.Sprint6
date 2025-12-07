using Tyuiu.BudykovaMM.Sprint6.Task6.V23.Lib;
using System.IO;
namespace Tyuiu.BudykovaMM.Sprint6.Task6.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_BMM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BMM.ShowDialog();
            openFilePath = openFileDialogTask_BMM.FileName;
            textBoxData_BMM.Text = File.ReadAllText(openFilePath);
            buttonDone_BMM.Enabled = true;
        }

        private void buttonHelp_BMM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_BMM_Click(object sender, EventArgs e)
        {
            
            textBoxDone_BMM.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}

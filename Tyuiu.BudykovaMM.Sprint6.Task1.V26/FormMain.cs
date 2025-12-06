using System.IO;
using Tyuiu.BudykovaMM.Sprint6.Task1.V26.Lib;
namespace Tyuiu.BudykovaMM.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_BMM.Text);
                int stopStep = Convert.ToInt32(textBoxStop_BMM.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_BMM.Text = "";
                textBoxResult_BMM.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_BMM.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_BMM.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = string.Format("|{0,7:d}   |{1, 8:f2}  |", startStep, valueArray[i]);
                    textBoxResult_BMM.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_BMM.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BMM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ПИНб-25-1 Будыкова Мадина Маратовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.BudykovaMM.Sprint6.Task2.V7.Lib;
using System.IO;
namespace Tyuiu.BudykovaMM.Sprint6.Task2.V7
{
    public partial class FormMain_BMM : Form
    {
        public FormMain_BMM()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        private void buttonDone_BMM_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BMM.BackColor = Color.Red;
        }

        private void buttonDone_BMM_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BMM.BackColor = Color.Green;
        }

        private void buttonDone_BMM_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BMM.BackColor = Color.Blue;
        }

        private void buttonDone_BMM_Click(object sender, EventArgs e)
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
                this.chartFunction.Titles.Add("График функции");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
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

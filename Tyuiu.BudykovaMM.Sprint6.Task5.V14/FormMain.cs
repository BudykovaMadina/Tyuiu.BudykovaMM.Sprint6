using Tyuiu.BudykovaMM.Sprint6.Task5.V14.Lib;
using System.IO;
namespace Tyuiu.BudykovaMM.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V14.txt";
        private void buttonDone_BMM_Click(object sender, EventArgs e)
        {
            dataGridViewResult_BMM.ColumnCount = 2;
            dataGridViewResult_BMM.Columns[0].Width = 20;
            dataGridViewResult_BMM.Columns[1].Width = 50;
            this.chartFunction_BMM.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_BMM.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_BMM.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_BMM.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_BMM.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonFile_BMM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();

        }

        private void buttonHelp_BMM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ПИНб-25-1 Будыкова Мадина Маратовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

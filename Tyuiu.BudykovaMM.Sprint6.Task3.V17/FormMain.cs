using Tyuiu.BudykovaMM.Sprint6.Task3.V17.Lib;

namespace Tyuiu.BudykovaMM.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {
                { 22,  32, -16,  24,  27 },
                { 3,  -20,  24, -20,  25 },
                { 21,  17,  -8, -19,  17 },
                { 8,   22,  28,  27,  19 },
                { 11,  20,  12,  27,  29 }
            };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_BMM.ColumnCount = columns;
            dataGridViewMatrix_BMM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_BMM.Columns[i].Width = 40;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_BMM.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }


        private void buttonDone_BMM_Click(object sender, EventArgs e)
        {
            int[,] sortedMatrix = ds.Calculate(mtrx);

            textBoxResult_BMM.Clear();
            textBoxResult_BMM.AppendText("Отсортированная матрица (по 4-му столбцу):" + Environment.NewLine);
            textBoxResult_BMM.AppendText("4-й столбец выделен [ ]" + Environment.NewLine);
            textBoxResult_BMM.AppendText(new string('=', 40) + Environment.NewLine);

            int rows = sortedMatrix.GetLength(0);
            int cols = sortedMatrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                string row = "";
                for (int j = 0; j < cols; j++)
                {
                    if (j == 3) 
                        row += $"[{sortedMatrix[i, j],3}] ";
                    else
                        row += $"{sortedMatrix[i, j],4} ";
                }
                textBoxResult_BMM.AppendText(row + Environment.NewLine);
            }
        }

        private void buttonHelp_BMM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ПИНб-25-1 Будыкова Мадина Маратовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

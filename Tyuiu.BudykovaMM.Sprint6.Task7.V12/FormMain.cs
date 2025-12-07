using System.IO;
using Tyuiu.BudykovaMM.Sprint6.Task7.V12.Lib;
namespace Tyuiu.BudykovaMM.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_BMM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_BMM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] array = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    array[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return array;
        }

        private void buttonOpenFile_BMM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BMM.ShowDialog();
            openFilePath = openFileDialogTask_BMM.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);
            int rows = arrayValues.GetUpperBound(0) + 1;
            int colums = arrayValues.Length / rows;

            dataGridViewDataInput_BMM.ColumnCount = colums;
            dataGridViewDataInput_BMM.RowCount = rows;
            dataGridViewDataOutput_BMM.ColumnCount = rows;
            dataGridViewDataOutput_BMM.RowCount = colums;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewDataInput_BMM.Columns[i].Width = 25;
                dataGridViewDataOutput_BMM.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewDataInput_BMM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_BMM.Enabled = true;
        }

        private void buttonDone_BMM_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);
            int rows = arrayValues.GetUpperBound(0) + 1;
            int colums = arrayValues.Length / rows;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewDataOutput_BMM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_BMM.Enabled = true;
        }

        private void buttonSaveFile_BMM_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);

            saveFileDialogMatrix_BMM.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_BMM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BMM.ShowDialog();

            string path = saveFileDialogMatrix_BMM.FileName;

            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewDataOutput_BMM.RowCount;
            int columns = dataGridViewDataOutput_BMM.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewDataOutput_BMM.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewDataOutput_BMM.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewDataInput_BMM.ColumnCount = 50;
            dataGridViewDataOutput_BMM.ColumnCount = 50;

            dataGridViewDataOutput_BMM.RowCount = 50;
            dataGridViewDataInput_BMM.RowCount = 50;

            splitContainerData_BMM.Panel1.Width = this.Width / 2;
        }

        private void buttonOpenFile_BMM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BMM.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_BMM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BMM.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_BMM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BMM.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_BMM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_BMM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BMM.ToolTipTitle = "Справка";
        }
    }
}

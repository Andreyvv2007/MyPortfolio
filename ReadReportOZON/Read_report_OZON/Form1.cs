
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System.Data;
using System.Windows.Forms;

namespace ReadReportOZON
{
    public partial class Form1 : Form
    {
        // ������� ���� � ����� Excel
        string excelFilePath;// = "Otchet.xlsx";
        string[] data;

        public Form1()
        {
            InitializeComponent();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ��������� ���������� ���� ��� ������ ����� Excel
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                decimal nal1 = 0, nal2 = 0, sumNalAll = 0, sumAll = 0;

                excelFilePath = openFileDialog.FileName;
                // ��������� DataTable � DataGridView
                dataGridView1.DataSource = ReadExelFile.ReadExel(excelFilePath);
                data = ReadExelFile.ParseData();

                labelHeadMonthIn.Text = data[2];
                labelHeadYearIn.Text = data[3];
                labelSoldQuantityIn.Text = CreatDataTable.SoldQuantity.ToString();
                labelSoldAmountIn.Text = Math.Round(CreatDataTable.SoldAmount, 2).ToString();
                labelCommissionIn.Text = CreatDataTable.Commission.ToString();
                labelLogisticsIn.Text = CreatDataTable.Logistics.ToString();
                labelPaymentIn.Text = Math.Round(CreatDataTable.Payment, 2).ToString();

                nal1 = Math.Round(CreatDataTable.SoldAmount * (decimal)0.06, 2);
                nal2 = Math.Round(Decimal.Parse(textBox1.Text) / 12, 2);
                labelNalIn1.Text = nal1.ToString();
                labelNalIn2.Text = nal2.ToString();

                sumNalAll = Math.Round(nal1 + nal2, 2);
                sumAll = Math.Round(CreatDataTable.Payment - sumNalAll, 2);

                if (sumAll > 0) labelSumAllIn.ForeColor = Color.Green;
                if (sumAll < 0) labelSumAllIn.ForeColor = Color.Red;
                labelSumNalAllIn.Text = sumNalAll.ToString();
                labelSumAllIn.Text = sumAll.ToString();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
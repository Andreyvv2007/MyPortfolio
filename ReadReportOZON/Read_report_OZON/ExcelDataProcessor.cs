using OfficeOpenXml;
using System.Data;

namespace ReadReportOZON
{
    internal class ExcelDataProcessor
    {
        static DataTable _dataTable = new DataTable();

        static string _rowDataWithText = "01.1000";
        static ExcelWorksheet _worksheet;
        static int _rows;
        static int _cols;

        static List<string> _textToSearchForCells = new List<string> { "за период", "Товар", "Артикул", "Цена продавца", "Реализовано экземпляров", "Реализовано на сумму", "Сумма комиссии за продажу", "Расходы", "Расходы" };
        
        static int _сoordinateNameCellFromExcelTableRow;
        static int[] _сoordinateNameCellFromExcelTableColumn = new int[_textToSearchForCells.Count - 1];

        static string[] _columnNameDataGridTable = new string[_сoordinateNameCellFromExcelTableColumn.Length];


        public static DataTable ReadExcelIntoDataTable(string excelFilePath)
        {
            _ImportExcelDataToDataTable(excelFilePath);

            return _dataTable;
        }

        static void _ImportExcelDataToDataTable(string excelFilePath)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
                {
                    _worksheet = package.Workbook.Worksheets[0];

                    _rows = _worksheet.Dimension.Rows;
                    _cols = _worksheet.Dimension.Columns;

                    _SearchForInitialCellsAndColumns();

                    _dataTable = DataTableFactory.CreateDataTableWithColumns(_columnNameDataGridTable);

                    _SetDataValuesInDataTableFromExcelTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        static void _SearchForInitialCellsAndColumns()
        {
            for (_сoordinateNameCellFromExcelTableRow = 1; _сoordinateNameCellFromExcelTableRow < _rows && _textToSearchForCells.Count > 0; _сoordinateNameCellFromExcelTableRow++)
            {
                for (int j = 1; j < _cols; j++)
                {
                    if (_сoordinateNameCellFromExcelTableRow < 4)
                    {
                        _SearchCoordinatesOfACellWithADate(j);
                    }
                    else if (_textToSearchForCells.Count > 0)
                    {
                        _SearchCoordinatesOfACellWithName(j);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        static void _SearchCoordinatesOfACellWithADate(int column)
        {
            if (_worksheet.Cells[_сoordinateNameCellFromExcelTableRow, column].Text.IndexOf(_textToSearchForCells[0], 0) != -1)
            {
                _rowDataWithText = _worksheet.Cells[_сoordinateNameCellFromExcelTableRow, column].Text;

                _textToSearchForCells.RemoveAt(0);
                _сoordinateNameCellFromExcelTableRow += 12;
            }
        }

        static void _SearchCoordinatesOfACellWithName(int column)
        {
            for(int i = 0; i < _textToSearchForCells.Count; i++) 
            {
                if (_worksheet.Cells[_сoordinateNameCellFromExcelTableRow, column].Text.IndexOf(_textToSearchForCells[i], 0) != -1)
                {
                    int index = _columnNameDataGridTable.Length - _textToSearchForCells.Count;

                    _сoordinateNameCellFromExcelTableColumn[index] = column;
                    _columnNameDataGridTable[index] = _worksheet.Cells[_сoordinateNameCellFromExcelTableRow, column].Text;
                    
                    _textToSearchForCells.RemoveAt(i);

                    break;
                }
            }
        }

        static void _SetDataValuesInDataTableFromExcelTable()
        {
            for (int row = _сoordinateNameCellFromExcelTableRow; row <= _rows; row++)
            {
                if (!_worksheet.Cells[row, 2].Text.Equals("Итого"))
                {  
                    decimal num = Decimal.TryParse(_worksheet.Cells[row, _сoordinateNameCellFromExcelTableColumn[7]].Text, out num) ? num : num = 0;
                    
                    _dataTable.Rows.Add(DataTableFactory.AddRowAndUpdateStatistics(_dataTable, _columnNameDataGridTable,
                        _worksheet.Cells[row, _сoordinateNameCellFromExcelTableColumn[0]].Text,
                        _worksheet.Cells[row, _сoordinateNameCellFromExcelTableColumn[1]].Text,
                        Convert.ToDecimal(_worksheet.Cells[row, _сoordinateNameCellFromExcelTableColumn[2]].Value),
                        Convert.ToInt32(_worksheet.Cells[row, _сoordinateNameCellFromExcelTableColumn[3]].Value),
                        Convert.ToDecimal(_worksheet.Cells[row, _сoordinateNameCellFromExcelTableColumn[4]].Value),
                        Convert.ToDecimal(_worksheet.Cells[row, _сoordinateNameCellFromExcelTableColumn[5]].Value),
                        Convert.ToDecimal(_worksheet.Cells[row, _сoordinateNameCellFromExcelTableColumn[6]].Value), num));
                }
                else
                {
                    break;
                }
            }
        }

        public static string[] ParseDateToMonthYearArray()
        {
            string[] _monthYear = new string[4];
            
            string _date_txt = _rowDataWithText.Remove(0, _rowDataWithText.LastIndexOf('.') - 2);
            string[] _data = _date_txt.Split('.');
            
            _monthYear[0] = _data[0];
            int _numberMonth = Int32.Parse(_monthYear[0]);

            _monthYear[1] = ((_numberMonth + 2) / 3).ToString();
            _monthYear[2] = _ConvertMonthToString(_numberMonth);
            _monthYear[3] = _data[1];
            return _monthYear;
        }

        static string _ConvertMonthToString(int x)
        {
            switch (x)
            {
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "Март";
                case 4: return "Апрель";
                case 5: return "Май";
                case 6: return "Июнь";
                case 7: return "Июль";
                case 8: return "Август";
                case 9: return "Сентябрь";
                case 10: return "Октябрь";
                case 11: return "Ноябрь";
                case 12: return "Декабрь";
                default: return "Месяц не указан";
            }
        }
    }
}

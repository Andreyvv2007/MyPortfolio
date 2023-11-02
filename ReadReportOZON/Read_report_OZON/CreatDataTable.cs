using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace ReadReportOZON
{
    internal class CreatDataTable
    {
        public static decimal SoldQuantity { get; private set; }
        public static decimal SoldAmount { get; private set; }
        public static decimal Commission { get; private set; }
        public static decimal Logistics { get; private set; }
        public static decimal Payment { get; private set; }

        static string nameColumnAdd = "Прибыль с продажи (за шт.)";

        public static DataTable NewTable(string[] textArr)
        {
            DataTable dataTable = new DataTable("Resort");

            SoldQuantity = 0;
            SoldAmount = 0;
            Commission = 0;
            Logistics = 0;
            Payment = 0;

            DataColumn column;

            for(int i = 0; i <= textArr.Length; i++)
            {
                column = new DataColumn();
                if (i < 2) dataTable.Columns.Add(_Column_String(ref column, textArr[i]));
                else if (i == textArr.Length) dataTable.Columns.Add(_Column_Decimal(column, nameColumnAdd));
                else dataTable.Columns.Add(_Column_Decimal(column, textArr[i]));
            }
            return dataTable;
        }

        static DataColumn _Column_String(ref DataColumn column, string name)
        {
            column.DataType = Type.GetType("System.String");
            column.ColumnName = name;
            column.ReadOnly = true;
            //column.Unique = true;
            return column;
        }

        static DataColumn _Column_Decimal(DataColumn column, string name)
        {
            column.DataType = Type.GetType("System.Decimal");
            column.ColumnName = name;
            column.ReadOnly = true;
            //column.Unique = true;
            return column;
        }

        public static DataRow AddRow(DataTable dataTable, string[] arrName, string name, string article, decimal price, int quantity, decimal amount, decimal commission, decimal logistics, decimal logisticsReturn)
        {
            DataRow _row = dataTable.NewRow();
            decimal profit = (amount - (commission + logistics + logisticsReturn)) / quantity;

            _row[arrName[0]] = name;
            _row[arrName[1]] = article;
            _row[arrName[2]] = price;
            _row[arrName[3]] = quantity;
            _row[arrName[4]] = amount;
            _row[arrName[5]] = commission;
            _row[arrName[6]] = logistics;
            _row[arrName[7]] = logisticsReturn;
            _row[nameColumnAdd] = Math.Round(profit, 2);

            SoldQuantity += quantity;
            SoldAmount += amount;
            Commission += commission;
            Logistics += logistics + logisticsReturn;
            Payment += amount - (commission + logistics + logisticsReturn);

            return _row;
        }

    }
}


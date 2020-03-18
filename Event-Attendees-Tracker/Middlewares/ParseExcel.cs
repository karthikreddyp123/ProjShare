using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Event_Attendees_Tracker.Middlewares
{
    public class ParseExcel
    {
        //TODO:
        //Throw Exception
        public DataTable InsertTblRegisteredStudents(String FilePath)
        {
            DataTable dt = null;
            using (XLWorkbook workBook = new XLWorkbook(FilePath))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);
                //Create a new DataTable.
                dt = new DataTable();
                //Loop through the Worksheet rows.
                bool firstRow = true;
                foreach (IXLRow row in workSheet.Rows())
                {
                    if (!row.Cell(1).IsEmpty())
                    {
                        //Use the first row to add columns to DataTable.
                        if (firstRow)
                        {
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Columns.Add(cell.Value.ToString());
                            }
                            firstRow = false;
                        }

                        else
                        {
                            //Add rows to DataTable.
                            dt.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells(workSheet.FirstCellUsed().Address.ColumnNumber, workSheet.LastCellUsed().Address.ColumnNumber))
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                i++;
                            }

                        }
                    }

                }
            }
            return dt;
        }
    }
}
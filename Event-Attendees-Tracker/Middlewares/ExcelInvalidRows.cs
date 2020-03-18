using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Event_Attendees_Tracker.Middlewares
{
    public class ExcelInvalidRows
    {
        public static void InvalidRows(string FilePath,Dictionary<string,string> studentList)
        {
            using (XLWorkbook workBook = new XLWorkbook(FilePath))
            {
                IXLWorksheet ws = workBook.Worksheet(1);
                foreach (IXLRow row in ws.Rows())
                {
                    String temp = row.Cell(4).Value.ToString();
                    if (studentList.ContainsKey(row.Cell(4).Value.ToString()))
                    {
                        if (studentList[row.Cell(4).Value.ToString()].Equals("Invalid Data"))
                        {
                            row.Cell(7).Value = studentList[row.Cell(4).Value.ToString()];
                            row.Cell(7).Style.Fill.BackgroundColor = XLColor.Red;
                        }
                    }
                }
                string excelFilePath = System.Web.HttpContext.Current.Server.MapPath($@"~/OutputExcel/");
                workBook.SaveAs(excelFilePath + "LogExcel" + ".xlsx");
            }
        }
    }
}
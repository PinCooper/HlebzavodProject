using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;


namespace Hlebzavod_Project
{
    class SupportClass
    {
        public static void SaveInExcel (DataGridView e, string path)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Worksheets.get_Item(1);
            for (int j = 0; j < e.ColumnCount; j++)
            {
                app.Cells[1, j + 1] = e.Columns[j].HeaderText;
            }
            for (int i = 0; i < e.RowCount; i++)
            {
                for (int j = 0; j < e.ColumnCount; j++)
                {
                    app.Cells[i + 2, j + 1] = e.Rows[i].Cells[j].Value;
                }
            }
            workbook.SaveAs(path);
            workbook.Close();
            MessageBox.Show("Файл успешно сохранён!");
            app = null;
            workbook = null;
            worksheet = null;
        }            
    }
}

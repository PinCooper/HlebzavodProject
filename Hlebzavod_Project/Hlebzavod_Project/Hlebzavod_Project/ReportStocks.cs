using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hlebzavod_Project
{
    public partial class ReportStocks : Form
    {
        SqlConnection sqlcon = new SqlConnection(PlaceForm.server);
        DataTable BakeryTable = new DataTable();
        SqlDataAdapter PlacesAdapt;

        public ReportStocks()
        {
            InitializeComponent();
        }

        private void ReportStocks_Shown(object sender, EventArgs e)
        {
            checkTime.Checked = true;
        }

        private void checkTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTime.Checked == true)
            {
                dateStart.Enabled = false;
                dateEnd.Enabled = false;
            }
            else
            {
                dateStart.Enabled = true;
                dateEnd.Enabled = true;
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            try
            {
                DGResult.Rows.Clear();
                DGResult.Columns.Clear();
                sqlcon.Open();
                string query;
                if (checkTime.Checked == true)
                {
                    query = "(SELECT T1.Id_Item, T2.Name, T1.Прибыло_на_склад FROM " +
                    "(SELECT Operations.Id_Item, SUM(Quantity) AS Прибыло_на_склад FROM Operations WHERE  Operations.Where_Id=2 GROUP BY Operations.Id_Item) T1, " +
                    "(SELECT Items.Id_Item, Items.Name FROM Items) T2 " +
                    "WHERE T2.Id_Item=T1.Id_Item) " +
                    "UNION " +
                    "(SELECT T1.Id_Item, T2.Name, T1.Убыло_со_склада FROM " +
                    "(SELECT Operations.Id_Item, SUM(Quantity)*(-1) AS Убыло_со_склада FROM Operations WHERE  Operations.From_Id=2 GROUP BY Operations.Id_Item) T1, " +
                    "(SELECT Items.Id_Item, Items.Name FROM Items) T2 " +
                    "WHERE T2.Id_Item=T1.Id_Item)";
                }
                else
                {
                    query = "(SELECT T1.Id_Item, T2.Name, T1.Прибыло_на_склад FROM " +
                    "(SELECT Operations.Id_Item, SUM(Quantity) AS Прибыло_на_склад FROM Operations WHERE  Operations.Where_Id=2 AND Operations.Date BETWEEN '" + dateStart.Value.ToShortDateString() + "' AND '" + dateEnd.Value.ToShortDateString() + "' GROUP BY Operations.Id_Item) T1, " +
                    "(SELECT Items.Id_Item, Items.Name FROM Items) T2 " +
                    "WHERE T2.Id_Item=T1.Id_Item) " +
                    "UNION " +
                    "(SELECT T1.Id_Item, T2.Name, T1.Убыло_со_склада FROM " +
                    "(SELECT Operations.Id_Item, SUM(Quantity)*(-1) AS Убыло_со_склада FROM Operations WHERE  Operations.From_Id=2 AND Operations.Date BETWEEN '" + dateStart.Value.ToShortDateString() + "' AND '" + dateEnd.Value.ToShortDateString() + "' GROUP BY Operations.Id_Item) T1, " +
                    "(SELECT Items.Id_Item, Items.Name FROM Items) T2 " +
                    "WHERE T2.Id_Item=T1.Id_Item)";
                }                
                SqlCommand command = new SqlCommand(query, sqlcon);
                PlacesAdapt = new SqlDataAdapter(command);
                BakeryTable.Clear();
                PlacesAdapt.Fill(BakeryTable);
                DGAll.DataSource = BakeryTable.DefaultView;
                DGAll.Columns[0].Visible = false;
                DGAll.Columns[1].HeaderText = "Название";
                DGAll.Columns[2].HeaderText = "Прибыло/убыло (кг)";
                sqlcon.Close();
                DGResult.Columns.Add("Название", "Название");
                DGResult.Columns.Add("Итого", "Итого");
                List<string> listItems = new List<string>();
                List<int> listQuantity = new List<int>();
                foreach (DataGridViewRow row in DGAll.Rows) 
                {
                    if (listItems.Contains(DGAll[1, row.Index].Value.ToString()) == false)
                    {
                        listItems.Add(DGAll[1, row.Index].Value.ToString());
                        listQuantity.Add(Convert.ToInt32(DGAll[2, row.Index].Value));
                    }
                    else 
                    {
                        listQuantity[listItems.IndexOf(DGAll[1, row.Index].Value.ToString())] = listQuantity[listItems.IndexOf(DGAll[1, row.Index].Value.ToString())] + Convert.ToInt32(DGAll[2, row.Index].Value);
                    }
                }
                for (int i = 0; i < listItems.Count; i++)
                {
                    DGResult.Rows.Add(listItems[i], listQuantity[i]);
                }                               
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение");
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }        
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.xls";
            saveFileDialog1.Filter = "xls files (*.xls)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                SupportClass.SaveInExcel(DGResult, filename);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

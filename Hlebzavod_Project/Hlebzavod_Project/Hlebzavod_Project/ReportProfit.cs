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
    public partial class ReportProfit : Form
    {
        SqlConnection sqlcon = new SqlConnection(PlaceForm.server);
        DataTable BakeryTable = new DataTable();
        SqlDataAdapter PlacesAdapt;

        public ReportProfit()
        {
            InitializeComponent();
        }

        private void ReportProfit_Shown(object sender, EventArgs e)
        {
            checkTime.Checked = true;
            txtProfit.Enabled = false;
            txtMinus.Enabled = false;
            txtAll.Enabled = false;
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
                sqlcon.Open();
                string query;
                if (checkTime.Checked == true)
                {
                    query = "SELECT Operations.Id_Item, Items.Name, Operations.Quantity, Items.Price, Operations.Quantity*Items.Price AS Доход, Operations.Date  FROM Operations, Items WHERE Operations.Id_Item=Items.Id_Item AND Operations.Id_Operation_Type=2 " +
                        "UNION " +
                        "SELECT Operations.Id_Item, Items.Name, Operations.Quantity, Items.Price, Operations.Quantity*Items.Price*(-1) AS Расход, Operations.Date  FROM Operations, Items WHERE Operations.Id_Item=Items.Id_Item AND Operations.Id_Operation_Type=1 ";
                }
                else
                {
                    query = "SELECT Operations.Id_Item, Items.Name, Operations.Quantity, Items.Price, Operations.Quantity*Items.Price AS Доход, Operations.Date  FROM Operations, Items WHERE Operations.Id_Item=Items.Id_Item AND Operations.Id_Operation_Type=2 AND Operations.Date BETWEEN '" + dateStart.Value.ToShortDateString() + "' AND '" + dateEnd.Value.ToShortDateString() + "'" +
                        "UNION " +
                        "SELECT Operations.Id_Item, Items.Name, Operations.Quantity, Items.Price, Operations.Quantity*Items.Price*(-1) AS Расход, Operations.Date  FROM Operations, Items WHERE Operations.Id_Item=Items.Id_Item AND Operations.Id_Operation_Type=1 AND Operations.Date BETWEEN '" + dateStart.Value.ToShortDateString() + "' AND '" + dateEnd.Value.ToShortDateString() + "'";
                }
                SqlCommand command = new SqlCommand(query, sqlcon);
                PlacesAdapt = new SqlDataAdapter(command);
                BakeryTable.Clear();
                PlacesAdapt.Fill(BakeryTable);
                DGResult.DataSource = BakeryTable.DefaultView;
                DGResult.Columns[0].Visible = false;
                DGResult.Columns[1].HeaderText = "Название";
                DGResult.Columns[2].HeaderText = "Кол-во (кг)";
                DGResult.Columns[3].HeaderText = "Цена за кг";
                DGResult.Columns[4].HeaderText = "Доход/расход";
                DGResult.Columns[5].HeaderText = "Дата";
                sqlcon.Close();
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
            double profit, minus, all;
            profit = 0;
            minus = 0;
            all = 0;
            foreach (DataGridViewRow row in DGResult.Rows)
            {
                if (Convert.ToInt32(DGResult[4, row.Index].Value) > 0)
                {
                    profit = profit + Convert.ToDouble(DGResult[4, row.Index].Value);
                }
                else
                {
                    minus = minus + Convert.ToDouble(DGResult[4, row.Index].Value);
                }
            }
            all = profit + minus;
            txtAll.Text = all.ToString();
            txtMinus.Text = minus.ToString();
            txtProfit.Text = profit.ToString();
            txtProfit.Enabled = true;
            txtMinus.Enabled = true;
            txtAll.Enabled = true;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

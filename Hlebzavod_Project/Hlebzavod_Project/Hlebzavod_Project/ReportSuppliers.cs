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
    public partial class ReportSuppliers : Form
    {
        SqlConnection sqlcon = new SqlConnection(PlaceForm.server);
        DataTable BakeryTable = new DataTable();
        DataTable SuupliersTable = new DataTable();
        SqlDataAdapter PlacesAdapt;
        List<int> SuppliersList = new List<int>();

        public ReportSuppliers()
        {
            InitializeComponent();
        }

        private void ReportSuppliers_Shown(object sender, EventArgs e)
        {
            checkTime.Checked = true;
            try
            {
                sqlcon.Open();
                string queryItems = "SELECT DISTINCT Operations.From_Id, Places.Name FROM Operations, Places WHERE Operations.From_Id=Places.Id_Place AND Operations.Id_Operation_Type=1";
                SqlCommand command1 = new SqlCommand(queryItems, sqlcon);
                SqlDataAdapter ClientsAdapt1 = new SqlDataAdapter(command1);
                ClientsAdapt1.Fill(SuupliersTable);
                for (int i = 0; i < SuupliersTable.Rows.Count; i++)
                {
                    cbSuppliers.Items.Add(SuupliersTable.Rows[i].Field<string>("Name"));
                    SuppliersList.Add(SuupliersTable.Rows[i].Field<int>("From_Id"));
                }
                cbSuppliers.Items.Add("Все");
                cbSuppliers.SelectedItem = "Все";
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
                string queryAddition;
                if (cbSuppliers.SelectedItem.ToString() == "Все")
                {
                    queryAddition = "";
                }
                else
                {
                    queryAddition = "AND Operations.From_Id=" + SuppliersList[cbSuppliers.SelectedIndex].ToString();
                }
                if (checkTime.Checked == true)
                {
                    query = "SELECT Operations.Id_Operation, Operations.Id_Operation_Type, Operations.From_Id, Places.Name, Places.Address, Operations.Id_Item, Items.Name, Operations.Quantity, Operations.Date  " +
                    "FROM Operations, Places, Items  " +
                    "WHERE Operations.From_Id=Places.Id_Place AND Operations.Id_Operation_Type=1 AND Operations.Id_Item=Items.Id_Item " + queryAddition;
                }
                else
                {
                    query = "SELECT Operations.Id_Operation, Operations.Id_Operation_Type, Operations.From_Id, Places.Name, Places.Address, Operations.Id_Item, Items.Name, Operations.Quantity, Operations.Date  " +
                    "FROM Operations, Places, Items " +
                    "WHERE Operations.From_Id=Places.Id_Place AND Operations.Id_Operation_Type=1 AND Operations.Id_Item=Items.Id_Item AND Operations.Date BETWEEN '" + dateStart.Value.ToShortDateString() + "' AND '" + dateEnd.Value.ToShortDateString() + "' " + queryAddition;
                }
                SqlCommand command = new SqlCommand(query, sqlcon);
                PlacesAdapt = new SqlDataAdapter(command);
                BakeryTable.Clear();
                PlacesAdapt.Fill(BakeryTable);
                DGSuppliers.DataSource = BakeryTable.DefaultView;
                DGSuppliers.Columns[0].Visible = false;
                DGSuppliers.Columns[1].Visible = false;
                DGSuppliers.Columns[2].Visible = false;
                DGSuppliers.Columns[3].HeaderText = "Поставщик";
                DGSuppliers.Columns[4].HeaderText = "Адрес";
                DGSuppliers.Columns[5].Visible = false;
                DGSuppliers.Columns[6].HeaderText = "Наименование";
                DGSuppliers.Columns[7].HeaderText = "Кол-во";
                DGSuppliers.Columns[8].HeaderText = "Дата";
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
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.xls";
            saveFileDialog1.Filter = "xls files (*.xls)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                SupportClass.SaveInExcel(DGSuppliers, filename);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

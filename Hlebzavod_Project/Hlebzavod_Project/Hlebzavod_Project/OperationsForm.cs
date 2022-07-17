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
    public partial class OperationsForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(PlaceForm.server);
        DataTable BakeryTable = new DataTable();
        DataTable ItemTable = new DataTable();
        DataTable PlaceTable = new DataTable();
        DataTable OperationTypeTable = new DataTable();
        SqlDataAdapter PlacesAdapt;
        List<int> ItemList = new List<int>();
        List<int> PlaceList = new List<int>();
        List<int> OperationTypeList = new List<int>();

        private void OperationsForm_Shown(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "SELECT T1.Id_Operation, T1.Id_Operation_Type, T1.Name, T1.From_Id, T1.Куда, T2.Where_Id, T2.Name, T3.Id_Item, T3.Name, T3.Quantity, T3.Date FROM " +
                    "(SELECT Operations.Id_Operation, Operations.Id_Operation_Type, Operations_Types.Name, Operations.From_Id, Places.Name AS Куда " +
                    "FROM Operations, Places, Operations_Types " +
                    "WHERE Operations.Id_Operation_Type = Operations_Types.Id_Operation_Type AND Operations.From_Id=Places.Id_Place " +
                    ") T1, " +
                    "(SELECT Operations.Id_Operation, Operations.Where_Id, Places.Name " +
                    "FROM Operations, Places " +
                    "WHERE Operations.Where_Id = Places.Id_Place " +
                    ") T2, " +
                    "(SELECT Operations.Id_Operation, Operations.Id_Item, Items.Name, Operations.Quantity, Operations.Date " +
                    "FROM Operations, Items " +
                    "WHERE Operations.Id_Item=Items.Id_Item " +
                    ") T3 " +
                    "WHERE T1.Id_Operation=T2.Id_Operation AND T1.Id_Operation=T3.Id_Operation ";
                SqlCommand command = new SqlCommand(query, sqlcon);
                PlacesAdapt = new SqlDataAdapter(command);
                PlacesAdapt.Fill(BakeryTable);
                string queryItems = "SELECT Items.Id_Item, Items.Name FROM Items";
                SqlCommand command1 = new SqlCommand(queryItems, sqlcon);
                SqlDataAdapter ClientsAdapt1 = new SqlDataAdapter(command1);
                ClientsAdapt1.Fill(ItemTable);
                for (int i = 0; i < ItemTable.Rows.Count; i++)
                {
                    cbItems.Items.Add(ItemTable.Rows[i].Field<string>("Name"));
                    ItemList.Add(ItemTable.Rows[i].Field<int>("Id_Item"));
                }
                string queryPlaces = "SELECT Places.Id_Place, Places.Name FROM Places";
                SqlCommand command2 = new SqlCommand(queryPlaces, sqlcon);
                SqlDataAdapter ClientsAdapt2 = new SqlDataAdapter(command2);
                ClientsAdapt2.Fill(PlaceTable);
                for (int i = 0; i < PlaceTable.Rows.Count; i++)
                {
                    cbFrom.Items.Add(PlaceTable.Rows[i].Field<string>("Name"));
                    cbWhere.Items.Add(PlaceTable.Rows[i].Field<string>("Name"));
                    PlaceList.Add(PlaceTable.Rows[i].Field<int>("Id_Place"));
                }
                string queryOperation_Types = "SELECT Operations_Types.Id_Operation_Type, Operations_Types.Name FROM Operations_Types";
                SqlCommand command3 = new SqlCommand(queryOperation_Types, sqlcon);
                SqlDataAdapter ClientsAdapt3 = new SqlDataAdapter(command3);
                ClientsAdapt3.Fill(OperationTypeTable);
                for (int i = 0; i < OperationTypeTable.Rows.Count; i++)
                {
                    cbOperation_Types.Items.Add(OperationTypeTable.Rows[i].Field<string>("Name"));
                    OperationTypeList.Add(OperationTypeTable.Rows[i].Field<int>("Id_Operation_Type"));
                }
                DGOperations.DataSource = BakeryTable.DefaultView;
                DGOperations.Columns[0].Visible = false;
                DGOperations.Columns[1].Visible = false;
                DGOperations.Columns[3].Visible = false;
                DGOperations.Columns[5].Visible = false;
                DGOperations.Columns[7].Visible = false;
                DGOperations.Columns[2].HeaderText = "Тип операции";
                DGOperations.Columns[4].HeaderText = "Откуда";
                DGOperations.Columns[6].HeaderText = "Куда";
                DGOperations.Columns[8].HeaderText = "Товар/сырьё";
                DGOperations.Columns[9].HeaderText = "Кол-во (кг)";
                DGOperations.Columns[10].HeaderText = "Дата";
                for (int i = 0; i < DGOperations.Columns.Count; i++)
                {
                    DGOperations.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
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

        private void DGOperations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNumber.Text = DGOperations[9, DGOperations.SelectedRows[0].Index].Value.ToString();
                cbItems.SelectedItem = DGOperations[8, DGOperations.SelectedRows[0].Index].Value;
                cbFrom.SelectedItem = DGOperations[4, DGOperations.SelectedRows[0].Index].Value;
                cbWhere.SelectedItem = DGOperations[6, DGOperations.SelectedRows[0].Index].Value;
                cbOperation_Types.SelectedItem = DGOperations[2, DGOperations.SelectedRows[0].Index].Value;
                dateOperation.Value = Convert.ToDateTime(DGOperations[10, DGOperations.SelectedRows[0].Index].Value);
            }            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "INSERT INTO Operations(Id_Operation_Type, From_Id, Where_Id, Id_Item, Quantity, Date) VALUES(" + OperationTypeList[cbOperation_Types.SelectedIndex] + ", " + PlaceList[cbFrom.SelectedIndex] + ", " + PlaceList[cbWhere.SelectedIndex] + ", " + ItemList[cbItems.SelectedIndex] + ", '" + txtNumber.Text + "', '" + dateOperation.Value.ToShortDateString() + "')";
                SqlCommand command = new SqlCommand(query, sqlcon);
                command.ExecuteNonQuery();
                BakeryTable.Clear();
                PlacesAdapt.Fill(BakeryTable);
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение или загрузить данные");
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string Id_Operation = DGOperations[0, DGOperations.SelectedRows[0].Index].Value.ToString();
                string query = "UPDATE Operations SET Id_Operation_Type=" + OperationTypeList[cbOperation_Types.SelectedIndex] + ", From_Id=" + PlaceList[cbFrom.SelectedIndex] + ", Where_Id=" + PlaceList[cbWhere.SelectedIndex] + ", Id_Item= " + ItemList[cbItems.SelectedIndex] + ", Quantity= '" + txtNumber.Text + "', Date='" + dateOperation.Value.ToShortDateString() + "' WHERE Id_Operation=" + Id_Operation;
                SqlCommand command = new SqlCommand(query, sqlcon);
                command.ExecuteNonQuery();
                BakeryTable.Clear();
                PlacesAdapt.Fill(BakeryTable);
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение или обновить данные");
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string Id_Operation = DGOperations[0, DGOperations.SelectedRows[0].Index].Value.ToString();
                string query = "DELETE FROM Operations WHERE Id_Operation = " + Id_Operation;
                SqlCommand command = new SqlCommand(query, sqlcon);
                command.ExecuteNonQuery();
                BakeryTable.Clear();
                PlacesAdapt.Fill(BakeryTable);
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение или удалить данные");
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }

        public OperationsForm()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlaceForm placeForm = new PlaceForm();
            placeForm.Show();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarehouseForm werehouseForm = new WarehouseForm();
            werehouseForm.Show();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperationsTypesForm operationsTypesForm = new OperationsTypesForm();
            operationsTypesForm.Show();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpertisesForm expertisesForm = new ExpertisesForm();
            expertisesForm.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.xls";
            saveFileDialog1.Filter = "xls files (*.xls)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                SupportClass.SaveInExcel(DGOperations, filename);
            }
        }

        private void остаткиНаСкладеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportStocks reportStocks = new ReportStocks();
            reportStocks.ShowDialog();
        }

        private void доходыРасходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportProfit reportProfit = new ReportProfit();
            reportProfit.ShowDialog();
        }

        private void OperationsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void закрытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSuppliers reportSuppliers = new ReportSuppliers();
            reportSuppliers.ShowDialog();
        }
    }
}

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
    public partial class OperationsTypesForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(PlaceForm.server);
        DataTable BakeryTable = new DataTable();
        SqlDataAdapter PlacesAdapt;

        private void OperationsTypesForm_Shown(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "SELECT * FROM Operations_Types";
                SqlCommand command = new SqlCommand(query, sqlcon);
                PlacesAdapt = new SqlDataAdapter(command);
                PlacesAdapt.Fill(BakeryTable);
                DGOperationTypes.DataSource = BakeryTable.DefaultView;
                DGOperationTypes.Columns[0].Visible = false;
                DGOperationTypes.Columns[1].HeaderText = "Тип операции";
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

        private void DGOperationTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = DGOperationTypes[1, DGOperationTypes.SelectedRows[0].Index].Value.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "INSERT INTO Operations_Types(Name) VALUES('" + txtName.Text + "')";
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
                string Id_Operation_Type = DGOperationTypes[0, DGOperationTypes.SelectedRows[0].Index].Value.ToString();
                string query = "UPDATE Operations_Types SET Name='" + txtName.Text + "' WHERE Id_Operation_Type=" + Id_Operation_Type;
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
                string Id_Operation_Type = DGOperationTypes[0, DGOperationTypes.SelectedRows[0].Index].Value.ToString();
                string query = "DELETE FROM Operations_Types WHERE Id_Operation_Type = " + Id_Operation_Type;
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

        public OperationsTypesForm()
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

        private void bt3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperationsForm operationsForm = new OperationsForm();
            operationsForm.Show();
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
                SupportClass.SaveInExcel(DGOperationTypes, filename);
            }
        }

        private void остаткиНаСкладеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportStocks reportStocks = new ReportStocks();
            reportStocks.ShowDialog();
        }

        private void доходыИРасходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportProfit reportProfit = new ReportProfit();
            reportProfit.ShowDialog();
        }

        private void OperationsTypesForm_FormClosing(object sender, FormClosingEventArgs e)
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

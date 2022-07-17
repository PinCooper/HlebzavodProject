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
    public partial class WarehouseForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(PlaceForm.server);
        DataTable BakeryTable = new DataTable();
        SqlDataAdapter PlacesAdapt;

        private void WarehouseForm_Shown(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "SELECT * FROM Items";
                SqlCommand command = new SqlCommand(query, sqlcon);
                PlacesAdapt = new SqlDataAdapter(command);
                PlacesAdapt.Fill(BakeryTable);
                DGItems.DataSource = BakeryTable.DefaultView;
                DGItems.Columns[0].Visible = false;
                DGItems.Columns[1].HeaderText = "Наименование";
                DGItems.Columns[2].HeaderText = "Цена (кг)";
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

        private void DGItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = DGItems[1, DGItems.SelectedRows[0].Index].Value.ToString();
            txtPrice.Text = DGItems[2, DGItems.SelectedRows[0].Index].Value.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "INSERT INTO Items(Name, Price) VALUES('" + txtName.Text + "', '" + txtPrice.Text + "')";
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
                string Id_Item = DGItems[0, DGItems.SelectedRows[0].Index].Value.ToString();
                string query = "UPDATE Items SET Name='" + txtName.Text + "', Price=" + txtPrice.Text + " WHERE Id_Item=" + Id_Item;
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
                string Id_Item = DGItems[0, DGItems.SelectedRows[0].Index].Value.ToString();
                string query = "DELETE FROM Items WHERE Id_Item = " + Id_Item;
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

        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlaceForm placeForm = new PlaceForm();
            placeForm.Show();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperationsForm operationsForm = new OperationsForm();
            operationsForm.Show();
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

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.xls";
            saveFileDialog1.Filter = "xls files (*.xls)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                SupportClass.SaveInExcel(DGItems, filename);
            }
        }

        private void остаткиНаСкладеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportStocks reportStocks = new ReportStocks();
            reportStocks.ShowDialog();
        }

        private void доходрасходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportProfit reportProfit = new ReportProfit();
            reportProfit.ShowDialog();
        }

        private void WarehouseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cjToolStripMenuItem_Click(object sender, EventArgs e)
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

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
    public partial class PlaceForm : Form
    {
        public static string server = @"Data Source = .\SQLEXPRESS; Initial Catalog = BakeryDB; Integrated Security = true";
        SqlConnection sqlcon = new SqlConnection(server);
        DataTable BakeryTable = new DataTable();
        SqlDataAdapter PlacesAdapt;

        private void PlaceForm_Shown(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "SELECT * FROM Places";
                SqlCommand command = new SqlCommand(query, sqlcon);
                PlacesAdapt = new SqlDataAdapter(command);
                PlacesAdapt.Fill(BakeryTable);
                DGPlaces.DataSource = BakeryTable.DefaultView;
                DGPlaces.Columns[0].Visible = false;
                DGPlaces.Columns[1].HeaderText = "Название";
                DGPlaces.Columns[2].HeaderText = "Адрес";
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

        private void DGPlaces_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = DGPlaces[1, DGPlaces.SelectedRows[0].Index].Value.ToString();
            txtAddress.Text = DGPlaces[2, DGPlaces.SelectedRows[0].Index].Value.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "INSERT INTO Places(Name, Address) VALUES('" + txtName.Text + "','" + txtAddress.Text + "')";
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
            string Id_Places = DGPlaces[0, DGPlaces.SelectedRows[0].Index].Value.ToString();
            string query = "UPDATE Places SET Name='" + txtName.Text + "', Address='" + txtAddress.Text + "' WHERE Id_Place=" + Id_Places;
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
                string Id_Place = DGPlaces[0, DGPlaces.SelectedRows[0].Index].Value.ToString();
                string query = "DELETE FROM Places WHERE Id_Place = " + Id_Place;
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

        public PlaceForm()
        {
            InitializeComponent();
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
                SupportClass.SaveInExcel(DGPlaces, filename);
            }
        }

        private void остаткиНаСкладеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportStocks reportStocks = new ReportStocks();
            reportStocks.ShowDialog();
        }

        private void прибыльToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportProfit reportProfit = new ReportProfit();
            reportProfit.ShowDialog();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSuppliers reportSuppliers = new ReportSuppliers();
            reportSuppliers.ShowDialog();
        }

        private void PlaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

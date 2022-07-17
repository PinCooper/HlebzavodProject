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
    public partial class ExpertisesForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(PlaceForm.server);
        DataTable BakeryTable = new DataTable();
        DataTable ItemTable = new DataTable();
        SqlDataAdapter PlacesAdapt;
        List<int> ItemList = new List<int>();

        private void ExpertisesForm_Shown(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "SELECT Expertises.Id_Expertise, Expertises.Id_Item, Items.Name, Expertises.Reason, Expertises.Result, Expertises.Date FROM Expertises, Items WHERE Expertises.Id_Item=Items.Id_Item";
                SqlCommand command = new SqlCommand(query, sqlcon);
                PlacesAdapt = new SqlDataAdapter(command);
                PlacesAdapt.Fill(BakeryTable);
                DGExpertises.DataSource = BakeryTable.DefaultView;
                DGExpertises.Columns[0].Visible = false;
                DGExpertises.Columns[1].Visible = false;
                DGExpertises.Columns[2].HeaderText = "Наименование";
                DGExpertises.Columns[3].HeaderText = "Причина";
                DGExpertises.Columns[4].HeaderText = "Результат";
                DGExpertises.Columns[5].HeaderText = "Дата";
                string queryItems = "SELECT Items.Id_Item, Items.Name FROM Items";
                SqlCommand command1 = new SqlCommand(queryItems, sqlcon);
                SqlDataAdapter ClientsAdapt1 = new SqlDataAdapter(command1);
                ClientsAdapt1.Fill(ItemTable);
                for (int i = 0; i < ItemTable.Rows.Count; i++)
                {
                    cbItems.Items.Add(ItemTable.Rows[i].Field<string>("Name"));
                    ItemList.Add(ItemTable.Rows[i].Field<int>("Id_Item"));
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

        private void DGExpertises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtReason.Text = DGExpertises[3, DGExpertises.SelectedRows[0].Index].Value.ToString();
            txtResult.Text = DGExpertises[4, DGExpertises.SelectedRows[0].Index].Value.ToString();
            cbItems.SelectedItem = DGExpertises[2, DGExpertises.SelectedRows[0].Index].Value;
            dataExpertise.Value = Convert.ToDateTime(DGExpertises[5, DGExpertises.SelectedRows[0].Index].Value);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "INSERT INTO Expertises(Id_Item, Reason, Result, Date) VALUES(" + ItemList[cbItems.SelectedIndex] + ", '" + txtReason.Text + "', '" + txtResult.Text + "', '" + dataExpertise.Value.ToShortDateString() + "')";
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
                string Id_Expertise = DGExpertises[0, DGExpertises.SelectedRows[0].Index].Value.ToString();
                string query = "UPDATE Expertises SET Id_Item=" + ItemList[cbItems.SelectedIndex] + ", Reason='" + txtReason.Text + "', Result='" + txtResult.Text + "', Date='" + dataExpertise.Value.ToShortDateString() + "' WHERE Id_Expertise=" + Id_Expertise;
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
                string Id_Expertise = DGExpertises[0, DGExpertises.SelectedRows[0].Index].Value.ToString();
                string query = "DELETE FROM Expertises WHERE Id_Expertise = " + Id_Expertise;
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

        public ExpertisesForm()
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

        private void bt4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperationsTypesForm operationsTypesForm = new OperationsTypesForm();
            operationsTypesForm.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.xls";
            saveFileDialog1.Filter = "xls files (*.xls)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                SupportClass.SaveInExcel(DGExpertises, filename);
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

        private void ExpertisesForm_FormClosing(object sender, FormClosingEventArgs e)
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

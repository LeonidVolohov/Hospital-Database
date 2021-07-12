using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Data.Common;
using HospitalDataBase;
using System.Data;
using System.Drawing;

namespace HospitalDataBase {
    public partial class WardsTable : MetroForm {
        public WardsTable() {
            InitializeComponent();

            try {
                /*String query = "SELECT wards.idwards AS Id, wards.wardsname AS Name, wards.wardsmaxcount AS MaxCount, COUNT(people.idpeople) AS AmountPatiens " +
                        "FROM wards, people WHERE people.idward = wards.idwards " +
                            "GROUP BY wards.wardsmaxcount, wards.wardsname, wards.idwards " +
                                "ORDER BY COUNT(people.idpeople) ASC";*/

                String query = "Select * from wards";

                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();
                OracleCommand oracleCommand = connection.CreateCommand();
                oracleCommand.CommandText = query;

                connection.Open();

                OracleDataReader reader = oracleCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridViewWadrs.DataSource = dataTable;
                dataGridViewWadrs.Font = new Font("Century Gothic", 16F, GraphicsUnit.Pixel);
                dataGridViewWadrs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewWadrs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                connection.Close();
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e) {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void buttonAddNewWard_Click(object sender, EventArgs e) {
            this.Hide();
            AddNewWard addNewWard = new AddNewWard();
            addNewWard.ShowDialog();
            this.Close();
        }

        private void buttonDeleteWard_Click(object sender, EventArgs e) {
            try {
                int currentRow = dataGridViewWadrs.CurrentCell.RowIndex;
                string wardsId = dataGridViewWadrs.SelectedRows[0].Cells[0].Value.ToString();

                dataGridViewWadrs.Rows.RemoveAt(currentRow);

                String query = "DELETE FROM wards WHERE wards.idwards = :idwards";

                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();

                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                OracleCommand oracleCommand = connection.CreateCommand();
                oracleCommand.CommandText = query;

                oracleCommand.Parameters.Add("idwards", wardsId);

                connection.Open();
                oracleCommand.ExecuteNonQuery();
                connection.Close();

            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Data.Common;
using HospitalDataBase;
using System.Data;
using System.Drawing;

namespace HospitalDataBase {
    public partial class DiagnosisTable : MetroForm {
                
        public DiagnosisTable() {
            InitializeComponent();
            
            try {
                String query = "SELECT * FROM diagnosis";

                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();
                OracleCommand oracleCommand = connection.CreateCommand();
                oracleCommand.CommandText = query;

                connection.Open();

                OracleDataReader reader = oracleCommand.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridViewDiagnosis.DataSource = dataTable;
                dataGridViewDiagnosis.Font = new Font("Century Gothic", 16F, GraphicsUnit.Pixel);
                dataGridViewDiagnosis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDiagnosis.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                connection.Close();
            } catch(Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonAddNewDiagnosis_Click(object sender, EventArgs e) {
            this.Hide();
            AddNewDiagnosis addNewDiagnosis = new AddNewDiagnosis();
            addNewDiagnosis.ShowDialog();
            this.Close();
        }

        private void buttonDeleteDiagnosis_Click(object sender, EventArgs e) {
            try {
                int currentRow = dataGridViewDiagnosis.CurrentCell.RowIndex;
                string diagnosisId = dataGridViewDiagnosis.SelectedRows[0].Cells[0].Value.ToString();

                dataGridViewDiagnosis.Rows.RemoveAt(currentRow);

                String query = "DELETE FROM diagnosis WHERE diagnosis.iddiagnosis = :iddiagnosis";

                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();

                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                OracleCommand oracleCommand = connection.CreateCommand();
                oracleCommand.CommandText = query;

                oracleCommand.Parameters.Add("iddiagnosis", diagnosisId);

                connection.Open();
                oracleCommand.ExecuteNonQuery();
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

        private void buttonUpdateDiagnosis_Click(object sender, EventArgs e) {
            try {
                int currentRow = dataGridViewDiagnosis.CurrentCell.RowIndex;
                string diagnosisId = dataGridViewDiagnosis.SelectedRows[0].Cells[0].Value.ToString();
                this.Hide();
                UpdateDiagnosis updateDiagnosis = new UpdateDiagnosis(int.Parse(diagnosisId));
                updateDiagnosis.ShowDialog();
                this.Close();
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

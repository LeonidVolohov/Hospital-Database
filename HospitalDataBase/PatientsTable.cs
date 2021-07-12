using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Data.Common;
using HospitalDataBase;
using System.Data;
using System.Drawing;

namespace HospitalDataBase {
    public partial class PatientsTable : MetroForm {
        public PatientsTable() {
            InitializeComponent();

            try {
                String query = "SELECT people.idpeople AS Id, people.firstname, people.lastname, people.pathername, diagnosis.diagnosisname AS Diagnosis, wards.wardsname AS Ward, wards.idwards AS IdWard" +
                        " FROM people, wards, diagnosis " +
                            "WHERE people.iddiagnosis = diagnosis.iddiagnosis AND people.idward = wards.idwards";

                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();
                OracleCommand oracleCommand = connection.CreateCommand();
                oracleCommand.CommandText = query;

                connection.Open();

                OracleDataReader reader = oracleCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridViewPatients.DataSource = dataTable;
                dataGridViewPatients.Font = new Font("Century Gothic", 16F, GraphicsUnit.Pixel);
                dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewPatients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

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

        private void buttonAddNewPatient_Click(object sender, EventArgs e) {
            this.Hide();
            AddNewPatient addNewPatient = new AddNewPatient();
            addNewPatient.ShowDialog();
            this.Close();
        }

        private void buttonDischargeThePatient_Click(object sender, EventArgs e) {
            try {
                int currentRow = dataGridViewPatients.CurrentCell.RowIndex;
                string peopleId = dataGridViewPatients.SelectedRows[0].Cells[0].Value.ToString();

                dataGridViewPatients.Rows.RemoveAt(currentRow);

                String query = "DELETE FROM people WHERE people.idpeople = :idpeople";

                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();

                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                OracleCommand oracleCommand = connection.CreateCommand();
                oracleCommand.CommandText = query;

                oracleCommand.Parameters.Add("idpeople", peopleId);

                connection.Open();
                oracleCommand.ExecuteNonQuery();
                connection.Close();

            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonUpdateThePatient_Click(object sender, EventArgs e) {
            try {
                int currentRow = dataGridViewPatients.CurrentCell.RowIndex;
                string peopleId = dataGridViewPatients.SelectedRows[0].Cells[0].Value.ToString();
                this.Hide();
                UpdatePatient updatePatient = new UpdatePatient(int.Parse(peopleId));
                updatePatient.ShowDialog();
                this.Close();
            } catch(Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

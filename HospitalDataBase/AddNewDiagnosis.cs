using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Text;

namespace HospitalDataBase {
    public partial class AddNewDiagnosis : MetroForm {
        public AddNewDiagnosis() {
            InitializeComponent();
        }

        private void buttonAddNewDiagnosis_Click(object sender, EventArgs e) {
            string newDiagnosisName = textBoxNewDiagnosisName.Text.ToString();

            if(newDiagnosisName != "") {
                try {
                    String query = "INSERT INTO diagnosis (diagnosisName) VALUES (:diagnosisName)";

                    OracleConnection connection = new OracleConnection();
                    connection.ConnectionString = new DataBaseConnection().getConnectionString();

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                    OracleCommand oracleCommand = connection.CreateCommand();
                    oracleCommand.CommandText = query;

                    oracleCommand.Parameters.Add("diagnosisName", newDiagnosisName);

                    connection.Open();
                    oracleCommand.ExecuteNonQuery();
                    connection.Close();

                    DialogResult dialogResult = MessageBox.Show("New diagnosis was successfully added \nWould you like to go on a Diagnosis Table form?", "",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK) {
                        this.Hide();
                        DiagnosisTable diagnosisTable = new DiagnosisTable();
                        diagnosisTable.ShowDialog();
                        this.Close();
                    }
                } catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                }
            } else {
                MessageBox.Show("Please, enter a new diagnosis name");
            }
        }

        private void buttonBackOnAMainForm_Click(object sender, EventArgs e) {
            this.Hide();
            DiagnosisTable diagnosisTable = new DiagnosisTable();
            diagnosisTable.ShowDialog();
            this.Close();
        }
    }
}

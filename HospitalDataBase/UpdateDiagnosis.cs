using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Common;

namespace HospitalDataBase {
    public partial class UpdateDiagnosis : MetroForm {
        private int diagnosisId;

        public UpdateDiagnosis(int diagnosisId) {
            InitializeComponent();

            this.diagnosisId = diagnosisId;

            try {
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();
                connection.Open();

                // Get patient info
                String query = "SELECT diagnosisname  FROM diagnosis WHERE diagnosis.iddiagnosis= :iddiagnosis";
                OracleCommand oracleCommand = connection.CreateCommand();
                oracleCommand.CommandText = query;
                oracleCommand.Parameters.Add(new OracleParameter("iddiganosis", diagnosisId));
                DbDataReader reader = oracleCommand.ExecuteReader();
                reader.Read();

                textBoxNewDiagnosisName.Text = reader.GetString(0);
                connection.Close();
            } catch(Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonBackOnAMainForm_Click(object sender, EventArgs e) {
            this.Hide();
            DiagnosisTable diagnosisTable = new DiagnosisTable();
            diagnosisTable.ShowDialog();
            this.Close();
        }

        private void buttonUpdateDiagnosisDiagnosis_Click(object sender, EventArgs e) {
            string diagnosisName = textBoxNewDiagnosisName.Text.ToString();
            try {
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();

                if(diagnosisName != "") {

                    String query = "UPDATE diagnosis SET diagnosisname = :diagnosisname WHERE iddiagnosis = :iddiagnosis";

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                    OracleCommand oracleCommandInsert = connection.CreateCommand();
                    oracleCommandInsert.CommandText = query;

                    oracleCommandInsert.Parameters.Add("diagnosisname", diagnosisName);
                    oracleCommandInsert.Parameters.Add("iddiagnosis", diagnosisId);

                    connection.Open();
                    oracleCommandInsert.ExecuteNonQuery();
                    connection.Close();

                    DialogResult dialogResult = MessageBox.Show("Diagnosis was successfully updated \nWould you like to go on a Diagnosis Table form?", "",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK) {
                        this.Hide();
                        DiagnosisTable diagnosisTable = new DiagnosisTable();
                        diagnosisTable.ShowDialog();
                        this.Close();
                    }

                } else {
                    MessageBox.Show("Please, fill the data");
                    connection.Close();
                }
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

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
    public partial class AddNewPatient : MetroForm {
        public AddNewPatient() {
            InitializeComponent();

            try {
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();

                connection.Open();
                OracleCommand oracleCommandDiagnosis = new OracleCommand("SELECT diagnosisname FROM diagnosis", connection);
                oracleCommandDiagnosis.CommandType = System.Data.CommandType.Text;

                OracleDataReader dataReaderDiagnosis = oracleCommandDiagnosis.ExecuteReader();
                List<String> itemsDiagnosis = new List<String>();
                while (dataReaderDiagnosis.Read()) {
                    itemsDiagnosis.Add(String.Format("{0}", dataReaderDiagnosis.GetValue(0)));
                }

                comboBoxDiagnosisName.Items.AddRange(itemsDiagnosis.ToArray());

                OracleCommand oracleCommandWards = new OracleCommand("SELECT idwards, wardsname FROM wards", connection);
                oracleCommandWards.CommandType = System.Data.CommandType.Text;

                OracleDataReader dataReaderWards = oracleCommandWards.ExecuteReader();
                List<String> itemsWards = new List<String>();

                while (dataReaderWards.Read()) {
                    itemsWards.Add(String.Format("{0}, {1}", dataReaderWards.GetValue(0), dataReaderWards.GetValue(1)));
                }

                comboBoxWardName.Items.AddRange(itemsWards.ToArray());


            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonBackPatientTable_Click(object sender, EventArgs e) {
            this.Hide();
            PatientsTable patientsTable = new PatientsTable();
            patientsTable.ShowDialog();
            this.Close();
        }

        private void buttonAddNewPatient_Click(object sender, EventArgs e) {
            string firstName = textBoxFisrtName.Text.ToString();
            string lastName = textBoxLastName.Text.ToString();
            string patherName = textBoxPatherName.Text.ToString();

            if(firstName != "" || lastName != "" || patherName != "") {
                try {
                    OracleConnection connection = new OracleConnection();
                    connection.ConnectionString = new DataBaseConnection().getConnectionString();
                    connection.Open();


                    string diagnosisName = comboBoxDiagnosisName.SelectedItem.ToString();
                    string wardId = comboBoxWardName.SelectedItem.ToString().Substring(0, comboBoxWardName.SelectedItem.ToString().IndexOf(","));

                    int diagnosisId;
                    int intWardId = int.Parse(wardId);

                    String queryDiagnosisId = "SELECT diagnosis.iddiagnosis FROM diagnosis WHERE diagnosis.diagnosisname = :diagnosisname";
                    OracleCommand oracleCommandDiagnosisId = connection.CreateCommand();
                    oracleCommandDiagnosisId.CommandText = queryDiagnosisId;
                    oracleCommandDiagnosisId.Parameters.Add(new OracleParameter("diagnosisname", diagnosisName));

                    DbDataReader readerDiagnosisId = oracleCommandDiagnosisId.ExecuteReader();
                    readerDiagnosisId.Read();
                    diagnosisId = readerDiagnosisId.GetInt32(0);

                    int startWard = comboBoxWardName.SelectedItem.ToString().IndexOf("Ward");
                    int length = comboBoxWardName.SelectedItem.ToString().Length - startWard - 5;

                    if (diagnosisName == comboBoxWardName.SelectedItem.ToString().Substring(startWard + 5, length)) {
                        try {
                            String query = "INSERT INTO people (firstname, lastname, pathername, iddiagnosis, idward) VALUES (:firstname, :lastname, :pathername, :iddiagnosis, :idward)";

                            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                            OracleCommand oracleCommandInsert = connection.CreateCommand();
                            oracleCommandInsert.CommandText = query;

                            oracleCommandInsert.Parameters.Add("firstname", firstName);
                            oracleCommandInsert.Parameters.Add("lastname", lastName);
                            oracleCommandInsert.Parameters.Add("pathername", patherName);
                            oracleCommandInsert.Parameters.Add("iddiagnosis", diagnosisId);
                            oracleCommandInsert.Parameters.Add("idward", intWardId);

                            //connection.Open();
                            oracleCommandInsert.ExecuteNonQuery();
                            connection.Close();

                            DialogResult dialogResult = MessageBox.Show("New patient was successfully added \nWould you like to go on a Patient Table form?", "",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.OK) {
                                this.Hide();
                                PatientsTable patientsTable = new PatientsTable();
                                patientsTable.ShowDialog();
                                this.Close();
                            }
                        } catch (Exception exception) {
                            MessageBox.Show(exception.Message);
                            connection.Close();
                        }
                    } else {
                        MessageBox.Show("Diagnosis and ward name should be equal");
                        connection.Close();
                    }
                    connection.Close();
                } catch (Exception exception) {
                    MessageBox.Show("buttonAddNewPatient_Click: " + exception.Message);
                }
            } else {
                MessageBox.Show("Please, fill the data");
            }
        }
    }
}

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
    public partial class UpdatePatient : MetroForm {
        private int idPatient;

        public UpdatePatient(int idPatient) {
            InitializeComponent();
            this.idPatient = idPatient;

            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = new DataBaseConnection().getConnectionString();
            connection.Open();

            // First ComboBox
            OracleCommand oracleCommandDiagnosis = new OracleCommand("SELECT diagnosisname FROM diagnosis", connection);
            oracleCommandDiagnosis.CommandType = System.Data.CommandType.Text;

            OracleDataReader dataReaderDiagnosis = oracleCommandDiagnosis.ExecuteReader();
            List<String> itemsDiagnosis = new List<String>();
            while (dataReaderDiagnosis.Read()) {
                itemsDiagnosis.Add(String.Format("{0}", dataReaderDiagnosis.GetValue(0)));
            }

            comboBoxDiagnosisName.Items.AddRange(itemsDiagnosis.ToArray());

            // Second ComboBox
            OracleCommand oracleCommandWards = new OracleCommand("SELECT idwards, wardsname FROM wards", connection);
            oracleCommandWards.CommandType = System.Data.CommandType.Text;

            OracleDataReader dataReaderWards = oracleCommandWards.ExecuteReader();
            List<String> itemsWards = new List<String>();

            while (dataReaderWards.Read()) {
                itemsWards.Add(String.Format("{0}, {1}", dataReaderWards.GetValue(0), dataReaderWards.GetValue(1)));
            }

            comboBoxWardName.Items.AddRange(itemsWards.ToArray());

            // Get patient info
            String query = "SELECT firstname, lastname, pathername, diagnosisname, idwards, wardsname  FROM people, diagnosis, wards WHERE people.idpeople = :idpeople";
            OracleCommand oracleCommand = connection.CreateCommand();
            oracleCommand.CommandText = query;
            oracleCommand.Parameters.Add(new OracleParameter("idpeople", idPatient));
            DbDataReader reader = oracleCommand.ExecuteReader();
            reader.Read();


            textBoxFisrtName.Text = reader.GetString(0);
            textBoxLastName.Text = reader.GetString(1);
            textBoxPatherName.Text = reader.GetString(2);
            comboBoxDiagnosisName.SelectedItem = reader.GetString(3);


            int wardID = reader.GetInt32(4);
            string wardName = reader.GetString(5);

            comboBoxWardName.SelectedItem = wardID + ", " + wardName;
            
            connection.Close();
        }

        private void buttonBackPatientTable_Click(object sender, EventArgs e) {
            this.Hide();
            PatientsTable patientsTable = new PatientsTable();
            patientsTable.ShowDialog();
            this.Close();
        }

        private void buttonUpdatePatient_Click(object sender, EventArgs e) {
            string firstName = textBoxFisrtName.Text.ToString();
            string lastName = textBoxLastName.Text.ToString();
            string patherName = textBoxPatherName.Text.ToString();

            if (firstName != "" || lastName != "" || patherName != "") {
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
                            String query = "UPDATE people SET firstname = :firstname, lastname = :lastname, pathername = :pathername, iddiagnosis = :iddiagnosis, idward = :idward WHERE people.idpeople = :idpeople";

                            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                            OracleCommand oracleCommandInsert = connection.CreateCommand();
                            oracleCommandInsert.CommandText = query;

                            oracleCommandInsert.Parameters.Add("firstname", firstName);
                            oracleCommandInsert.Parameters.Add("lastname", lastName);
                            oracleCommandInsert.Parameters.Add("pathername", patherName);
                            oracleCommandInsert.Parameters.Add("iddiagnosis", diagnosisId);
                            oracleCommandInsert.Parameters.Add("idward", intWardId);
                            oracleCommandInsert.Parameters.Add("idpeople", idPatient);

                            //connection.Open();
                            oracleCommandInsert.ExecuteNonQuery();
                            connection.Close();

                            DialogResult dialogResult = MessageBox.Show("Patient was successfully updated \nWould you like to go on a Patient Table form?", "",
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

using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Data.Common;
using HospitalDataBase;
using System.Data;
using System.Drawing;

namespace HospitalDataBase {
    public partial class SomethingTheMostPopularDiagnosis : MetroForm {
        public SomethingTheMostPopularDiagnosis() {
            InitializeComponent();

            try {
                String query = "SELECT people.iddiagnosis, diagnosis.diagnosisname, COUNT(people.idpeople) " +
                        "FROM people, diagnosis WHERE people.iddiagnosis = diagnosis.iddiagnosis " +
                            "GROUP BY people.iddiagnosis, diagnosis.diagnosisname " +
                                "ORDER BY COUNT(*) DESC";

                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();
                OracleCommand oracleCommand = connection.CreateCommand();
                oracleCommand.CommandText = query;

                connection.Open();

                OracleDataReader reader = oracleCommand.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridViewWardCapacity.DataSource = dataTable;
                dataGridViewWardCapacity.Font = new Font("Century Gothic", 16F, GraphicsUnit.Pixel);
                dataGridViewWardCapacity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewWardCapacity.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                connection.Close();
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e) {
            this.Hide();
            Something something = new Something();
            something.ShowDialog();
            this.Close();
        }

        private void dataGridViewWardCapacity_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}

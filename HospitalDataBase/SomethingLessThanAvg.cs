using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Data.Common;
using HospitalDataBase;
using System.Data;
using System.Drawing;

namespace HospitalDataBase {
    public partial class SomethingLessThanAvg : MetroForm {
        private int idFirstDiagnosis, idSecondDiagnosis;

        public SomethingLessThanAvg(int idFirstDiagnosis, int idSecondDiagnosis) {
            InitializeComponent();

            this.idFirstDiagnosis = idFirstDiagnosis;
            this.idSecondDiagnosis = idSecondDiagnosis;

            try {
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = new DataBaseConnection().getConnectionString();
                OracleCommand oracleCommand = connection.CreateCommand();
                oracleCommand.CommandText = "LessAverageWards";
                oracleCommand.CommandType = CommandType.StoredProcedure;
                oracleCommand.Parameters.Add("inputFirstDiagnosis", idFirstDiagnosis);
                oracleCommand.Parameters.Add("inputSecondDiagnosis", idSecondDiagnosis);

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
    }
}

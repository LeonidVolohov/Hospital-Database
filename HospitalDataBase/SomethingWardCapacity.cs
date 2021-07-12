using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Data.Common;
using HospitalDataBase;
using System.Data;
using System.Drawing;

namespace HospitalDataBase {
    public partial class SomethingWardCapacity : MetroForm {
        public SomethingWardCapacity() {
            InitializeComponent();

            try {
                String query = "SELECT wards.idwards AS Id, wards.wardsname AS Name, wards.wardsmaxcount AS MaxCount, COUNT(people.idpeople) AS AmountPeople " +
                        "FROM wards, people WHERE people.idward = wards.idwards " +
                            "GROUP BY wards.wardsmaxcount, wards.wardsname, wards.idwards " +
                                "ORDER BY COUNT(people.idpeople) DESC";

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
    }
}

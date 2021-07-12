using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Text;


namespace HospitalDataBase {
    public partial class AddNewWard : MetroForm {
        public AddNewWard() {
            InitializeComponent();
        }

        private void buttonBackOnAMainForm_Click(object sender, EventArgs e) {
            this.Hide();
            WardsTable wardsTable = new WardsTable();
            wardsTable.ShowDialog();
            this.Close();
        }

        private void buttonAddNewWard_Click(object sender, EventArgs e) {
            string wardsName = textBoxNewWardsName.Text.ToString();
            string wardsMaxCount = textBoxWardsMaxCount.Text.ToString();
            
            int number;
            bool isParsable = Int32.TryParse(wardsMaxCount, out number);

            if ((wardsName != "" && wardsMaxCount != "" && number > 0) || (wardsName != "" && number > 0 || wardsMaxCount != "" && number > 0)) {
                try {
                    String query = "INSERT INTO wards (wardsname, wardsmaxcount) VALUES (:wardsname, :wardsmaxcount)";

                    OracleConnection connection = new OracleConnection();
                    connection.ConnectionString = new DataBaseConnection().getConnectionString();

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                    OracleCommand oracleCommand = connection.CreateCommand();
                    oracleCommand.CommandText = query;

                    oracleCommand.Parameters.Add("wardsname", wardsName);
                    oracleCommand.Parameters.Add("wardsmaxcount", wardsMaxCount);

                    connection.Open();
                    oracleCommand.ExecuteNonQuery();
                    connection.Close();

                    DialogResult dialogResult = MessageBox.Show("New ward was successfully added \nWould you like to go on a Wards Table form?", "",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK) {
                        this.Hide();
                        WardsTable wardsTable = new WardsTable();
                        wardsTable.ShowDialog();
                        this.Close();
                    }
                } catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                }
            } else {
                MessageBox.Show("Wrong input data");
            }
        }
    }
}

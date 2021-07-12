using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Data.Common;
using HospitalDataBase;

namespace HospitalDataBase {
    public partial class SignIn : MetroForm {

        public SignIn() {
            InitializeComponent();

        }

        private void buttonSignIn_Click(object sender, EventArgs e) {
            string userLogin = textBoxUserLogin.Text.ToString();
            string userPassword = textBoxUserPassword.Text.ToString();

            if (userLogin == "" || userPassword == "") {
                MessageBox.Show("Please enter your login and password");
            } else {
                try {
                    String query = "SELECT UserLogin FROM usersTable WHERE usersTable.UserLogin = :UserLogin";

                    OracleConnection connection = new OracleConnection();
                    connection.ConnectionString = new DataBaseConnection().getConnectionString();

                    OracleCommand oracleCommand = connection.CreateCommand();
                    oracleCommand.CommandText = query;
                    oracleCommand.Parameters.Add(new OracleParameter("UserLogin", userLogin));

                    connection.Open();

                    using (DbDataReader reader = oracleCommand.ExecuteReader()) {
                        if(reader.HasRows) {
                            reader.Read();
                            Console.WriteLine("Current user is: " + reader.GetString(0));

                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.ShowDialog();
                            this.Close();

                            connection.Close();
                        } else {
                            connection.Close();
                            MessageBox.Show("No such user");
                        }
                    }
                } catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e) {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Text;
using System.Security.Cryptography;

namespace HospitalDataBase {
    public partial class SignUp : MetroForm {

        public SignUp() {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e) {
            string login = textBoxUserLogin.Text.ToString();
            string password = textBoxUserPassword.Text.ToString();
            string repeatPasswrod = textBoxUserRepeatPassword.Text.ToString();
            
            if(login != "" && password != "" && repeatPasswrod != "") {
                if(password == repeatPasswrod) {
                    try {
                        String query = "INSERT INTO usersTable (userLogin, userPassword) VALUES (:userLogin, :userPassword)";

                        OracleConnection connection = new OracleConnection();
                        connection.ConnectionString = new DataBaseConnection().getConnectionString();

                        OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                        OracleCommand oracleCommand = connection.CreateCommand();
                        oracleCommand.CommandText = query;

                        password = getHash(password);

                        oracleCommand.Parameters.Add("userLogin", login);
                        oracleCommand.Parameters.Add("userPassword", password);

                        connection.Open();
                        //oracleDataAdapter.InsertCommand = oracleCommand;
                        oracleCommand.ExecuteNonQuery();
                        connection.Close();

                        DialogResult dialogResult = MessageBox.Show("New user was successfully added \nWould you like to go on a Sign In page?", "",  
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if(dialogResult == DialogResult.OK) {
                            this.Hide();
                            SignIn signIn = new SignIn();
                            signIn.ShowDialog();
                            this.Close();
                        }

                    } catch (Exception exception) {
                        MessageBox.Show(exception.Message);
                    }
                } else {
                    MessageBox.Show("Passwords should be equals");
                }
            } else {
                MessageBox.Show("Please fill the data");
            }
        }


        public static string getHash(string text) {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash) {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }
    }
}

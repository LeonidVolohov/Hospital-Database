using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Data.Common;
using HospitalDataBase;
using System.Data;
using System.Drawing;
using Oracle.ManagedDataAccess.Types;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;
using System.Globalization;

namespace HospitalDataBase {
    public partial class Something : MetroForm {
        private static string path = @"D:\University\6sem\СУБД\CourseProject\cursor.txt";

        public Something() {
            InitializeComponent();
        }

        private void buttonDisplayWardCapacity_Click(object sender, EventArgs e) {
            this.Hide();
            SomethingWardCapacity somethingWardCapacity = new SomethingWardCapacity();
            somethingWardCapacity.ShowDialog();
            this.Close();
        }

        private void buttonTheMostPopularDiagnosis_Click(object sender, EventArgs e) {
            this.Hide();
            SomethingTheMostPopularDiagnosis somethingTheMostPopularDiagnosis = new SomethingTheMostPopularDiagnosis();
            somethingTheMostPopularDiagnosis.ShowDialog();
            this.Close();
        }

        private void buttonLessThanAvg_Click(object sender, EventArgs e) {
            try {
                if(int.Parse(textBoxIdFirstDiagnosis.Text.ToString()) > 0 && int.Parse(textBoxIdSecondDiagnosis.Text.ToString()) > 0) {
                    this.Hide();
                    SomethingLessThanAvg somethingLessThanAvg = new SomethingLessThanAvg(int.Parse(textBoxIdFirstDiagnosis.Text.ToString()), int.Parse(textBoxIdSecondDiagnosis.Text.ToString()));
                    somethingLessThanAvg.ShowDialog();
                    this.Close();
                } else {
                    MessageBox.Show("Diagnosis id should be > 0");
                }
            } catch(Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonCursor_Click(object sender, EventArgs e) {
            string output;
            try {
                double firstRatio = double.Parse(textBoxInputRatioFirst.Text.ToString());
                double secondRatio = double.Parse(textBoxInputRatioSecond.Text.ToString());
                if (firstRatio > 0 && secondRatio > 0) {
                    if(firstRatio < secondRatio) {
                        OracleConnection connection = new OracleConnection();
                        connection.ConnectionString = new DataBaseConnection().getConnectionString();

                        OracleCommand oracleCommand = connection.CreateCommand();
                        oracleCommand.CommandText = "diagnosisAnalysis";
                        oracleCommand.CommandType = CommandType.StoredProcedure;
                        oracleCommand.Parameters.Add("inputFirstDiagnosis", double.Parse(textBoxInputRatioFirst.Text.ToString()));
                        oracleCommand.Parameters.Add("inputSecondDiagnosis", double.Parse(textBoxInputRatioSecond.Text.ToString()));
                        oracleCommand.Parameters.Add("outString", OracleDbType.Varchar2, 32766).Direction = ParameterDirection.Output;

                        connection.Open();
                        oracleCommand.ExecuteNonQuery();

                        dynamic item = oracleCommand.Parameters["outString"].Value;
                        output = item.Value;

                        string currentDate = "Current date and time is: " + DateTime.Now.ToString(new CultureInfo("ru-RU")) + "\n";
                        string intput = "Input info is: " + double.Parse(textBoxInputRatioFirst.Text.ToString()) + " and " + double.Parse(textBoxInputRatioSecond.Text.ToString()) + "\n";
                        File.AppendAllText(path, currentDate);
                        File.AppendAllText(path, intput);
                        File.AppendAllText(path, output);
                        File.AppendAllText(path, "----------------------------- \n" + Environment.NewLine);

                        MessageBox.Show("Output file was successfully updated");

                        connection.Close();
                    } else {
                        MessageBox.Show("First ratio should be less than the second");
                    }
                } else {
                    MessageBox.Show("Input ratio should be > 0");
                }
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}

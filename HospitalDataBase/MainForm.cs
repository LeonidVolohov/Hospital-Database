using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Data.Common;

namespace HospitalDataBase {
    public partial class MainForm : MetroForm {
        public MainForm() {
            InitializeComponent();
        }

        private void buttonDiagnosisTable_Click(object sender, EventArgs e) {
            this.Hide();
            DiagnosisTable diagnosisTabe = new DiagnosisTable();
            diagnosisTabe.ShowDialog();
            this.Close();
        }

        private void buttonWardsTable_Click(object sender, EventArgs e) {
            this.Hide();
            WardsTable wardsTable = new WardsTable();
            wardsTable.ShowDialog();
            this.Close();
        }

        private void buttonPatientsTable_Click(object sender, EventArgs e) {
            this.Hide();
            PatientsTable patientsTable = new PatientsTable();
            patientsTable.ShowDialog();
            this.Close();
        }

        private void buttonSomething_Click(object sender, EventArgs e) {
            this.Hide();
            Something something = new Something();
            something.ShowDialog();
            this.Close();
        }

        private void buttonGoSignInPage_Click(object sender, EventArgs e) {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }
    }
}

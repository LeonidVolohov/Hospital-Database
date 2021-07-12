namespace HospitalDataBase {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonDiagnosisTable = new System.Windows.Forms.Button();
            this.buttonWardsTable = new System.Windows.Forms.Button();
            this.buttonPatientsTable = new System.Windows.Forms.Button();
            this.buttonSomething = new System.Windows.Forms.Button();
            this.buttonGoSignInPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDiagnosisTable
            // 
            this.buttonDiagnosisTable.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDiagnosisTable.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiagnosisTable.Location = new System.Drawing.Point(23, 63);
            this.buttonDiagnosisTable.Name = "buttonDiagnosisTable";
            this.buttonDiagnosisTable.Size = new System.Drawing.Size(354, 80);
            this.buttonDiagnosisTable.TabIndex = 5;
            this.buttonDiagnosisTable.Text = "Diagnosis table";
            this.buttonDiagnosisTable.UseVisualStyleBackColor = false;
            this.buttonDiagnosisTable.Click += new System.EventHandler(this.buttonDiagnosisTable_Click);
            // 
            // buttonWardsTable
            // 
            this.buttonWardsTable.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonWardsTable.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWardsTable.Location = new System.Drawing.Point(23, 149);
            this.buttonWardsTable.Name = "buttonWardsTable";
            this.buttonWardsTable.Size = new System.Drawing.Size(354, 80);
            this.buttonWardsTable.TabIndex = 6;
            this.buttonWardsTable.Text = "Wards table";
            this.buttonWardsTable.UseVisualStyleBackColor = false;
            this.buttonWardsTable.Click += new System.EventHandler(this.buttonWardsTable_Click);
            // 
            // buttonPatientsTable
            // 
            this.buttonPatientsTable.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonPatientsTable.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPatientsTable.Location = new System.Drawing.Point(23, 235);
            this.buttonPatientsTable.Name = "buttonPatientsTable";
            this.buttonPatientsTable.Size = new System.Drawing.Size(354, 80);
            this.buttonPatientsTable.TabIndex = 7;
            this.buttonPatientsTable.Text = "Patients table";
            this.buttonPatientsTable.UseVisualStyleBackColor = false;
            this.buttonPatientsTable.Click += new System.EventHandler(this.buttonPatientsTable_Click);
            // 
            // buttonSomething
            // 
            this.buttonSomething.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSomething.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSomething.Location = new System.Drawing.Point(23, 321);
            this.buttonSomething.Name = "buttonSomething";
            this.buttonSomething.Size = new System.Drawing.Size(354, 80);
            this.buttonSomething.TabIndex = 8;
            this.buttonSomething.Text = "Something";
            this.buttonSomething.UseVisualStyleBackColor = false;
            this.buttonSomething.Click += new System.EventHandler(this.buttonSomething_Click);
            // 
            // buttonGoSignInPage
            // 
            this.buttonGoSignInPage.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonGoSignInPage.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoSignInPage.Location = new System.Drawing.Point(23, 407);
            this.buttonGoSignInPage.Name = "buttonGoSignInPage";
            this.buttonGoSignInPage.Size = new System.Drawing.Size(354, 50);
            this.buttonGoSignInPage.TabIndex = 9;
            this.buttonGoSignInPage.Text = "Go back";
            this.buttonGoSignInPage.UseVisualStyleBackColor = false;
            this.buttonGoSignInPage.Click += new System.EventHandler(this.buttonGoSignInPage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.buttonGoSignInPage);
            this.Controls.Add(this.buttonSomething);
            this.Controls.Add(this.buttonPatientsTable);
            this.Controls.Add(this.buttonWardsTable);
            this.Controls.Add(this.buttonDiagnosisTable);
            this.MaximumSize = new System.Drawing.Size(400, 480);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDiagnosisTable;
        private System.Windows.Forms.Button buttonWardsTable;
        private System.Windows.Forms.Button buttonPatientsTable;
        private System.Windows.Forms.Button buttonSomething;
        private System.Windows.Forms.Button buttonGoSignInPage;
    }
}
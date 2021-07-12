namespace HospitalDataBase {
    partial class AddNewDiagnosis {
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
            this.textBoxNewDiagnosisName = new System.Windows.Forms.TextBox();
            this.labelDiagnosisName = new System.Windows.Forms.Label();
            this.buttonAddNewDiagnosis = new System.Windows.Forms.Button();
            this.buttonBackOnAMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewDiagnosisName
            // 
            this.textBoxNewDiagnosisName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewDiagnosisName.Location = new System.Drawing.Point(23, 222);
            this.textBoxNewDiagnosisName.Multiline = true;
            this.textBoxNewDiagnosisName.Name = "textBoxNewDiagnosisName";
            this.textBoxNewDiagnosisName.Size = new System.Drawing.Size(354, 33);
            this.textBoxNewDiagnosisName.TabIndex = 8;
            this.textBoxNewDiagnosisName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDiagnosisName
            // 
            this.labelDiagnosisName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiagnosisName.Location = new System.Drawing.Point(19, 170);
            this.labelDiagnosisName.Name = "labelDiagnosisName";
            this.labelDiagnosisName.Size = new System.Drawing.Size(358, 33);
            this.labelDiagnosisName.TabIndex = 7;
            this.labelDiagnosisName.Text = "Diagnosis name";
            this.labelDiagnosisName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddNewDiagnosis
            // 
            this.buttonAddNewDiagnosis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAddNewDiagnosis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNewDiagnosis.Location = new System.Drawing.Point(202, 261);
            this.buttonAddNewDiagnosis.Name = "buttonAddNewDiagnosis";
            this.buttonAddNewDiagnosis.Size = new System.Drawing.Size(175, 33);
            this.buttonAddNewDiagnosis.TabIndex = 10;
            this.buttonAddNewDiagnosis.Text = "Add new diagnosis";
            this.buttonAddNewDiagnosis.UseVisualStyleBackColor = false;
            this.buttonAddNewDiagnosis.Click += new System.EventHandler(this.buttonAddNewDiagnosis_Click);
            // 
            // buttonBackOnAMainForm
            // 
            this.buttonBackOnAMainForm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBackOnAMainForm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackOnAMainForm.Location = new System.Drawing.Point(23, 261);
            this.buttonBackOnAMainForm.Name = "buttonBackOnAMainForm";
            this.buttonBackOnAMainForm.Size = new System.Drawing.Size(173, 33);
            this.buttonBackOnAMainForm.TabIndex = 11;
            this.buttonBackOnAMainForm.Text = "Go back";
            this.buttonBackOnAMainForm.UseVisualStyleBackColor = false;
            this.buttonBackOnAMainForm.Click += new System.EventHandler(this.buttonBackOnAMainForm_Click);
            // 
            // AddNewDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.buttonBackOnAMainForm);
            this.Controls.Add(this.buttonAddNewDiagnosis);
            this.Controls.Add(this.textBoxNewDiagnosisName);
            this.Controls.Add(this.labelDiagnosisName);
            this.MinimumSize = new System.Drawing.Size(400, 480);
            this.Name = "AddNewDiagnosis";
            this.Text = "Add new diagnosis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewDiagnosisName;
        private System.Windows.Forms.Label labelDiagnosisName;
        private System.Windows.Forms.Button buttonAddNewDiagnosis;
        private System.Windows.Forms.Button buttonBackOnAMainForm;
    }
}
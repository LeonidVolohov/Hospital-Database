namespace HospitalDataBase {
    partial class UpdateDiagnosis {
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
            this.buttonBackOnAMainForm = new System.Windows.Forms.Button();
            this.buttonUpdateDiagnosisDiagnosis = new System.Windows.Forms.Button();
            this.textBoxNewDiagnosisName = new System.Windows.Forms.TextBox();
            this.labelDiagnosisName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBackOnAMainForm
            // 
            this.buttonBackOnAMainForm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBackOnAMainForm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackOnAMainForm.Location = new System.Drawing.Point(25, 269);
            this.buttonBackOnAMainForm.Name = "buttonBackOnAMainForm";
            this.buttonBackOnAMainForm.Size = new System.Drawing.Size(173, 33);
            this.buttonBackOnAMainForm.TabIndex = 15;
            this.buttonBackOnAMainForm.Text = "Go back";
            this.buttonBackOnAMainForm.UseVisualStyleBackColor = false;
            this.buttonBackOnAMainForm.Click += new System.EventHandler(this.buttonBackOnAMainForm_Click);
            // 
            // buttonUpdateDiagnosisDiagnosis
            // 
            this.buttonUpdateDiagnosisDiagnosis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonUpdateDiagnosisDiagnosis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateDiagnosisDiagnosis.Location = new System.Drawing.Point(204, 269);
            this.buttonUpdateDiagnosisDiagnosis.Name = "buttonUpdateDiagnosisDiagnosis";
            this.buttonUpdateDiagnosisDiagnosis.Size = new System.Drawing.Size(175, 33);
            this.buttonUpdateDiagnosisDiagnosis.TabIndex = 14;
            this.buttonUpdateDiagnosisDiagnosis.Text = "Update";
            this.buttonUpdateDiagnosisDiagnosis.UseVisualStyleBackColor = false;
            this.buttonUpdateDiagnosisDiagnosis.Click += new System.EventHandler(this.buttonUpdateDiagnosisDiagnosis_Click);
            // 
            // textBoxNewDiagnosisName
            // 
            this.textBoxNewDiagnosisName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewDiagnosisName.Location = new System.Drawing.Point(25, 230);
            this.textBoxNewDiagnosisName.Multiline = true;
            this.textBoxNewDiagnosisName.Name = "textBoxNewDiagnosisName";
            this.textBoxNewDiagnosisName.Size = new System.Drawing.Size(354, 33);
            this.textBoxNewDiagnosisName.TabIndex = 13;
            this.textBoxNewDiagnosisName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDiagnosisName
            // 
            this.labelDiagnosisName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiagnosisName.Location = new System.Drawing.Point(21, 178);
            this.labelDiagnosisName.Name = "labelDiagnosisName";
            this.labelDiagnosisName.Size = new System.Drawing.Size(358, 33);
            this.labelDiagnosisName.TabIndex = 12;
            this.labelDiagnosisName.Text = "Diagnosis name";
            this.labelDiagnosisName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.buttonBackOnAMainForm);
            this.Controls.Add(this.buttonUpdateDiagnosisDiagnosis);
            this.Controls.Add(this.textBoxNewDiagnosisName);
            this.Controls.Add(this.labelDiagnosisName);
            this.MinimumSize = new System.Drawing.Size(400, 480);
            this.Name = "UpdateDiagnosis";
            this.Text = "Update diagnosis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackOnAMainForm;
        private System.Windows.Forms.Button buttonUpdateDiagnosisDiagnosis;
        private System.Windows.Forms.TextBox textBoxNewDiagnosisName;
        private System.Windows.Forms.Label labelDiagnosisName;
    }
}
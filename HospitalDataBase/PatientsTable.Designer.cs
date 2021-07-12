namespace HospitalDataBase {
    partial class PatientsTable {
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
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonDischargeThePatient = new System.Windows.Forms.Button();
            this.buttonAddNewPatient = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.buttonUpdateThePatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonGoBack.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoBack.Location = new System.Drawing.Point(20, 424);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(164, 33);
            this.buttonGoBack.TabIndex = 15;
            this.buttonGoBack.Text = "Go back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonDischargeThePatient
            // 
            this.buttonDischargeThePatient.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDischargeThePatient.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDischargeThePatient.Location = new System.Drawing.Point(567, 424);
            this.buttonDischargeThePatient.Name = "buttonDischargeThePatient";
            this.buttonDischargeThePatient.Size = new System.Drawing.Size(193, 33);
            this.buttonDischargeThePatient.TabIndex = 14;
            this.buttonDischargeThePatient.Text = "Discharge";
            this.buttonDischargeThePatient.UseVisualStyleBackColor = false;
            this.buttonDischargeThePatient.Click += new System.EventHandler(this.buttonDischargeThePatient_Click);
            // 
            // buttonAddNewPatient
            // 
            this.buttonAddNewPatient.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAddNewPatient.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNewPatient.Location = new System.Drawing.Point(190, 424);
            this.buttonAddNewPatient.Name = "buttonAddNewPatient";
            this.buttonAddNewPatient.Size = new System.Drawing.Size(179, 33);
            this.buttonAddNewPatient.TabIndex = 13;
            this.buttonAddNewPatient.Text = "Add new patient";
            this.buttonAddNewPatient.UseVisualStyleBackColor = false;
            this.buttonAddNewPatient.Click += new System.EventHandler(this.buttonAddNewPatient_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPatients.GridColor = System.Drawing.Color.White;
            this.dataGridViewPatients.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowHeadersWidth = 60;
            this.dataGridViewPatients.Size = new System.Drawing.Size(740, 358);
            this.dataGridViewPatients.TabIndex = 12;
            // 
            // buttonUpdateThePatient
            // 
            this.buttonUpdateThePatient.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonUpdateThePatient.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateThePatient.Location = new System.Drawing.Point(375, 424);
            this.buttonUpdateThePatient.Name = "buttonUpdateThePatient";
            this.buttonUpdateThePatient.Size = new System.Drawing.Size(186, 33);
            this.buttonUpdateThePatient.TabIndex = 16;
            this.buttonUpdateThePatient.Text = "Update";
            this.buttonUpdateThePatient.UseVisualStyleBackColor = false;
            this.buttonUpdateThePatient.Click += new System.EventHandler(this.buttonUpdateThePatient_Click);
            // 
            // PatientsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.buttonUpdateThePatient);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonDischargeThePatient);
            this.Controls.Add(this.buttonAddNewPatient);
            this.Controls.Add(this.dataGridViewPatients);
            this.MinimumSize = new System.Drawing.Size(780, 480);
            this.Name = "PatientsTable";
            this.Text = "PatientsTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonDischargeThePatient;
        private System.Windows.Forms.Button buttonAddNewPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button buttonUpdateThePatient;
    }
}
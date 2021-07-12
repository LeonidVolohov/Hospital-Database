namespace HospitalDataBase {
    partial class DiagnosisTable {
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
            this.dataGridViewDiagnosis = new System.Windows.Forms.DataGridView();
            this.buttonAddNewDiagnosis = new System.Windows.Forms.Button();
            this.buttonDeleteDiagnosis = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonUpdateDiagnosis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDiagnosis
            // 
            this.dataGridViewDiagnosis.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiagnosis.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewDiagnosis.GridColor = System.Drawing.Color.White;
            this.dataGridViewDiagnosis.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewDiagnosis.Name = "dataGridViewDiagnosis";
            this.dataGridViewDiagnosis.RowHeadersWidth = 60;
            this.dataGridViewDiagnosis.Size = new System.Drawing.Size(740, 358);
            this.dataGridViewDiagnosis.TabIndex = 0;
            // 
            // buttonAddNewDiagnosis
            // 
            this.buttonAddNewDiagnosis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAddNewDiagnosis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNewDiagnosis.Location = new System.Drawing.Point(201, 424);
            this.buttonAddNewDiagnosis.Name = "buttonAddNewDiagnosis";
            this.buttonAddNewDiagnosis.Size = new System.Drawing.Size(182, 33);
            this.buttonAddNewDiagnosis.TabIndex = 6;
            this.buttonAddNewDiagnosis.Text = "Add new";
            this.buttonAddNewDiagnosis.UseVisualStyleBackColor = false;
            this.buttonAddNewDiagnosis.Click += new System.EventHandler(this.buttonAddNewDiagnosis_Click);
            // 
            // buttonDeleteDiagnosis
            // 
            this.buttonDeleteDiagnosis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDeleteDiagnosis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteDiagnosis.Location = new System.Drawing.Point(569, 424);
            this.buttonDeleteDiagnosis.Name = "buttonDeleteDiagnosis";
            this.buttonDeleteDiagnosis.Size = new System.Drawing.Size(191, 33);
            this.buttonDeleteDiagnosis.TabIndex = 7;
            this.buttonDeleteDiagnosis.Text = "Delete";
            this.buttonDeleteDiagnosis.UseVisualStyleBackColor = false;
            this.buttonDeleteDiagnosis.Click += new System.EventHandler(this.buttonDeleteDiagnosis_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonGoBack.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoBack.Location = new System.Drawing.Point(20, 424);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(175, 33);
            this.buttonGoBack.TabIndex = 8;
            this.buttonGoBack.Text = "Go back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonUpdateDiagnosis
            // 
            this.buttonUpdateDiagnosis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonUpdateDiagnosis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateDiagnosis.Location = new System.Drawing.Point(389, 424);
            this.buttonUpdateDiagnosis.Name = "buttonUpdateDiagnosis";
            this.buttonUpdateDiagnosis.Size = new System.Drawing.Size(174, 33);
            this.buttonUpdateDiagnosis.TabIndex = 9;
            this.buttonUpdateDiagnosis.Text = "Update";
            this.buttonUpdateDiagnosis.UseVisualStyleBackColor = false;
            this.buttonUpdateDiagnosis.Click += new System.EventHandler(this.buttonUpdateDiagnosis_Click);
            // 
            // DiagnosisTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.buttonUpdateDiagnosis);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonDeleteDiagnosis);
            this.Controls.Add(this.buttonAddNewDiagnosis);
            this.Controls.Add(this.dataGridViewDiagnosis);
            this.MinimumSize = new System.Drawing.Size(780, 480);
            this.Name = "DiagnosisTable";
            this.Text = "Diagnosis table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiagnosis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDiagnosis;
        private System.Windows.Forms.Button buttonAddNewDiagnosis;
        private System.Windows.Forms.Button buttonDeleteDiagnosis;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonUpdateDiagnosis;
    }
}
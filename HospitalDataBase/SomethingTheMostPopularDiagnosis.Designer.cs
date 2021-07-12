namespace HospitalDataBase {
    partial class SomethingTheMostPopularDiagnosis {
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
            this.dataGridViewWardCapacity = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWardCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonGoBack.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoBack.Location = new System.Drawing.Point(305, 424);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(175, 33);
            this.buttonGoBack.TabIndex = 11;
            this.buttonGoBack.Text = "Go back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // dataGridViewWardCapacity
            // 
            this.dataGridViewWardCapacity.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewWardCapacity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWardCapacity.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewWardCapacity.GridColor = System.Drawing.Color.White;
            this.dataGridViewWardCapacity.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewWardCapacity.Name = "dataGridViewWardCapacity";
            this.dataGridViewWardCapacity.RowHeadersWidth = 60;
            this.dataGridViewWardCapacity.Size = new System.Drawing.Size(740, 358);
            this.dataGridViewWardCapacity.TabIndex = 10;
            this.dataGridViewWardCapacity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWardCapacity_CellContentClick);
            // 
            // SomethingTheMostPopularDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.dataGridViewWardCapacity);
            this.MaximumSize = new System.Drawing.Size(780, 480);
            this.Name = "SomethingTheMostPopularDiagnosis";
            this.Text = "The most popular diagnosis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWardCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.DataGridView dataGridViewWardCapacity;
    }
}
namespace HospitalDataBase {
    partial class WardsTable {
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
            this.dataGridViewWadrs = new System.Windows.Forms.DataGridView();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonDeleteWard = new System.Windows.Forms.Button();
            this.buttonAddNewWard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWadrs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWadrs
            // 
            this.dataGridViewWadrs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewWadrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWadrs.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewWadrs.GridColor = System.Drawing.Color.White;
            this.dataGridViewWadrs.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewWadrs.Name = "dataGridViewWadrs";
            this.dataGridViewWadrs.RowHeadersWidth = 60;
            this.dataGridViewWadrs.Size = new System.Drawing.Size(740, 358);
            this.dataGridViewWadrs.TabIndex = 1;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonGoBack.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoBack.Location = new System.Drawing.Point(20, 434);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(250, 33);
            this.buttonGoBack.TabIndex = 11;
            this.buttonGoBack.Text = "Go back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonDeleteWard
            // 
            this.buttonDeleteWard.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDeleteWard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteWard.Location = new System.Drawing.Point(528, 434);
            this.buttonDeleteWard.Name = "buttonDeleteWard";
            this.buttonDeleteWard.Size = new System.Drawing.Size(232, 33);
            this.buttonDeleteWard.TabIndex = 10;
            this.buttonDeleteWard.Text = "Delete ward";
            this.buttonDeleteWard.UseVisualStyleBackColor = false;
            this.buttonDeleteWard.Click += new System.EventHandler(this.buttonDeleteWard_Click);
            // 
            // buttonAddNewWard
            // 
            this.buttonAddNewWard.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAddNewWard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNewWard.Location = new System.Drawing.Point(276, 434);
            this.buttonAddNewWard.Name = "buttonAddNewWard";
            this.buttonAddNewWard.Size = new System.Drawing.Size(246, 33);
            this.buttonAddNewWard.TabIndex = 9;
            this.buttonAddNewWard.Text = "Add new ward";
            this.buttonAddNewWard.UseVisualStyleBackColor = false;
            this.buttonAddNewWard.Click += new System.EventHandler(this.buttonAddNewWard_Click);
            // 
            // WardsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonDeleteWard);
            this.Controls.Add(this.buttonAddNewWard);
            this.Controls.Add(this.dataGridViewWadrs);
            this.MinimumSize = new System.Drawing.Size(780, 480);
            this.Name = "WardsTable";
            this.Text = "Wards table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWadrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWadrs;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonDeleteWard;
        private System.Windows.Forms.Button buttonAddNewWard;
    }
}
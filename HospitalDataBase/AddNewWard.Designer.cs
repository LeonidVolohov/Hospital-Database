namespace HospitalDataBase {
    partial class AddNewWard {
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
            this.buttonAddNewWard = new System.Windows.Forms.Button();
            this.textBoxNewWardsName = new System.Windows.Forms.TextBox();
            this.labelNewWardsName = new System.Windows.Forms.Label();
            this.textBoxWardsMaxCount = new System.Windows.Forms.TextBox();
            this.labelNewWardsMaxCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBackOnAMainForm
            // 
            this.buttonBackOnAMainForm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBackOnAMainForm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackOnAMainForm.Location = new System.Drawing.Point(23, 315);
            this.buttonBackOnAMainForm.Name = "buttonBackOnAMainForm";
            this.buttonBackOnAMainForm.Size = new System.Drawing.Size(173, 33);
            this.buttonBackOnAMainForm.TabIndex = 15;
            this.buttonBackOnAMainForm.Text = "Go back";
            this.buttonBackOnAMainForm.UseVisualStyleBackColor = false;
            this.buttonBackOnAMainForm.Click += new System.EventHandler(this.buttonBackOnAMainForm_Click);
            // 
            // buttonAddNewWard
            // 
            this.buttonAddNewWard.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAddNewWard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNewWard.Location = new System.Drawing.Point(202, 315);
            this.buttonAddNewWard.Name = "buttonAddNewWard";
            this.buttonAddNewWard.Size = new System.Drawing.Size(175, 33);
            this.buttonAddNewWard.TabIndex = 14;
            this.buttonAddNewWard.Text = "Add new diagnosis";
            this.buttonAddNewWard.UseVisualStyleBackColor = false;
            this.buttonAddNewWard.Click += new System.EventHandler(this.buttonAddNewWard_Click);
            // 
            // textBoxNewWardsName
            // 
            this.textBoxNewWardsName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewWardsName.Location = new System.Drawing.Point(23, 168);
            this.textBoxNewWardsName.Multiline = true;
            this.textBoxNewWardsName.Name = "textBoxNewWardsName";
            this.textBoxNewWardsName.Size = new System.Drawing.Size(354, 33);
            this.textBoxNewWardsName.TabIndex = 13;
            this.textBoxNewWardsName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNewWardsName
            // 
            this.labelNewWardsName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewWardsName.Location = new System.Drawing.Point(21, 132);
            this.labelNewWardsName.Name = "labelNewWardsName";
            this.labelNewWardsName.Size = new System.Drawing.Size(358, 33);
            this.labelNewWardsName.TabIndex = 12;
            this.labelNewWardsName.Text = "Wards name";
            this.labelNewWardsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxWardsMaxCount
            // 
            this.textBoxWardsMaxCount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWardsMaxCount.Location = new System.Drawing.Point(25, 276);
            this.textBoxWardsMaxCount.Multiline = true;
            this.textBoxWardsMaxCount.Name = "textBoxWardsMaxCount";
            this.textBoxWardsMaxCount.Size = new System.Drawing.Size(354, 33);
            this.textBoxWardsMaxCount.TabIndex = 17;
            this.textBoxWardsMaxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNewWardsMaxCount
            // 
            this.labelNewWardsMaxCount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewWardsMaxCount.Location = new System.Drawing.Point(19, 240);
            this.labelNewWardsMaxCount.Name = "labelNewWardsMaxCount";
            this.labelNewWardsMaxCount.Size = new System.Drawing.Size(358, 33);
            this.labelNewWardsMaxCount.TabIndex = 16;
            this.labelNewWardsMaxCount.Text = "Wards max count";
            this.labelNewWardsMaxCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddNewWard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.textBoxWardsMaxCount);
            this.Controls.Add(this.labelNewWardsMaxCount);
            this.Controls.Add(this.buttonBackOnAMainForm);
            this.Controls.Add(this.buttonAddNewWard);
            this.Controls.Add(this.textBoxNewWardsName);
            this.Controls.Add(this.labelNewWardsName);
            this.MinimumSize = new System.Drawing.Size(400, 480);
            this.Name = "AddNewWard";
            this.Text = "Add new ward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackOnAMainForm;
        private System.Windows.Forms.Button buttonAddNewWard;
        private System.Windows.Forms.TextBox textBoxNewWardsName;
        private System.Windows.Forms.Label labelNewWardsName;
        private System.Windows.Forms.TextBox textBoxWardsMaxCount;
        private System.Windows.Forms.Label labelNewWardsMaxCount;
    }
}
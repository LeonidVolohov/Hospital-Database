namespace HospitalDataBase {
    partial class SignUp {
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
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.textBoxUserRepeatPassword = new System.Windows.Forms.TextBox();
            this.labelUserRepeatPassword = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSignUp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.Location = new System.Drawing.Point(204, 401);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(173, 33);
            this.buttonSignUp.TabIndex = 9;
            this.buttonSignUp.Text = "Enter";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserPassword.Location = new System.Drawing.Point(23, 226);
            this.textBoxUserPassword.Multiline = true;
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.PasswordChar = '*';
            this.textBoxUserPassword.Size = new System.Drawing.Size(354, 33);
            this.textBoxUserPassword.TabIndex = 8;
            this.textBoxUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserPassword.Location = new System.Drawing.Point(23, 190);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(354, 33);
            this.labelUserPassword.TabIndex = 7;
            this.labelUserPassword.Text = "Password";
            this.labelUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserLogin.Location = new System.Drawing.Point(23, 137);
            this.textBoxUserLogin.Multiline = true;
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(354, 33);
            this.textBoxUserLogin.TabIndex = 6;
            this.textBoxUserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserLogin.Location = new System.Drawing.Point(23, 91);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(354, 33);
            this.labelUserLogin.TabIndex = 5;
            this.labelUserLogin.Text = "Login";
            this.labelUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUserRepeatPassword
            // 
            this.textBoxUserRepeatPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserRepeatPassword.Location = new System.Drawing.Point(23, 324);
            this.textBoxUserRepeatPassword.Multiline = true;
            this.textBoxUserRepeatPassword.Name = "textBoxUserRepeatPassword";
            this.textBoxUserRepeatPassword.PasswordChar = '*';
            this.textBoxUserRepeatPassword.Size = new System.Drawing.Size(354, 33);
            this.textBoxUserRepeatPassword.TabIndex = 11;
            this.textBoxUserRepeatPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUserRepeatPassword
            // 
            this.labelUserRepeatPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserRepeatPassword.Location = new System.Drawing.Point(23, 288);
            this.labelUserRepeatPassword.Name = "labelUserRepeatPassword";
            this.labelUserRepeatPassword.Size = new System.Drawing.Size(354, 33);
            this.labelUserRepeatPassword.TabIndex = 10;
            this.labelUserRepeatPassword.Text = "Repeat password";
            this.labelUserRepeatPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBack.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(23, 401);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(175, 33);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Go back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxUserRepeatPassword);
            this.Controls.Add(this.labelUserRepeatPassword);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.textBoxUserLogin);
            this.Controls.Add(this.labelUserLogin);
            this.MaximumSize = new System.Drawing.Size(400, 480);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.TextBox textBoxUserLogin;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.TextBox textBoxUserRepeatPassword;
        private System.Windows.Forms.Label labelUserRepeatPassword;
        private System.Windows.Forms.Button buttonBack;
    }
}
namespace HospitalDataBase {
    partial class SignIn {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserLogin.Location = new System.Drawing.Point(23, 115);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(354, 33);
            this.labelUserLogin.TabIndex = 0;
            this.labelUserLogin.Text = "Login";
            this.labelUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserLogin.Location = new System.Drawing.Point(23, 161);
            this.textBoxUserLogin.Multiline = true;
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(354, 33);
            this.textBoxUserLogin.TabIndex = 1;
            this.textBoxUserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserPassword.Location = new System.Drawing.Point(23, 260);
            this.textBoxUserPassword.Multiline = true;
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.PasswordChar = '*';
            this.textBoxUserPassword.Size = new System.Drawing.Size(354, 33);
            this.textBoxUserPassword.TabIndex = 3;
            this.textBoxUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserPassword.Location = new System.Drawing.Point(23, 214);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(354, 33);
            this.labelUserPassword.TabIndex = 2;
            this.labelUserPassword.Text = "Password";
            this.labelUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSignIn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignIn.Location = new System.Drawing.Point(127, 299);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(150, 33);
            this.buttonSignIn.TabIndex = 4;
            this.buttonSignIn.Text = "Enter";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // labelSignUp
            // 
            this.labelSignUp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSignUp.Location = new System.Drawing.Point(23, 427);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(170, 33);
            this.labelSignUp.TabIndex = 5;
            this.labelSignUp.Text = "New to this ->";
            this.labelSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSignUp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.Location = new System.Drawing.Point(207, 427);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(170, 33);
            this.buttonSignUp.TabIndex = 6;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.textBoxUserLogin);
            this.Controls.Add(this.labelUserLogin);
            this.MinimumSize = new System.Drawing.Size(400, 480);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.TextBox textBoxUserLogin;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Button buttonSignUp;
    }
}


namespace LawFirmAutomationSystem
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.materialLabelLogin = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.signInButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel files(*.xlsx)|*.xlsx";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(125, 103);
            this.login.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.login.MaxLength = 50;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(250, 26);
            this.login.TabIndex = 0;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(125, 159);
            this.password.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.password.MaxLength = 50;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(250, 26);
            this.password.TabIndex = 1;
            // 
            // materialLabelLogin
            // 
            this.materialLabelLogin.AutoSize = true;
            this.materialLabelLogin.BackColor = System.Drawing.Color.White;
            this.materialLabelLogin.Depth = 0;
            this.materialLabelLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelLogin.Location = new System.Drawing.Point(50, 106);
            this.materialLabelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabelLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelLogin.Name = "materialLabelLogin";
            this.materialLabelLogin.Size = new System.Drawing.Size(53, 19);
            this.materialLabelLogin.TabIndex = 5;
            this.materialLabelLogin.Text = "Логин";
            // 
            // materialLabelPassword
            // 
            this.materialLabelPassword.AutoSize = true;
            this.materialLabelPassword.BackColor = System.Drawing.Color.White;
            this.materialLabelPassword.Depth = 0;
            this.materialLabelPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelPassword.Location = new System.Drawing.Point(50, 162);
            this.materialLabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPassword.Name = "materialLabelPassword";
            this.materialLabelPassword.Size = new System.Drawing.Size(62, 19);
            this.materialLabelPassword.TabIndex = 6;
            this.materialLabelPassword.Text = "Пароль";
            // 
            // signInButton
            // 
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.Depth = 0;
            this.signInButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.Location = new System.Drawing.Point(184, 227);
            this.signInButton.Margin = new System.Windows.Forms.Padding(2);
            this.signInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signInButton.Name = "signInButton";
            this.signInButton.Primary = true;
            this.signInButton.Size = new System.Drawing.Size(106, 31);
            this.signInButton.TabIndex = 7;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(458, 289);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.materialLabelPassword);
            this.Controls.Add(this.materialLabelLogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private MaterialSkin.Controls.MaterialLabel materialLabelLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabelPassword;
        private MaterialSkin.Controls.MaterialRaisedButton signInButton;
    }
}


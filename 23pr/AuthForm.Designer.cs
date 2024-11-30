namespace _23pr
{
    partial class AuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(80, 112);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(192, 21);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(80, 76);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(192, 21);
            textBoxLogin.TabIndex = 3;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Times New Roman", 12F);
            labelLogin.Location = new Point(22, 78);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(52, 19);
            labelLogin.TabIndex = 4;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Times New Roman", 12F);
            labelPassword.Location = new Point(16, 112);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(58, 19);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Пароль";
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Times New Roman", 12F);
            buttonRegister.Location = new Point(137, 162);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(135, 37);
            buttonRegister.TabIndex = 6;
            buttonRegister.Text = "Авторизаться";
            buttonRegister.UseVisualStyleBackColor = true;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 211);
            Controls.Add(buttonRegister);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            MaximumSize = new Size(300, 250);
            Name = "AuthForm";
            Text = "AuthForm";
            Load += AuthForm_Load;
            Controls.SetChildIndex(textBoxPassword, 0);
            Controls.SetChildIndex(textBoxLogin, 0);
            Controls.SetChildIndex(labelLogin, 0);
            Controls.SetChildIndex(labelPassword, 0);
            Controls.SetChildIndex(buttonRegister, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label labelLogin;
        private Label labelPassword;
        private Button buttonRegister;
    }
}
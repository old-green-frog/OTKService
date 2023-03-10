namespace OTKService.Forms
{
    partial class AuthorizeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.AuthorizeButton = new System.Windows.Forms.Button();
            this.PasswordVisibleCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(385, 176);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.PlaceholderText = "Логин";
            this.LoginBox.Size = new System.Drawing.Size(204, 23);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.WordWrap = false;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(385, 240);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PlaceholderText = "Пароль";
            this.PasswordBox.Size = new System.Drawing.Size(204, 23);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.WordWrap = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(398, 103);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(174, 35);
            this.Title.TabIndex = 2;
            this.Title.Text = "СистемаОТК";
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorizeButton.Location = new System.Drawing.Point(398, 327);
            this.AuthorizeButton.Name = "AuthorizeButton";
            this.AuthorizeButton.Size = new System.Drawing.Size(174, 40);
            this.AuthorizeButton.TabIndex = 4;
            this.AuthorizeButton.Text = "Вход";
            this.AuthorizeButton.UseVisualStyleBackColor = true;
            this.AuthorizeButton.Click += new System.EventHandler(this.OnAuthorize);
            // 
            // PasswordVisibleCheck
            // 
            this.PasswordVisibleCheck.AutoSize = true;
            this.PasswordVisibleCheck.Location = new System.Drawing.Point(470, 269);
            this.PasswordVisibleCheck.Name = "PasswordVisibleCheck";
            this.PasswordVisibleCheck.Size = new System.Drawing.Size(119, 19);
            this.PasswordVisibleCheck.TabIndex = 5;
            this.PasswordVisibleCheck.Text = "Показать пароль";
            this.PasswordVisibleCheck.UseVisualStyleBackColor = true;
            this.PasswordVisibleCheck.CheckedChanged += new System.EventHandler(this.PasswordVisibleCheckChange);
            // 
            // AuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.PasswordVisibleCheck);
            this.Controls.Add(this.AuthorizeButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "AuthorizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СистемаОТК-Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Label Title;
        private Button AuthorizeButton;
        private CheckBox PasswordVisibleCheck;
    }
}
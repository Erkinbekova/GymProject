namespace Gym
{
    partial class Login
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
            this.logUserName = new System.Windows.Forms.TextBox();
            this.logPassword = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logUserName
            // 
            this.logUserName.Location = new System.Drawing.Point(381, 160);
            this.logUserName.Multiline = true;
            this.logUserName.Name = "logUserName";
            this.logUserName.Size = new System.Drawing.Size(248, 36);
            this.logUserName.TabIndex = 2;
            // 
            // logPassword
            // 
            this.logPassword.Location = new System.Drawing.Point(381, 283);
            this.logPassword.Multiline = true;
            this.logPassword.Name = "logPassword";
            this.logPassword.PasswordChar = '*';
            this.logPassword.Size = new System.Drawing.Size(248, 36);
            this.logPassword.TabIndex = 6;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(256, 173);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(65, 23);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "Логин";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пароль";
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.Control;
            this.btnLog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLog.Location = new System.Drawing.Point(381, 401);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(90, 40);
            this.btnLog.TabIndex = 11;
            this.btnLog.Text = "Войти\r\n";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // bntExit
            // 
            this.bntExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntExit.Location = new System.Drawing.Point(539, 401);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(90, 40);
            this.bntExit.TabIndex = 12;
            this.bntExit.Text = "Выход";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.logPassword);
            this.Controls.Add(this.logUserName);
            this.Name = "Login";
            this.Text = "Войти";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logUserName;
        private System.Windows.Forms.TextBox logPassword;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button bntExit;
    }
}


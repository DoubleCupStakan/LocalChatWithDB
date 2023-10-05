namespace ClientChat
{
    partial class Form1
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
            this.tbInsert = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.lbCallBack = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbInsert
            // 
            this.tbInsert.Location = new System.Drawing.Point(12, 353);
            this.tbInsert.Multiline = true;
            this.tbInsert.Name = "tbInsert";
            this.tbInsert.Size = new System.Drawing.Size(660, 85);
            this.tbInsert.TabIndex = 1;
            this.tbInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInsert_KeyDown);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(688, 40);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 26);
            this.tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(688, 8);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 26);
            this.tbUsername.TabIndex = 3;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(688, 378);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(100, 36);
            this.bConnect.TabIndex = 4;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // lbCallBack
            // 
            this.lbCallBack.FormattingEnabled = true;
            this.lbCallBack.ItemHeight = 20;
            this.lbCallBack.Location = new System.Drawing.Point(12, 15);
            this.lbCallBack.Name = "lbCallBack";
            this.lbCallBack.ScrollAlwaysVisible = true;
            this.lbCallBack.Size = new System.Drawing.Size(660, 324);
            this.lbCallBack.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCallBack);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbInsert;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.ListBox lbCallBack;
    }
}


namespace ClientChat
{
    partial class AuthorizeForm
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
            this.tbUserAutho = new System.Windows.Forms.TextBox();
            this.tbPassAutho = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbUserAutho
            // 
            this.tbUserAutho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserAutho.Location = new System.Drawing.Point(185, 90);
            this.tbUserAutho.Multiline = true;
            this.tbUserAutho.Name = "tbUserAutho";
            this.tbUserAutho.Size = new System.Drawing.Size(420, 91);
            this.tbUserAutho.TabIndex = 0;
            // 
            // tbPassAutho
            // 
            this.tbPassAutho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassAutho.Location = new System.Drawing.Point(185, 187);
            this.tbPassAutho.Multiline = true;
            this.tbPassAutho.Name = "tbPassAutho";
            this.tbPassAutho.PasswordChar = '*';
            this.tbPassAutho.Size = new System.Drawing.Size(420, 89);
            this.tbPassAutho.TabIndex = 1;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(185, 291);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(420, 95);
            this.bLogin.TabIndex = 2;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(348, 398);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registartion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tbPassAutho);
            this.Controls.Add(this.tbUserAutho);
            this.Name = "AuthorizeForm";
            this.Text = "AuthorizeForm";
            this.Load += new System.EventHandler(this.AuthorizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserAutho;
        private System.Windows.Forms.TextBox tbPassAutho;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
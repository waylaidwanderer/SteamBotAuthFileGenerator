namespace SteamBotAuthFileGenerator
{
    partial class Form1
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
            this.label_shared_secret = new System.Windows.Forms.Label();
            this.label_identity_secret = new System.Windows.Forms.Label();
            this.label_account_name = new System.Windows.Forms.Label();
            this.button_generate = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_account_name = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_shared_secret = new System.Windows.Forms.TextBox();
            this.textBox_identity_secret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_shared_secret
            // 
            this.label_shared_secret.AutoSize = true;
            this.label_shared_secret.Location = new System.Drawing.Point(36, 71);
            this.label_shared_secret.Name = "label_shared_secret";
            this.label_shared_secret.Size = new System.Drawing.Size(75, 13);
            this.label_shared_secret.TabIndex = 0;
            this.label_shared_secret.Text = "Shared Secret";
            // 
            // label_identity_secret
            // 
            this.label_identity_secret.AutoSize = true;
            this.label_identity_secret.Location = new System.Drawing.Point(36, 97);
            this.label_identity_secret.Name = "label_identity_secret";
            this.label_identity_secret.Size = new System.Drawing.Size(75, 13);
            this.label_identity_secret.TabIndex = 1;
            this.label_identity_secret.Text = "Identity Secret";
            // 
            // label_account_name
            // 
            this.label_account_name.AutoSize = true;
            this.label_account_name.Location = new System.Drawing.Point(56, 19);
            this.label_account_name.Name = "label_account_name";
            this.label_account_name.Size = new System.Drawing.Size(55, 13);
            this.label_account_name.TabIndex = 2;
            this.label_account_name.Text = "Username";
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(125, 129);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(75, 23);
            this.button_generate.TabIndex = 3;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(58, 45);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // textBox_account_name
            // 
            this.textBox_account_name.Location = new System.Drawing.Point(117, 16);
            this.textBox_account_name.Name = "textBox_account_name";
            this.textBox_account_name.Size = new System.Drawing.Size(171, 20);
            this.textBox_account_name.TabIndex = 5;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(117, 42);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(171, 20);
            this.textBox_password.TabIndex = 6;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_shared_secret
            // 
            this.textBox_shared_secret.Location = new System.Drawing.Point(117, 68);
            this.textBox_shared_secret.Name = "textBox_shared_secret";
            this.textBox_shared_secret.Size = new System.Drawing.Size(171, 20);
            this.textBox_shared_secret.TabIndex = 7;
            // 
            // textBox_identity_secret
            // 
            this.textBox_identity_secret.Location = new System.Drawing.Point(117, 94);
            this.textBox_identity_secret.Name = "textBox_identity_secret";
            this.textBox_identity_secret.Size = new System.Drawing.Size(171, 20);
            this.textBox_identity_secret.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_generate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 169);
            this.Controls.Add(this.textBox_identity_secret);
            this.Controls.Add(this.textBox_shared_secret);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_account_name);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.label_account_name);
            this.Controls.Add(this.label_identity_secret);
            this.Controls.Add(this.label_shared_secret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteamBot .auth Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_shared_secret;
        private System.Windows.Forms.Label label_identity_secret;
        private System.Windows.Forms.Label label_account_name;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_account_name;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_shared_secret;
        private System.Windows.Forms.TextBox textBox_identity_secret;
    }
}


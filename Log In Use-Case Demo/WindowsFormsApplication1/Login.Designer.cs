namespace WindowsFormsApplication1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxUserName = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.rbtnUser = new System.Windows.Forms.RadioButton();
            this.rbtnLibrarian = new System.Windows.Forms.RadioButton();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tBoxUserName
            // 
            this.tBoxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxUserName.Location = new System.Drawing.Point(299, 158);
            this.tBoxUserName.Margin = new System.Windows.Forms.Padding(5);
            this.tBoxUserName.Name = "tBoxUserName";
            this.tBoxUserName.Size = new System.Drawing.Size(361, 22);
            this.tBoxUserName.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxPassword.Location = new System.Drawing.Point(299, 238);
            this.tBoxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(361, 22);
            this.tBoxPassword.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-518, 517);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1748, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(299, 334);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.MaximumSize = new System.Drawing.Size(368, 54);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(361, 54);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRegister.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(299, 398);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.MaximumSize = new System.Drawing.Size(368, 54);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(361, 54);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // rbtnUser
            // 
            this.rbtnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtnUser.AutoSize = true;
            this.rbtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnUser.Location = new System.Drawing.Point(299, 279);
            this.rbtnUser.Name = "rbtnUser";
            this.rbtnUser.Padding = new System.Windows.Forms.Padding(5);
            this.rbtnUser.Size = new System.Drawing.Size(75, 32);
            this.rbtnUser.TabIndex = 11;
            this.rbtnUser.TabStop = true;
            this.rbtnUser.Text = "User";
            this.rbtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnUser.UseVisualStyleBackColor = true;
            // 
            // rbtnLibrarian
            // 
            this.rbtnLibrarian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtnLibrarian.AutoSize = true;
            this.rbtnLibrarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnLibrarian.Location = new System.Drawing.Point(435, 278);
            this.rbtnLibrarian.Name = "rbtnLibrarian";
            this.rbtnLibrarian.Padding = new System.Windows.Forms.Padding(5);
            this.rbtnLibrarian.Size = new System.Drawing.Size(104, 32);
            this.rbtnLibrarian.TabIndex = 11;
            this.rbtnLibrarian.TabStop = true;
            this.rbtnLibrarian.Text = "Librarian";
            this.rbtnLibrarian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnLibrarian.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnAdmin.Location = new System.Drawing.Point(575, 279);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Padding = new System.Windows.Forms.Padding(5);
            this.rbtnAdmin.Size = new System.Drawing.Size(85, 32);
            this.rbtnAdmin.TabIndex = 11;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(206)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(955, 802);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.rbtnLibrarian);
            this.Controls.Add(this.rbtnUser);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.Text = "Library Book Loan System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxUserName;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RadioButton rbtnUser;
        private System.Windows.Forms.RadioButton rbtnLibrarian;
        private System.Windows.Forms.RadioButton rbtnAdmin;
    }
}


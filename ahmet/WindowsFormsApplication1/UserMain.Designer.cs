namespace WindowsFormsApplication1
{
    partial class UserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.dataGridViewuserBooks = new System.Windows.Forms.DataGridView();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnInf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuserBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(218, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateProfile.Location = new System.Drawing.Point(14, 105);
            this.btnUpdateProfile.MaximumSize = new System.Drawing.Size(111, 35);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(111, 35);
            this.btnUpdateProfile.TabIndex = 7;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // dataGridViewuserBooks
            // 
            this.dataGridViewuserBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewuserBooks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewuserBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewuserBooks.Location = new System.Drawing.Point(47, 244);
            this.dataGridViewuserBooks.Name = "dataGridViewuserBooks";
            this.dataGridViewuserBooks.RowTemplate.Height = 24;
            this.dataGridViewuserBooks.Size = new System.Drawing.Size(543, 178);
            this.dataGridViewuserBooks.TabIndex = 8;
            this.dataGridViewuserBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewuserBooks_CellContentClick);
            // 
            // btnLoan
            // 
            this.btnLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoan.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoan.Location = new System.Drawing.Point(131, 105);
            this.btnLoan.MaximumSize = new System.Drawing.Size(111, 35);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(111, 35);
            this.btnLoan.TabIndex = 7;
            this.btnLoan.Text = "Loan Book";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(248, 105);
            this.btnReturn.MaximumSize = new System.Drawing.Size(111, 35);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(111, 35);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.Location = new System.Drawing.Point(520, 105);
            this.btnLogOut.MaximumSize = new System.Drawing.Size(111, 35);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(111, 35);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnInf
            // 
            this.btnInf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInf.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.btnInf.Location = new System.Drawing.Point(365, 105);
            this.btnInf.MaximumSize = new System.Drawing.Size(555, 555);
            this.btnInf.Name = "btnInf";
            this.btnInf.Size = new System.Drawing.Size(149, 35);
            this.btnInf.TabIndex = 7;
            this.btnInf.Text = "Check Information";
            this.btnInf.UseVisualStyleBackColor = true;
            this.btnInf.Click += new System.EventHandler(this.btnInf_Click);
            // 
            // UserMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 570);
            this.Controls.Add(this.dataGridViewuserBooks);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.btnInf);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Book Loan System";
            this.Load += new System.EventHandler(this.UserMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuserBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.DataGridView dataGridViewuserBooks;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnInf;



    }
}
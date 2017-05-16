namespace WindowsFormsApplication1
{
    partial class Information
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRec = new System.Windows.Forms.Label();
            this.lblRet = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(79, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Received Date                                         :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(77, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "You must return this book until this Date  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(79, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Your initial debt is                                   :";
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lblRec.Location = new System.Drawing.Point(425, 38);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(0, 31);
            this.lblRec.TabIndex = 0;
            // 
            // lblRet
            // 
            this.lblRet.AutoSize = true;
            this.lblRet.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lblRet.Location = new System.Drawing.Point(431, 69);
            this.lblRet.Name = "lblRet";
            this.lblRet.Size = new System.Drawing.Size(0, 31);
            this.lblRet.TabIndex = 1;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lblDep.Location = new System.Drawing.Point(425, 103);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(0, 31);
            this.lblDep.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnOK.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(616, 138);
            this.btnOK.MaximumSize = new System.Drawing.Size(111, 35);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 35);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 185);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRec);
            this.Controls.Add(this.label1);
            this.Name = "Information";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.Label lblRet;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Button btnOK;
    }
}

namespace ISP_MANAGMENT_SYSTETEM
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.proceedBtn = new System.Windows.Forms.PictureBox();
            this.adminBtn = new System.Windows.Forms.PictureBox();
            this.workerBtn = new System.Windows.Forms.PictureBox();
            this.cnclBtn = new System.Windows.Forms.PictureBox();
            this.ForgetPasword = new System.Windows.Forms.PictureBox();
            this.pasword = new System.Windows.Forms.TextBox();
            this.workerProccedBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proceedBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnclBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForgetPasword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerProccedBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // proceedBtn
            // 
            this.proceedBtn.BackColor = System.Drawing.Color.Transparent;
            this.proceedBtn.Location = new System.Drawing.Point(421, 328);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(160, 44);
            this.proceedBtn.TabIndex = 0;
            this.proceedBtn.TabStop = false;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            this.proceedBtn.MouseEnter += new System.EventHandler(this.proceedBtn_MouseEnter);
            this.proceedBtn.MouseLeave += new System.EventHandler(this.proceedBtn_MouseLeave);
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.Transparent;
            this.adminBtn.Location = new System.Drawing.Point(28, 12);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(317, 50);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.TabStop = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // workerBtn
            // 
            this.workerBtn.BackColor = System.Drawing.Color.Transparent;
            this.workerBtn.Location = new System.Drawing.Point(362, 12);
            this.workerBtn.Name = "workerBtn";
            this.workerBtn.Size = new System.Drawing.Size(283, 50);
            this.workerBtn.TabIndex = 2;
            this.workerBtn.TabStop = false;
            this.workerBtn.Click += new System.EventHandler(this.workerBtn_Click);
            // 
            // cnclBtn
            // 
            this.cnclBtn.BackColor = System.Drawing.Color.Transparent;
            this.cnclBtn.Location = new System.Drawing.Point(653, 14);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(44, 37);
            this.cnclBtn.TabIndex = 3;
            this.cnclBtn.TabStop = false;
            this.cnclBtn.Click += new System.EventHandler(this.cnclBtn_Click);
            // 
            // ForgetPasword
            // 
            this.ForgetPasword.BackColor = System.Drawing.Color.Transparent;
            this.ForgetPasword.Location = new System.Drawing.Point(423, 382);
            this.ForgetPasword.Name = "ForgetPasword";
            this.ForgetPasword.Size = new System.Drawing.Size(164, 40);
            this.ForgetPasword.TabIndex = 4;
            this.ForgetPasword.TabStop = false;
            this.ForgetPasword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForgetPasword_MouseDown);
            this.ForgetPasword.MouseEnter += new System.EventHandler(this.ForgetPasword_MouseEnter);
            this.ForgetPasword.MouseLeave += new System.EventHandler(this.ForgetPasword_MouseLeave);
            // 
            // pasword
            // 
            this.pasword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasword.Location = new System.Drawing.Point(298, 260);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(263, 22);
            this.pasword.TabIndex = 5;
            // 
            // workerProccedBtn
            // 
            this.workerProccedBtn.BackColor = System.Drawing.Color.Transparent;
            this.workerProccedBtn.Location = new System.Drawing.Point(280, 284);
            this.workerProccedBtn.Name = "workerProccedBtn";
            this.workerProccedBtn.Size = new System.Drawing.Size(160, 44);
            this.workerProccedBtn.TabIndex = 6;
            this.workerProccedBtn.TabStop = false;
            this.workerProccedBtn.Click += new System.EventHandler(this.workerProccedBtn_Click);
            this.workerProccedBtn.MouseEnter += new System.EventHandler(this.workerProccedBtn_MouseEnter);
            this.workerProccedBtn.MouseLeave += new System.EventHandler(this.workerProccedBtn_MouseLeave);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.adminSelected;
            this.ClientSize = new System.Drawing.Size(720, 455);
            this.Controls.Add(this.workerProccedBtn);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.ForgetPasword);
            this.Controls.Add(this.cnclBtn);
            this.Controls.Add(this.workerBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.proceedBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proceedBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnclBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForgetPasword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerProccedBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox proceedBtn;
        private System.Windows.Forms.PictureBox adminBtn;
        private System.Windows.Forms.PictureBox workerBtn;
        private System.Windows.Forms.PictureBox cnclBtn;
        private System.Windows.Forms.PictureBox ForgetPasword;
        private System.Windows.Forms.TextBox pasword;
        private System.Windows.Forms.PictureBox workerProccedBtn;
    }
}


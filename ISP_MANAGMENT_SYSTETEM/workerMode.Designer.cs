
namespace ISP_MANAGMENT_SYSTETEM
{
    partial class workerMode
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
            this.switchAcount = new System.Windows.Forms.PictureBox();
            this.crssBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.switchAcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crssBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // switchAcount
            // 
            this.switchAcount.BackColor = System.Drawing.Color.Transparent;
            this.switchAcount.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.switchAccountBtn;
            this.switchAcount.Location = new System.Drawing.Point(452, 162);
            this.switchAcount.Name = "switchAcount";
            this.switchAcount.Size = new System.Drawing.Size(148, 44);
            this.switchAcount.TabIndex = 0;
            this.switchAcount.TabStop = false;
            this.switchAcount.Click += new System.EventHandler(this.switchAcount_Click);
            this.switchAcount.MouseEnter += new System.EventHandler(this.switchAcount_MouseEnter);
            this.switchAcount.MouseLeave += new System.EventHandler(this.switchAcount_MouseLeave);
            // 
            // crssBtn
            // 
            this.crssBtn.BackColor = System.Drawing.Color.Transparent;
            this.crssBtn.Location = new System.Drawing.Point(614, 12);
            this.crssBtn.Name = "crssBtn";
            this.crssBtn.Size = new System.Drawing.Size(39, 34);
            this.crssBtn.TabIndex = 1;
            this.crssBtn.TabStop = false;
            this.crssBtn.Click += new System.EventHandler(this.crssBtn_Click);
            // 
            // workerMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.WorkerMode;
            this.ClientSize = new System.Drawing.Size(665, 250);
            this.Controls.Add(this.crssBtn);
            this.Controls.Add(this.switchAcount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "workerMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "workerMode";
            ((System.ComponentModel.ISupportInitialize)(this.switchAcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crssBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox switchAcount;
        private System.Windows.Forms.PictureBox crssBtn;
    }
}
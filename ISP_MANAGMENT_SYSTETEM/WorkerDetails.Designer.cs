
using System;

namespace ISP_MANAGMENT_SYSTETEM
{
    partial class WorkerDetails
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
            this.workerID = new System.Windows.Forms.TextBox();
            this.workerName = new System.Windows.Forms.TextBox();
            this.workerAddress = new System.Windows.Forms.TextBox();
            this.workerMobile = new System.Windows.Forms.TextBox();
            this.workerPay = new System.Windows.Forms.TextBox();
            this.comissionOfWorker = new System.Windows.Forms.TextBox();
            this.workerArea = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.PictureBox();
            this.submitbtn = new System.Windows.Forms.PictureBox();
            this.crossBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // workerID
            // 
            this.workerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerID.Location = new System.Drawing.Point(23, 80);
            this.workerID.Multiline = true;
            this.workerID.Name = "workerID";
            this.workerID.Size = new System.Drawing.Size(100, 23);
            this.workerID.TabIndex = 0;
            // 
            // workerName
            // 
            this.workerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(168, 80);
            this.workerName.Multiline = true;
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(162, 23);
            this.workerName.TabIndex = 1;
            // 
            // workerAddress
            // 
            this.workerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerAddress.Location = new System.Drawing.Point(168, 147);
            this.workerAddress.Multiline = true;
            this.workerAddress.Name = "workerAddress";
            this.workerAddress.Size = new System.Drawing.Size(162, 23);
            this.workerAddress.TabIndex = 2;
            // 
            // workerMobile
            // 
            this.workerMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerMobile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerMobile.Location = new System.Drawing.Point(23, 147);
            this.workerMobile.Multiline = true;
            this.workerMobile.Name = "workerMobile";
            this.workerMobile.Size = new System.Drawing.Size(100, 23);
            this.workerMobile.TabIndex = 3;
            // 
            // workerPay
            // 
            this.workerPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerPay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerPay.Location = new System.Drawing.Point(23, 214);
            this.workerPay.Multiline = true;
            this.workerPay.Name = "workerPay";
            this.workerPay.Size = new System.Drawing.Size(75, 23);
            this.workerPay.TabIndex = 4;
            // 
            // comissionOfWorker
            // 
            this.comissionOfWorker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comissionOfWorker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comissionOfWorker.Location = new System.Drawing.Point(128, 214);
            this.comissionOfWorker.Multiline = true;
            this.comissionOfWorker.Name = "comissionOfWorker";
            this.comissionOfWorker.Size = new System.Drawing.Size(75, 23);
            this.comissionOfWorker.TabIndex = 5;
            // 
            // workerArea
            // 
            this.workerArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.workerArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerArea.FormattingEnabled = true;
            this.workerArea.Location = new System.Drawing.Point(232, 214);
            this.workerArea.Name = "workerArea";
            this.workerArea.Size = new System.Drawing.Size(98, 24);
            this.workerArea.TabIndex = 6;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(221, 278);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(82, 24);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.Transparent;
            this.submitbtn.Location = new System.Drawing.Point(330, 278);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(82, 24);
            this.submitbtn.TabIndex = 8;
            this.submitbtn.TabStop = false;
            this.submitbtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // crossBtn
            // 
            this.crossBtn.BackColor = System.Drawing.Color.Transparent;
            this.crossBtn.Location = new System.Drawing.Point(393, 11);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(30, 18);
            this.crossBtn.TabIndex = 9;
            this.crossBtn.TabStop = false;
            this.crossBtn.Click += new System.EventHandler(this.crossBtn_Click);
            // 
            // WorkerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.workerdetails;
            this.ClientSize = new System.Drawing.Size(436, 312);
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.workerArea);
            this.Controls.Add(this.comissionOfWorker);
            this.Controls.Add(this.workerPay);
            this.Controls.Add(this.workerMobile);
            this.Controls.Add(this.workerAddress);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.workerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerDetails";
            this.Load += new System.EventHandler(this.WorkerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.TextBox workerID;
        private System.Windows.Forms.TextBox workerName;
        private System.Windows.Forms.TextBox workerAddress;
        private System.Windows.Forms.TextBox workerMobile;
        private System.Windows.Forms.TextBox workerPay;
        private System.Windows.Forms.TextBox comissionOfWorker;
        private System.Windows.Forms.ComboBox workerArea;
        private System.Windows.Forms.PictureBox cancelBtn;
        private System.Windows.Forms.PictureBox submitbtn;
        private System.Windows.Forms.PictureBox crossBtn;
    }
}
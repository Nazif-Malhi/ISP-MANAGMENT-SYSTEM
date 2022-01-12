
using System;

namespace ISP_MANAGMENT_SYSTETEM
{
    partial class userDetails
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
            this.packageOfClient = new System.Windows.Forms.ComboBox();
            this.areaOfClient = new System.Windows.Forms.ComboBox();
            this.customerId = new System.Windows.Forms.TextBox();
            this.mobileOfClient = new System.Windows.Forms.TextBox();
            this.addressofClient = new System.Windows.Forms.TextBox();
            this.extraCharges = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.PictureBox();
            this.submitBtm = new System.Windows.Forms.PictureBox();
            this.crossBtn = new System.Windows.Forms.PictureBox();
            this.nameOFClient = new System.Windows.Forms.TextBox();
            this.internetDiscount = new System.Windows.Forms.ComboBox();
            this.cableDiscount = new System.Windows.Forms.ComboBox();
            this.cablePackageOfClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitBtm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // packageOfClient
            // 
            this.packageOfClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.packageOfClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageOfClient.FormattingEnabled = true;
            this.packageOfClient.Location = new System.Drawing.Point(314, 86);
            this.packageOfClient.Name = "packageOfClient";
            this.packageOfClient.Size = new System.Drawing.Size(111, 25);
            this.packageOfClient.TabIndex = 0;
            // 
            // areaOfClient
            // 
            this.areaOfClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.areaOfClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaOfClient.FormattingEnabled = true;
            this.areaOfClient.Location = new System.Drawing.Point(314, 139);
            this.areaOfClient.Name = "areaOfClient";
            this.areaOfClient.Size = new System.Drawing.Size(111, 25);
            this.areaOfClient.TabIndex = 1;
            // 
            // customerId
            // 
            this.customerId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerId.Location = new System.Drawing.Point(43, 87);
            this.customerId.Multiline = true;
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(69, 23);
            this.customerId.TabIndex = 2;
            // 
            // mobileOfClient
            // 
            this.mobileOfClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mobileOfClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileOfClient.Location = new System.Drawing.Point(43, 140);
            this.mobileOfClient.Multiline = true;
            this.mobileOfClient.Name = "mobileOfClient";
            this.mobileOfClient.Size = new System.Drawing.Size(92, 23);
            this.mobileOfClient.TabIndex = 3;
            // 
            // addressofClient
            // 
            this.addressofClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressofClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressofClient.Location = new System.Drawing.Point(169, 140);
            this.addressofClient.Multiline = true;
            this.addressofClient.Name = "addressofClient";
            this.addressofClient.Size = new System.Drawing.Size(111, 23);
            this.addressofClient.TabIndex = 4;
            // 
            // extraCharges
            // 
            this.extraCharges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extraCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraCharges.Location = new System.Drawing.Point(24, 226);
            this.extraCharges.Multiline = true;
            this.extraCharges.Name = "extraCharges";
            this.extraCharges.Size = new System.Drawing.Size(92, 23);
            this.extraCharges.TabIndex = 5;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(256, 295);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(83, 28);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtm
            // 
            this.submitBtm.BackColor = System.Drawing.Color.Transparent;
            this.submitBtm.Location = new System.Drawing.Point(363, 295);
            this.submitBtm.Name = "submitBtm";
            this.submitBtm.Size = new System.Drawing.Size(81, 28);
            this.submitBtm.TabIndex = 9;
            this.submitBtm.TabStop = false;
            this.submitBtm.Click += new System.EventHandler(this.submitBtm_Click);
            // 
            // crossBtn
            // 
            this.crossBtn.BackColor = System.Drawing.Color.Transparent;
            this.crossBtn.Location = new System.Drawing.Point(475, 12);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(27, 17);
            this.crossBtn.TabIndex = 10;
            this.crossBtn.TabStop = false;
            this.crossBtn.Click += new System.EventHandler(this.crossBtn_Click);
            // 
            // nameOFClient
            // 
            this.nameOFClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOFClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOFClient.Location = new System.Drawing.Point(169, 87);
            this.nameOFClient.Multiline = true;
            this.nameOFClient.Name = "nameOFClient";
            this.nameOFClient.Size = new System.Drawing.Size(111, 23);
            this.nameOFClient.TabIndex = 11;
            // 
            // internetDiscount
            // 
            this.internetDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.internetDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internetDiscount.FormattingEnabled = true;
            this.internetDiscount.Location = new System.Drawing.Point(150, 226);
            this.internetDiscount.Name = "internetDiscount";
            this.internetDiscount.Size = new System.Drawing.Size(93, 25);
            this.internetDiscount.TabIndex = 12;
            // 
            // cableDiscount
            // 
            this.cableDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cableDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cableDiscount.FormattingEnabled = true;
            this.cableDiscount.Location = new System.Drawing.Point(276, 226);
            this.cableDiscount.Name = "cableDiscount";
            this.cableDiscount.Size = new System.Drawing.Size(93, 25);
            this.cableDiscount.TabIndex = 13;
            // 
            // cablePackageOfClient
            // 
            this.cablePackageOfClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cablePackageOfClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cablePackageOfClient.FormattingEnabled = true;
            this.cablePackageOfClient.Location = new System.Drawing.Point(395, 226);
            this.cablePackageOfClient.Name = "cablePackageOfClient";
            this.cablePackageOfClient.Size = new System.Drawing.Size(93, 25);
            this.cablePackageOfClient.TabIndex = 14;
            // 
            // userDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.connectionDetails;
            this.ClientSize = new System.Drawing.Size(514, 350);
            this.Controls.Add(this.cablePackageOfClient);
            this.Controls.Add(this.cableDiscount);
            this.Controls.Add(this.internetDiscount);
            this.Controls.Add(this.nameOFClient);
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.submitBtm);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.extraCharges);
            this.Controls.Add(this.addressofClient);
            this.Controls.Add(this.mobileOfClient);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.areaOfClient);
            this.Controls.Add(this.packageOfClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userDetails";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.userDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitBtm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
        #endregion

        private System.Windows.Forms.ComboBox packageOfClient;
        private System.Windows.Forms.ComboBox areaOfClient;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.TextBox mobileOfClient;
        private System.Windows.Forms.TextBox addressofClient;
        private System.Windows.Forms.TextBox extraCharges;
        private System.Windows.Forms.PictureBox cancelBtn;
        private System.Windows.Forms.PictureBox submitBtm;
        private System.Windows.Forms.PictureBox crossBtn;
        private System.Windows.Forms.TextBox nameOFClient;
        private System.Windows.Forms.ComboBox internetDiscount;
        private System.Windows.Forms.ComboBox cableDiscount;
        private System.Windows.Forms.ComboBox cablePackageOfClient;
    }
}
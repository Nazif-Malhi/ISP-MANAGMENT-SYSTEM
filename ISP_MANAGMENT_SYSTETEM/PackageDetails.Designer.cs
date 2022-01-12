
using System;

namespace ISP_MANAGMENT_SYSTETEM
{
    partial class PackageDetails
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
            this.packageID = new System.Windows.Forms.TextBox();
            this.actualPrice = new System.Windows.Forms.TextBox();
            this.priceToClient = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.PictureBox();
            this.submitBtn = new System.Windows.Forms.PictureBox();
            this.cancelCross = new System.Windows.Forms.PictureBox();
            this.packageName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelCross)).BeginInit();
            this.SuspendLayout();
            // 
            // packageID
            // 
            this.packageID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.packageID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageID.Location = new System.Drawing.Point(23, 80);
            this.packageID.Multiline = true;
            this.packageID.Name = "packageID";
            this.packageID.Size = new System.Drawing.Size(99, 21);
            this.packageID.TabIndex = 0;
            // 
            // actualPrice
            // 
            this.actualPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actualPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualPrice.Location = new System.Drawing.Point(23, 147);
            this.actualPrice.Multiline = true;
            this.actualPrice.Name = "actualPrice";
            this.actualPrice.Size = new System.Drawing.Size(99, 23);
            this.actualPrice.TabIndex = 2;
            // 
            // priceToClient
            // 
            this.priceToClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceToClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceToClient.Location = new System.Drawing.Point(193, 147);
            this.priceToClient.Multiline = true;
            this.priceToClient.Name = "priceToClient";
            this.priceToClient.Size = new System.Drawing.Size(121, 23);
            this.priceToClient.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(180, 223);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(81, 27);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.Location = new System.Drawing.Point(286, 223);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(81, 27);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.TabStop = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelCross
            // 
            this.cancelCross.BackColor = System.Drawing.Color.Transparent;
            this.cancelCross.Location = new System.Drawing.Point(375, 12);
            this.cancelCross.Name = "cancelCross";
            this.cancelCross.Size = new System.Drawing.Size(19, 14);
            this.cancelCross.TabIndex = 6;
            this.cancelCross.TabStop = false;
            this.cancelCross.Click += new System.EventHandler(this.cancelCross_Click);
            // 
            // packageName
            // 
            this.packageName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.packageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageName.FormattingEnabled = true;
            this.packageName.Location = new System.Drawing.Point(193, 80);
            this.packageName.Name = "packageName";
            this.packageName.Size = new System.Drawing.Size(122, 24);
            this.packageName.TabIndex = 7;
            // 
            // PackageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.packageDetailsForm;
            this.ClientSize = new System.Drawing.Size(413, 265);
            this.Controls.Add(this.packageName);
            this.Controls.Add(this.cancelCross);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.priceToClient);
            this.Controls.Add(this.actualPrice);
            this.Controls.Add(this.packageID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PackageDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PackageDetails";
            this.Load += new System.EventHandler(this.PackageDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelCross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.TextBox packageID;
        private System.Windows.Forms.TextBox actualPrice;
        private System.Windows.Forms.TextBox priceToClient;
        private System.Windows.Forms.PictureBox cancelBtn;
        private System.Windows.Forms.PictureBox submitBtn;
        private System.Windows.Forms.PictureBox cancelCross;
        private System.Windows.Forms.ComboBox packageName;
    }
}
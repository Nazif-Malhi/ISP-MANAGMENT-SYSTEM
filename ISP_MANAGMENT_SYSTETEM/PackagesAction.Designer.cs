
using System;

namespace ISP_MANAGMENT_SYSTETEM
{
    partial class PackagesAction
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
            this.editBtn = new System.Windows.Forms.PictureBox();
            this.delBtn = new System.Windows.Forms.PictureBox();
            this.cnclBtn = new System.Windows.Forms.PictureBox();
            this.crossBtn = new System.Windows.Forms.PictureBox();
            this.packageName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnclBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // packageID
            // 
            this.packageID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.packageID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageID.Location = new System.Drawing.Point(23, 80);
            this.packageID.Multiline = true;
            this.packageID.Name = "packageID";
            this.packageID.Size = new System.Drawing.Size(100, 20);
            this.packageID.TabIndex = 0;
            // 
            // actualPrice
            // 
            this.actualPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actualPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualPrice.Location = new System.Drawing.Point(23, 149);
            this.actualPrice.Multiline = true;
            this.actualPrice.Name = "actualPrice";
            this.actualPrice.Size = new System.Drawing.Size(100, 20);
            this.actualPrice.TabIndex = 1;
            // 
            // priceToClient
            // 
            this.priceToClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceToClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceToClient.Location = new System.Drawing.Point(193, 149);
            this.priceToClient.Multiline = true;
            this.priceToClient.Name = "priceToClient";
            this.priceToClient.Size = new System.Drawing.Size(120, 20);
            this.priceToClient.TabIndex = 2;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Location = new System.Drawing.Point(137, 205);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(79, 27);
            this.editBtn.TabIndex = 4;
            this.editBtn.TabStop = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Transparent;
            this.delBtn.Location = new System.Drawing.Point(225, 205);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(79, 27);
            this.delBtn.TabIndex = 5;
            this.delBtn.TabStop = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // cnclBtn
            // 
            this.cnclBtn.BackColor = System.Drawing.Color.Transparent;
            this.cnclBtn.Location = new System.Drawing.Point(314, 205);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(79, 27);
            this.cnclBtn.TabIndex = 6;
            this.cnclBtn.TabStop = false;
            this.cnclBtn.Click += new System.EventHandler(this.cnclBtn_Click);
            // 
            // crossBtn
            // 
            this.crossBtn.BackColor = System.Drawing.Color.Transparent;
            this.crossBtn.Location = new System.Drawing.Point(372, 12);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(26, 16);
            this.crossBtn.TabIndex = 7;
            this.crossBtn.TabStop = false;
            this.crossBtn.Click += new System.EventHandler(this.crossBtn_Click);
            // 
            // packageName
            // 
            this.packageName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.packageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageName.FormattingEnabled = true;
            this.packageName.Location = new System.Drawing.Point(193, 80);
            this.packageName.Name = "packageName";
            this.packageName.Size = new System.Drawing.Size(122, 24);
            this.packageName.TabIndex = 8;
            // 
            // PackagesAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.packagesAction;
            this.ClientSize = new System.Drawing.Size(413, 265);
            this.Controls.Add(this.packageName);
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.cnclBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.priceToClient);
            this.Controls.Add(this.actualPrice);
            this.Controls.Add(this.packageID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PackagesAction";
            this.Text = "PackagesAction";
            this.Load += new System.EventHandler(this.PackagesAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnclBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.TextBox packageID;
        private System.Windows.Forms.TextBox actualPrice;
        private System.Windows.Forms.TextBox priceToClient;
        private System.Windows.Forms.PictureBox editBtn;
        private System.Windows.Forms.PictureBox delBtn;
        private System.Windows.Forms.PictureBox cnclBtn;
        private System.Windows.Forms.PictureBox crossBtn;
        private System.Windows.Forms.ComboBox packageName;
    }
}

using System;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    partial class ConnectionAction
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
            this.customerID = new System.Windows.Forms.TextBox();
            this.nameOfClient = new System.Windows.Forms.TextBox();
            this.AdressOfClient = new System.Windows.Forms.TextBox();
            this.mobileNumber = new System.Windows.Forms.TextBox();
            this.extraCharges = new System.Windows.Forms.TextBox();
            this.packageComboBox = new System.Windows.Forms.ComboBox();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.cableDiscountComboBox = new System.Windows.Forms.ComboBox();
            this.internetDiscountComboBox = new System.Windows.Forms.ComboBox();
            this.editBtn = new System.Windows.Forms.PictureBox();
            this.delBtn = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.PictureBox();
            this.crossBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cablePackage = new System.Windows.Forms.ComboBox();
            this.previousDebt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerID
            // 
            this.customerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.Location = new System.Drawing.Point(44, 87);
            this.customerID.Multiline = true;
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(69, 23);
            this.customerID.TabIndex = 0;
            // 
            // nameOfClient
            // 
            this.nameOfClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfClient.Location = new System.Drawing.Point(168, 87);
            this.nameOfClient.Multiline = true;
            this.nameOfClient.Name = "nameOfClient";
            this.nameOfClient.Size = new System.Drawing.Size(111, 23);
            this.nameOfClient.TabIndex = 1;
            // 
            // AdressOfClient
            // 
            this.AdressOfClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdressOfClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressOfClient.Location = new System.Drawing.Point(170, 140);
            this.AdressOfClient.Multiline = true;
            this.AdressOfClient.Name = "AdressOfClient";
            this.AdressOfClient.Size = new System.Drawing.Size(109, 23);
            this.AdressOfClient.TabIndex = 4;
            // 
            // mobileNumber
            // 
            this.mobileNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumber.Location = new System.Drawing.Point(44, 140);
            this.mobileNumber.Multiline = true;
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(90, 23);
            this.mobileNumber.TabIndex = 5;
            // 
            // extraCharges
            // 
            this.extraCharges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extraCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraCharges.Location = new System.Drawing.Point(24, 222);
            this.extraCharges.Multiline = true;
            this.extraCharges.Name = "extraCharges";
            this.extraCharges.Size = new System.Drawing.Size(90, 23);
            this.extraCharges.TabIndex = 6;
            this.extraCharges.TextChanged += new System.EventHandler(this.extraCharges_TextChanged);
            // 
            // packageComboBox
            // 
            this.packageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.packageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageComboBox.FormattingEnabled = true;
            this.packageComboBox.Location = new System.Drawing.Point(314, 87);
            this.packageComboBox.Name = "packageComboBox";
            this.packageComboBox.Size = new System.Drawing.Size(111, 24);
            this.packageComboBox.TabIndex = 7;
            this.packageComboBox.SelectedIndexChanged += new System.EventHandler(this.packageComboBox_SelectedIndexChanged);
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AreaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(314, 140);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(111, 24);
            this.AreaComboBox.TabIndex = 8;
            // 
            // cableDiscountComboBox
            // 
            this.cableDiscountComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cableDiscountComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cableDiscountComboBox.FormattingEnabled = true;
            this.cableDiscountComboBox.Location = new System.Drawing.Point(276, 222);
            this.cableDiscountComboBox.Name = "cableDiscountComboBox";
            this.cableDiscountComboBox.Size = new System.Drawing.Size(92, 24);
            this.cableDiscountComboBox.TabIndex = 9;
            this.cableDiscountComboBox.SelectedIndexChanged += new System.EventHandler(this.cableDiscountComboBox_SelectedIndexChanged);
            // 
            // internetDiscountComboBox
            // 
            this.internetDiscountComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.internetDiscountComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internetDiscountComboBox.FormattingEnabled = true;
            this.internetDiscountComboBox.Location = new System.Drawing.Point(150, 222);
            this.internetDiscountComboBox.Name = "internetDiscountComboBox";
            this.internetDiscountComboBox.Size = new System.Drawing.Size(92, 24);
            this.internetDiscountComboBox.TabIndex = 10;
            this.internetDiscountComboBox.SelectedIndexChanged += new System.EventHandler(this.internetDiscountComboBox_SelectedIndexChanged);
            this.internetDiscountComboBox.TextChanged += new System.EventHandler(this.internetDiscountComboBox_TextChanged);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Location = new System.Drawing.Point(226, 344);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(84, 27);
            this.editBtn.TabIndex = 11;
            this.editBtn.TabStop = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Transparent;
            this.delBtn.Location = new System.Drawing.Point(325, 344);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(76, 27);
            this.delBtn.TabIndex = 12;
            this.delBtn.TabStop = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(418, 344);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(76, 27);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // crossBtn
            // 
            this.crossBtn.BackColor = System.Drawing.Color.Transparent;
            this.crossBtn.Location = new System.Drawing.Point(472, 12);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(30, 17);
            this.crossBtn.TabIndex = 14;
            this.crossBtn.TabStop = false;
            this.crossBtn.Click += new System.EventHandler(this.crossBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.switchof;
            this.pictureBox1.Location = new System.Drawing.Point(168, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 37);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // cablePackage
            // 
            this.cablePackage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cablePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cablePackage.FormattingEnabled = true;
            this.cablePackage.Location = new System.Drawing.Point(395, 222);
            this.cablePackage.Name = "cablePackage";
            this.cablePackage.Size = new System.Drawing.Size(92, 24);
            this.cablePackage.TabIndex = 16;
            this.cablePackage.SelectedIndexChanged += new System.EventHandler(this.cablePackage_SelectedIndexChanged);
            // 
            // previousDebt
            // 
            this.previousDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.previousDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousDebt.Location = new System.Drawing.Point(24, 294);
            this.previousDebt.Multiline = true;
            this.previousDebt.Name = "previousDebt";
            this.previousDebt.Size = new System.Drawing.Size(90, 23);
            this.previousDebt.TabIndex = 17;
            // 
            // ConnectionAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.connectionAction;
            this.ClientSize = new System.Drawing.Size(514, 383);
            this.Controls.Add(this.previousDebt);
            this.Controls.Add(this.cablePackage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.internetDiscountComboBox);
            this.Controls.Add(this.cableDiscountComboBox);
            this.Controls.Add(this.AreaComboBox);
            this.Controls.Add(this.packageComboBox);
            this.Controls.Add(this.extraCharges);
            this.Controls.Add(this.mobileNumber);
            this.Controls.Add(this.AdressOfClient);
            this.Controls.Add(this.nameOfClient);
            this.Controls.Add(this.customerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionAction";
            this.Text = "ConnectionAction";
            this.Load += new System.EventHandler(this.ConnectionAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.TextBox nameOfClient;
        private System.Windows.Forms.TextBox AdressOfClient;
        private System.Windows.Forms.TextBox mobileNumber;
        private System.Windows.Forms.TextBox extraCharges;
        private System.Windows.Forms.ComboBox packageComboBox;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.ComboBox cableDiscountComboBox;
        private System.Windows.Forms.ComboBox internetDiscountComboBox;
        private System.Windows.Forms.PictureBox editBtn;
        private System.Windows.Forms.PictureBox delBtn;
        private System.Windows.Forms.PictureBox cancelBtn;
        private System.Windows.Forms.PictureBox crossBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComboBox cablePackage;
        private TextBox previousDebt;
    }
}
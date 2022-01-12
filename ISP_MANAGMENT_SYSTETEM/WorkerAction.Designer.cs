
using System;
using System.Windows.Forms;

namespace ISP_MANAGMENT_SYSTETEM
{
    partial class WorkerAction
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
            this.workerAdress = new System.Windows.Forms.TextBox();
            this.workerMobile = new System.Windows.Forms.TextBox();
            this.workerPay = new System.Windows.Forms.TextBox();
            this.commison = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.PictureBox();
            this.delBtn = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.PictureBox();
            this.crossBtn = new System.Windows.Forms.PictureBox();
            this.switchBtn = new System.Windows.Forms.PictureBox();
            this.workerArea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // workerID
            // 
            this.workerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerID.Location = new System.Drawing.Point(24, 81);
            this.workerID.Multiline = true;
            this.workerID.Name = "workerID";
            this.workerID.Size = new System.Drawing.Size(99, 20);
            this.workerID.TabIndex = 0;
            // 
            // workerName
            // 
            this.workerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.Location = new System.Drawing.Point(167, 81);
            this.workerName.Multiline = true;
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(161, 20);
            this.workerName.TabIndex = 1;
            // 
            // workerAdress
            // 
            this.workerAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerAdress.Location = new System.Drawing.Point(167, 149);
            this.workerAdress.Multiline = true;
            this.workerAdress.Name = "workerAdress";
            this.workerAdress.Size = new System.Drawing.Size(161, 20);
            this.workerAdress.TabIndex = 2;
            // 
            // workerMobile
            // 
            this.workerMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerMobile.Location = new System.Drawing.Point(24, 149);
            this.workerMobile.Multiline = true;
            this.workerMobile.Name = "workerMobile";
            this.workerMobile.Size = new System.Drawing.Size(99, 20);
            this.workerMobile.TabIndex = 3;
            // 
            // workerPay
            // 
            this.workerPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerPay.Location = new System.Drawing.Point(24, 216);
            this.workerPay.Multiline = true;
            this.workerPay.Name = "workerPay";
            this.workerPay.Size = new System.Drawing.Size(73, 20);
            this.workerPay.TabIndex = 4;
            // 
            // commison
            // 
            this.commison.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commison.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commison.Location = new System.Drawing.Point(128, 216);
            this.commison.Multiline = true;
            this.commison.Name = "commison";
            this.commison.Size = new System.Drawing.Size(73, 20);
            this.commison.TabIndex = 5;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Location = new System.Drawing.Point(145, 265);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(82, 28);
            this.editBtn.TabIndex = 7;
            this.editBtn.TabStop = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Transparent;
            this.delBtn.Location = new System.Drawing.Point(241, 265);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(80, 28);
            this.delBtn.TabIndex = 8;
            this.delBtn.TabStop = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(333, 265);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 28);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // crossBtn
            // 
            this.crossBtn.BackColor = System.Drawing.Color.Transparent;
            this.crossBtn.Location = new System.Drawing.Point(435, 10);
            this.crossBtn.Name = "crossBtn";
            this.crossBtn.Size = new System.Drawing.Size(28, 19);
            this.crossBtn.TabIndex = 10;
            this.crossBtn.TabStop = false;
            this.crossBtn.Click += new System.EventHandler(this.crossBtn_Click);
            // 
            // switchBtn
            // 
            this.switchBtn.BackColor = System.Drawing.Color.Transparent;
            this.switchBtn.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.switchof;
            this.switchBtn.Location = new System.Drawing.Point(362, 139);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(69, 38);
            this.switchBtn.TabIndex = 11;
            this.switchBtn.TabStop = false;
            this.switchBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.switchBtn_MouseDown);
            // 
            // workerArea
            // 
            this.workerArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.workerArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerArea.FormattingEnabled = true;
            this.workerArea.Location = new System.Drawing.Point(231, 215);
            this.workerArea.Name = "workerArea";
            this.workerArea.Size = new System.Drawing.Size(99, 24);
            this.workerArea.TabIndex = 12;
            // 
            // WorkerAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.workerAction;
            this.ClientSize = new System.Drawing.Size(475, 312);
            this.Controls.Add(this.workerArea);
            this.Controls.Add(this.switchBtn);
            this.Controls.Add(this.crossBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.commison);
            this.Controls.Add(this.workerPay);
            this.Controls.Add(this.workerMobile);
            this.Controls.Add(this.workerAdress);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.workerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerAction";
            this.Text = "WorkerAction";
            this.Load += new System.EventHandler(this.WorkerAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

      
        #endregion

        private System.Windows.Forms.TextBox workerID;
        private System.Windows.Forms.TextBox workerName;
        private System.Windows.Forms.TextBox workerAdress;
        private System.Windows.Forms.TextBox workerMobile;
        private System.Windows.Forms.TextBox workerPay;
        private System.Windows.Forms.TextBox commison;
        private System.Windows.Forms.PictureBox editBtn;
        private System.Windows.Forms.PictureBox delBtn;
        private System.Windows.Forms.PictureBox cancelBtn;
        private System.Windows.Forms.PictureBox crossBtn;
        private System.Windows.Forms.PictureBox switchBtn;
        private System.Windows.Forms.ComboBox workerArea;
    }
}
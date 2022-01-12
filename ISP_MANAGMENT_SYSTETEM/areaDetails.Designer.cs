
using System;

namespace ISP_MANAGMENT_SYSTETEM
{
    partial class areaDetails
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
            this.areaName = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.PictureBox();
            this.submitBtn = new System.Windows.Forms.PictureBox();
            this.crossCancelBtn = new System.Windows.Forms.PictureBox();
            this.workerName = new System.Windows.Forms.ComboBox();
            this.thirdWorkerName = new System.Windows.Forms.ComboBox();
            this.secondWorkerName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossCancelBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // areaName
            // 
            this.areaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaName.Location = new System.Drawing.Point(23, 79);
            this.areaName.Multiline = true;
            this.areaName.Name = "areaName";
            this.areaName.Size = new System.Drawing.Size(103, 25);
            this.areaName.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(176, 210);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(79, 27);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.Location = new System.Drawing.Point(283, 210);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(79, 27);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.TabStop = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_ClickAsync);
            // 
            // crossCancelBtn
            // 
            this.crossCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.crossCancelBtn.Location = new System.Drawing.Point(341, 11);
            this.crossCancelBtn.Name = "crossCancelBtn";
            this.crossCancelBtn.Size = new System.Drawing.Size(28, 19);
            this.crossCancelBtn.TabIndex = 6;
            this.crossCancelBtn.TabStop = false;
            this.crossCancelBtn.Click += new System.EventHandler(this.crossCancelBtn_Click);
            // 
            // workerName
            // 
            this.workerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.FormattingEnabled = true;
            this.workerName.Location = new System.Drawing.Point(167, 80);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(163, 24);
            this.workerName.TabIndex = 7;
            // 
            // thirdWorkerName
            // 
            this.thirdWorkerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.thirdWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdWorkerName.FormattingEnabled = true;
            this.thirdWorkerName.Location = new System.Drawing.Point(167, 147);
            this.thirdWorkerName.Name = "thirdWorkerName";
            this.thirdWorkerName.Size = new System.Drawing.Size(163, 24);
            this.thirdWorkerName.TabIndex = 8;
            // 
            // secondWorkerName
            // 
            this.secondWorkerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondWorkerName.FormattingEnabled = true;
            this.secondWorkerName.Location = new System.Drawing.Point(23, 147);
            this.secondWorkerName.Name = "secondWorkerName";
            this.secondWorkerName.Size = new System.Drawing.Size(100, 24);
            this.secondWorkerName.TabIndex = 9;
            // 
            // areaDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.areaDetails;
            this.ClientSize = new System.Drawing.Size(383, 255);
            this.Controls.Add(this.secondWorkerName);
            this.Controls.Add(this.thirdWorkerName);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.crossCancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.areaName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "areaDetails";
            this.Text = "areaDetails";
            this.Load += new System.EventHandler(this.areaDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossCancelBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox areaName;
        private System.Windows.Forms.PictureBox cancelBtn;
        private System.Windows.Forms.PictureBox submitBtn;
        private System.Windows.Forms.PictureBox crossCancelBtn;
        private System.Windows.Forms.ComboBox workerName;
        private System.Windows.Forms.ComboBox thirdWorkerName;
        private System.Windows.Forms.ComboBox secondWorkerName;
    }
}